using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatricula.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class frmHorario : Form
    {
        DataSet dsHorario;
        DataTable dtHorario;
        private bool iniciandoHorario = true;

        public frmHorario()
        {
            InitializeComponent();
        }

        private void frmHorario_Load(object sender, EventArgs e)
        {
            CargarGridHorario();
            iniciandoHorario = false;
        }

        private void dgvHorario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvHorario.CurrentCell.RowIndex;
                int Horario_id = int.Parse(this.dgvHorario[0, numeroFila].Value.ToString());

                using (GestorHorario Horario = new GestorHorario())
                {
                    this.dsHorario = Horario.ConsultarHorario(Horario_id);
                    this.dtHorario = this.dsHorario.Tables[0];
                }
                CargarDatosHorario();

            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInsertarHorario_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorHorario elHorario = new GestorHorario())
                {
                    elHorario.InsertarHorario(txtHorario_descripcion.Text, txtHorario_dia.Text,
                                              txtHorario_horaInicio.Text, txtHorario_horaFinal.Text, "A");
                }
                CargarGridHorario();
                BorrarDatosHorario();
                MessageBox.Show("Datos de Horario agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorHorario elHorario = new GestorHorario())
                {
                    elHorario.ModificarHorario(int.Parse(this.dtHorario.Rows[0]["Horario_id"].ToString()), txtHorario_descripcion.Text, txtHorario_dia.Text,
                                            txtHorario_horaInicio.Text, txtHorario_horaFinal.Text, "A");
                }
                CargarGridHorario();
                BorrarDatosHorario();
                MessageBox.Show("Horario modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtHorario = null;
                dsHorario = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Horario no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorHorario elHorario = new GestorHorario())
                {
                    if (int.Parse(this.dtHorario.Rows[0]["Horario_id"].ToString()) != 0)
                        elHorario.InactivarHorario(int.Parse(this.dtHorario.Rows[0]["Horario_id"].ToString()));
                }
                CargarGridHorario();
                MessageBox.Show("Horario Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtHorario = null;
                dsHorario = null;
                BorrarDatosHorario();


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Horario no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------

        private void CargarGridHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                dgvHorario.DataSource = elHorario.ListarHorario();

                dgvHorario.Columns["Horario_id"].Visible = false;
                dgvHorario.Columns["Horario_descripcion"].HeaderText = "Descripción";
                dgvHorario.Columns["Horario_dia"].HeaderText = "Día";
                dgvHorario.Columns["Horario_horaInicio"].HeaderText = "Hora Inicio";
                dgvHorario.Columns["Horario_horaFinal"].HeaderText = "Hora Final";
                dgvHorario.Columns["Horario_estado"].Visible = false;
            }

        }

        private void CargarDatosHorario()
        {
            try
            {
                txtHorario_descripcion.Text = this.dtHorario.Rows[0]["Horario_descripcion"].ToString();
                txtHorario_dia.Text = this.dtHorario.Rows[0]["Horario_dia"].ToString();
                txtHorario_horaInicio.Text = this.dtHorario.Rows[0]["Horario_horaInicio"].ToString();
                txtHorario_horaFinal.Text = this.dtHorario.Rows[0]["Horario_horaFinal"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Estudiante no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BorrarDatosHorario()
        {
            txtHorario_descripcion.Text = "";
            txtHorario_dia.Text = "";
            txtHorario_horaInicio.Text = "";
            txtHorario_horaFinal.Text = "";
        }

        private int Validar()
        {
            epError.Clear();
            if (txtHorario_descripcion.Text.Trim() == "")
            {
                epError.SetError(txtHorario_descripcion, "Insertar Descripción...");
                txtHorario_descripcion.Focus();
                return 1;

            }
            else if (txtHorario_dia.Text.Trim() == "")
            {
                epError.SetError(txtHorario_dia, "Insertar Día...");
                txtHorario_dia.Focus();
                return 1;
            }
            else if (txtHorario_horaInicio.Text.Trim() == "")
            {
                epError.SetError(txtHorario_horaInicio, "Insertar Hora Inicio...");
                txtHorario_horaInicio.Focus();
                return 1;
            }
            else if (txtHorario_horaFinal.Text.Trim() == "")
            {
                epError.SetError(txtHorario_horaFinal, "Insertar Hora Final...");
                txtHorario_horaFinal.Focus();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void lbxBuscarHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoHorario) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_horario.Text = this.lbxBuscarHorario.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvHorario.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvHorario.Rows)
                {

                    if (fila.Cells["Horario_descripcion"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_horario.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_horario.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_horario.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Horario_descripcion"].Value.ToString())
                        {

                            this.dgvHorario.Rows[fila.Index].Selected = true;

                            this.dgvHorario.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_horario.Text == fila.Cells["Horario_descripcion"].Value.ToString())
                        {
                            this.dgvHorario.Rows[fila.Index].Selected = true;

                            this.dgvHorario.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show(" Seleccione una opción", "Seleccion no valida",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtFiltar_horario_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoHorario)
                return;

            DataRow[] filas;

            using (GestorHorario elHorario = new GestorHorario())
            {
                dgvHorario.DataSource = elHorario.ListarHorario();
                filas = elHorario.ListarHorario().Select("Horario_descripcion LIKE '%" + txtFiltar_horario.Text + "%'");

                this.lbxBuscarHorario.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarHorario.Items.Add(dr["Horario_descripcion"].ToString() + " , " +
                            dr["Horario_id"].ToString());
                    }

                }
            }
        }

        private void frmHorario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form principal = new frmPrincipal("si");
            principal.Show();
        }
    }
}

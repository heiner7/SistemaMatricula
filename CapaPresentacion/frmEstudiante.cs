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
    public partial class frmEstudiante : Form
    {

        public frmEstudiante(string activar)
        {
            InitializeComponent();
            if (activar == "si")
            {
                btnGenerarReporte.Enabled = true;
                btnInactivar.Enabled = true;
            }
            
        }

        DataSet dsEstudiante;
        DataTable dtEstudiante;
        private bool iniciandoEstudiante = true;

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
           // btnGenerarReporte.Enabled = false;
            CargarGridEstudiante();
            CargarComboGrupo();
            CargarComboConsulta();
            iniciandoEstudiante = false;
        }

        //Metodo Insertar
        private void btnInsertarEstudiante_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorEstudiante elEstudiante = new GestorEstudiante())
                {
                    elEstudiante.InsertarEstudiante(int.Parse(cbxGrupo.SelectedValue.ToString()), txtEstudiante_cedula.Text,
                                                    txtEstudiante_nombre.Text, txtEstudiante_primerApellido.Text, txtEstudiante_segundoApellido.Text,
                                                    txtEstudiante_telefono.Text, txtEstudiante_correoElectronico.Text, txtEstudiante_direccion.Text, "A");
                }
                CargarGridEstudiante();
                BorrarDatosEstudiante();
                MessageBox.Show("Estudiante agregado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }                            

        private void btnModificarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorEstudiante elEstudiante = new GestorEstudiante())
                {
                    elEstudiante.ModificarEstudiante(int.Parse(this.dtEstudiante.Rows[0]["Estudiante_id"].ToString()), int.Parse(cbxGrupo.SelectedValue.ToString()), txtEstudiante_cedula.Text,
                                                    txtEstudiante_nombre.Text, txtEstudiante_primerApellido.Text, txtEstudiante_segundoApellido.Text,
                                                    txtEstudiante_telefono.Text, txtEstudiante_correoElectronico.Text, txtEstudiante_direccion.Text, "A");
                }
                dtEstudiante = null;
                dsEstudiante = null;
                CargarGridEstudiante();
                BorrarDatosEstudiante();
                MessageBox.Show("Estudiante modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Estudiante no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
                using (GestorEstudiante Estudiante = new GestorEstudiante())
                {
                    this.dsEstudiante = Estudiante.ConsultarEstudiante(int.Parse(cbxConsulta.SelectedValue.ToString()));
                    this.dtEstudiante = this.dsEstudiante.Tables[0];
                    CargarDatosEstudiante();
                }
            
        }


        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvEstudiantes.CurrentCell.RowIndex;
                int Estudiante_id = int.Parse(this.dgvEstudiantes[0, numeroFila].Value.ToString());

                using (GestorEstudiante Estudiante = new GestorEstudiante())
                {
                    this.dsEstudiante = Estudiante.ConsultarEstudiante(Estudiante_id);
                    this.dtEstudiante = this.dsEstudiante.Tables[0];
                }
                CargarDatosEstudiante();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------

        private void lbxBuscarEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoEstudiante) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_estudiante.Text = this.lbxBuscarEstudiante.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvEstudiantes.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvEstudiantes.Rows)
                {

                    if (fila.Cells["Estudiante_primerApellido"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_estudiante.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_estudiante.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_estudiante.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Estudiante_primerApellido"].Value.ToString())
                        {

                            this.dgvEstudiantes.Rows[fila.Index].Selected = true;

                            this.dgvEstudiantes.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_estudiante.Text == fila.Cells["Estudiante_primerApellido_nombre"].Value.ToString())
                        {
                            this.dgvEstudiantes.Rows[fila.Index].Selected = true;

                            this.dgvEstudiantes.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void txtFiltar_estudiante_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoEstudiante)
                return;

            DataRow[] filas;

            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                dgvEstudiantes.DataSource = elEstudiante.ListarEstudiante();
                filas = elEstudiante.ListarEstudiante().Select("Estudiante_primerApellido LIKE '%" + txtFiltar_estudiante.Text + "%'");

                this.lbxBuscarEstudiante.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarEstudiante.Items.Add(dr["Estudiante_primerApellido"].ToString() + " , " +
                            dr["Estudiante_cedula"].ToString());
                    }

                }
            }
        }

        private void CargarDatosEstudiante()
        {
            try
            {
                txtEstudiante_cedula.Text = this.dtEstudiante.Rows[0]["Estudiante_cedula"].ToString();
                txtEstudiante_nombre.Text = this.dtEstudiante.Rows[0]["Estudiante_nombre"].ToString();
                txtEstudiante_primerApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_primerApellido"].ToString();
                txtEstudiante_segundoApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_segundoApellido"].ToString();
                txtEstudiante_telefono.Text = this.dtEstudiante.Rows[0]["Estudiante_telefono"].ToString();
                txtEstudiante_correoElectronico.Text = this.dtEstudiante.Rows[0]["Estudiante_correoElectronico"].ToString();
                txtEstudiante_direccion.Text = this.dtEstudiante.Rows[0]["Estudiante_direccion"].ToString();
                cbxConsulta.SelectedValue = this.dtEstudiante.Rows[0]["Estudiante_id"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Estudiante no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CargarComboGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                cbxGrupo.DataSource = elGrupo.ListarGrupo();
                cbxGrupo.ValueMember = "Grupo_id";
                cbxGrupo.DisplayMember = "Grupo_descripcion";
            }
        }
        private void CargarComboConsulta()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                cbxConsulta.DataSource = elEstudiante.ListarEstudiante();
                cbxConsulta.ValueMember = "Estudiante_id";
                cbxConsulta.DisplayMember = "Estudiante_id";
            }
        }
        private void CargarGridEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                dgvEstudiantes.DataSource = elEstudiante.ListarEstudiante();

                dgvEstudiantes.Columns["Estudiante_id"].Visible = false;
                dgvEstudiantes.Columns["Grupo_id"].HeaderText = "Grupo";
                dgvEstudiantes.Columns["Estudiante_cedula"].HeaderText = "Cédula";
                dgvEstudiantes.Columns["Estudiante_nombre"].HeaderText = "Nombre";
                dgvEstudiantes.Columns["Estudiante_primerApellido"].HeaderText = "Apellido";
                dgvEstudiantes.Columns["Estudiante_segundoApellido"].HeaderText = "Apellido2";
                dgvEstudiantes.Columns["Estudiante_telefono"].HeaderText = "Teléfono";
                dgvEstudiantes.Columns["Estudiante_correoElectronico"].HeaderText = "Email";
                dgvEstudiantes.Columns["Estudiante_direccion"].HeaderText = "Direccion";
                dgvEstudiantes.Columns["Estudiante_estado"].Visible = false;
            }

        }

        private void BorrarDatosEstudiante()
        {
                txtEstudiante_cedula.Text = "";
                txtEstudiante_nombre.Text = 
                txtEstudiante_primerApellido.Text = "";
                txtEstudiante_segundoApellido.Text = "";
                txtEstudiante_telefono.Text = "";
                txtEstudiante_correoElectronico.Text = "";
                txtEstudiante_direccion.Text = "";
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                using (GestorEstudiante elEstudiante = new GestorEstudiante())
                {
                    if (int.Parse(this.dtEstudiante.Rows[0]["Estudiante_id"].ToString()) != 0)
                        elEstudiante.InactivarEstudiante(int.Parse(this.dtEstudiante.Rows[0]["Estudiante_id"].ToString()));
                }
                dtEstudiante = null;
                dsEstudiante = null;
                BorrarDatosEstudiante();
                CargarGridEstudiante();
                MessageBox.Show("Estudiante inactivado de la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Estudiante no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private int Validar()
        {
            epError.Clear();
            if (txtEstudiante_cedula.Text.Trim() == "")
            {
                epError.SetError(txtEstudiante_cedula, "Insertar Cedula...");
                txtEstudiante_cedula.Focus();
                return 1;

            }
            else if (txtEstudiante_nombre.Text.Trim() == "")
            {
                epError.SetError(txtEstudiante_nombre, "Insertar Nombre...");
                txtEstudiante_nombre.Focus();
                return 1;
            }
            else if (txtEstudiante_primerApellido.Text.Trim() == "")
            {
                epError.SetError(txtEstudiante_primerApellido, "Insertar primerApellido...");
                txtEstudiante_primerApellido.Focus();
                return 1;
            }
            else if (txtEstudiante_segundoApellido.Text.Trim() == "")
            {
                epError.SetError(txtEstudiante_segundoApellido, "Insertar segundoApellido...");
                txtEstudiante_segundoApellido.Focus();
                return 1;
            }
            else if (txtEstudiante_direccion.Text.Trim() == "")
            {
                epError.SetError(txtEstudiante_direccion, "Insertar direccion...");
                txtEstudiante_direccion.Focus();
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            frm_reportviewer formReportViewer = new frm_reportviewer(int.Parse(cbxConsulta.SelectedValue.ToString()), "Estudiante");
            //Pasamos por parámetro TAG el número del índice del reporte seleccionado 
            formReportViewer.Tag = cmb_reports.SelectedIndex;
            formReportViewer.ShowDialog();
        }

        private void frmEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form principal = new frmPrincipal("si");
            principal.Show();
        }
    }
}

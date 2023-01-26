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
    public partial class frmProfesor : Form
    {
        public frmProfesor(string activar)
        {
            InitializeComponent();
            if (activar == "si")
            {
                btnGenerarReporte.Enabled = true;
                btnEliminarProfesor.Enabled = true;
            }
        }

        private bool iniciandoProfesor = true;
        DataSet dsProfesor;
        DataTable dtProfesor;

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            CargarGridProfesor();
            CargarComboConsulta();
            this.txtFiltar_profesor.Text = "";
            iniciandoProfesor = false;
        }

        private void dgvProfesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvProfesor.CurrentCell.RowIndex;
                int Profesor_id = int.Parse(this.dgvProfesor[0, numeroFila].Value.ToString());

                using (GestorProfesor Profesor = new GestorProfesor())
                {
                    this.dsProfesor = Profesor.ConsultarProfesor(Profesor_id);
                    this.dtProfesor = this.dsProfesor.Tables[0];
                }
                CargarDatosProfesor();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInsertarProfesor_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorProfesor elProfesor = new GestorProfesor())
                {
                    elProfesor.InsertarProfesor(txtProfesor_cedula.Text, txtProfesor_nombre.Text, txtProfesor_primerApellido.Text,
                                                txtProfesor_segundoApellido.Text, txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text,
                                                txtProfesor_direccion.Text, "A");
                }
                CargarGridProfesor();
                BorrarDatosProfesor();
                MessageBox.Show("Datos de Profesor agregado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorProfesor elProfesor = new GestorProfesor())
                {
                    elProfesor.ModificarProfesor(int.Parse(this.dtProfesor.Rows[0]["Profesor_id"].ToString()), txtProfesor_cedula.Text, txtProfesor_nombre.Text,
                                                txtProfesor_primerApellido.Text, txtProfesor_segundoApellido.Text, txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text,
                                                txtProfesor_direccion.Text, "A");
                }
                CargarGridProfesor();
                BorrarDatosProfesor();
                MessageBox.Show("Datos de Profesor modificado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Profesor no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorProfesor elProfesor = new GestorProfesor())
                {
                    if (int.Parse(this.dtProfesor.Rows[0]["Profesor_id"].ToString()) != 0)
                        elProfesor.InactivarProfesor(int.Parse(this.dtProfesor.Rows[0]["Profesor_id"].ToString()));
                }
                dtProfesor = null;
                dsProfesor = null;
                BorrarDatosProfesor();
                CargarGridProfesor();
                MessageBox.Show("Datos de Profesor Inactivado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Profesor no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConsultarProfesor_Click(object sender, EventArgs e)
        {
            using (GestorProfesor Profesor = new GestorProfesor())
            {
                this.dsProfesor = Profesor.ConsultarProfesor(int.Parse(cbxConsulta.SelectedValue.ToString()));
                this.dtProfesor = this.dsProfesor.Tables[0];
                CargarDatosProfesor();
            }
        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------
        private void CargarGridProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                dgvProfesor.DataSource = elProfesor.ListarProfesor();

                dgvProfesor.Columns["Profesor_id"].Visible = false;
                dgvProfesor.Columns["Profesor_cedula"].HeaderText = "Cédula";
                dgvProfesor.Columns["Profesor_nombre"].HeaderText = "Nombre";
                dgvProfesor.Columns["Profesor_primerApellido"].HeaderText = "Apellido";
                dgvProfesor.Columns["Profesor_segundoApellido"].HeaderText = "Apellido2";
                dgvProfesor.Columns["Profesor_telefono"].HeaderText = "Teléfono";
                dgvProfesor.Columns["Profesor_correoElectronico"].HeaderText = "Email";
                dgvProfesor.Columns["Profesor_direccion"].HeaderText = "Direccion";
                dgvProfesor.Columns["Profesor_estado"].Visible = false;
            }

        }

        private void CargarDatosProfesor()
        {
            try
            {
                txtProfesor_cedula.Text = this.dtProfesor.Rows[0]["Profesor_cedula"].ToString();
                txtProfesor_nombre.Text = this.dtProfesor.Rows[0]["Profesor_nombre"].ToString();
                txtProfesor_primerApellido.Text = this.dtProfesor.Rows[0]["Profesor_primerApellido"].ToString();
                txtProfesor_segundoApellido.Text = this.dtProfesor.Rows[0]["Profesor_segundoApellido"].ToString();
                txtProfesor_telefono.Text = this.dtProfesor.Rows[0]["Profesor_telefono"].ToString();
                txtProfesor_correoElectronico.Text = this.dtProfesor.Rows[0]["Profesor_correoElectronico"].ToString();
                txtProfesor_direccion.Text = this.dtProfesor.Rows[0]["Profesor_direccion"].ToString();
                cbxConsulta.SelectedValue = this.dtProfesor.Rows[0]["Profesor_id"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Profesor no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BorrarDatosProfesor()
        {
            txtProfesor_cedula.Text = "";
            txtProfesor_nombre.Text =
            txtProfesor_primerApellido.Text = "";
            txtProfesor_segundoApellido.Text = "";
            txtProfesor_telefono.Text = "";
            txtProfesor_correoElectronico.Text = "";
            txtProfesor_direccion.Text = "";
        }
        private void CargarComboConsulta()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                cbxConsulta.DataSource = elProfesor.ListarProfesor();
                cbxConsulta.ValueMember = "Profesor_id";
                cbxConsulta.DisplayMember = "Profesor_id";
            }
        }
        private int Validar()
        {
            epError.Clear();
            if (txtProfesor_cedula.Text.Trim() == "")
            {
                epError.SetError(txtProfesor_cedula, "Insertar Cedula...");
                txtProfesor_cedula.Focus();
                return 1;

            }
            else if (txtProfesor_nombre.Text.Trim() ==  "")
            {
                epError.SetError(txtProfesor_nombre, "Insertar Nombre...");
                txtProfesor_nombre.Focus();
                return 1;
            }
            else if (txtProfesor_primerApellido.Text.Trim() == "")
            {
                epError.SetError(txtProfesor_primerApellido, "Insertar primerApellido...");
                txtProfesor_primerApellido.Focus();
                return 1;
            }
            else if (txtProfesor_segundoApellido.Text.Trim() == "")
            {
                epError.SetError(txtProfesor_segundoApellido, "Insertar segundoApellido...");
                txtProfesor_segundoApellido.Focus();
                return 1;
            }
            else if (txtProfesor_direccion.Text.Trim() == "")
            {
                epError.SetError(txtProfesor_direccion, "Insertar direccion...");
                txtProfesor_direccion.Focus();
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        private void txtFiltar_profesor_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoProfesor)
                return;

            DataRow[] filas;

            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                dgvProfesor.DataSource = elProfesor.ListarProfesor();
                filas = elProfesor.ListarProfesor().Select("Profesor_primerApellido LIKE '%" + txtFiltar_profesor.Text + "%'");

                this.lbxBuscarProfesor.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarProfesor.Items.Add(dr["Profesor_primerApellido"].ToString() + " , " +
                            dr["Profesor_cedula"].ToString());
                    }

                }
            }

        }

        private void lbxBuscarProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoProfesor) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_profesor.Text = this.lbxBuscarProfesor.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvProfesor.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvProfesor.Rows)
                {

                    if (fila.Cells["Profesor_primerApellido"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_profesor.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_profesor.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_profesor.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Profesor_primerApellido"].Value.ToString())
                        {

                            this.dgvProfesor.Rows[fila.Index].Selected = true;

                            this.dgvProfesor.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_profesor.Text == fila.Cells["Profesor_primerApellido_nombre"].Value.ToString())
                        {
                            this.dgvProfesor.Rows[fila.Index].Selected = true;

                            this.dgvProfesor.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            frm_reportviewer formReportViewer = new frm_reportviewer(int.Parse(cbxConsulta.SelectedValue.ToString()), "Profesor");
            //Pasamos por parámetro TAG el número del índice del reporte seleccionado 
            formReportViewer.Tag = cmb_reports.SelectedIndex;
            //formReportViewer.session = this.session; 
            formReportViewer.ShowDialog();
        }

        private void frmProfesor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form principal = new frmPrincipal("si");
            principal.Show();
        }
    }
    
}

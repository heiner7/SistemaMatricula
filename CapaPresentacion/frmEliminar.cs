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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        DataSet dsEstudiante;
        DataTable dtEstudiante;

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 0)

            {
                CargarGridEstudiante();
            }
            else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 1)
            {
                CargarGridProfesor();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 0)
                {
                    using (GestorEstudiante elEstudiante = new GestorEstudiante())
                    {
                        if (int.Parse(this.dtEstudiante.Rows[0]["Estudiante_id"].ToString()) != 0)
                            elEstudiante.EliminarEstudiante(int.Parse(this.dtEstudiante.Rows[0]["Estudiante_id"].ToString()));
                    }
                    dtEstudiante = null;
                    dsEstudiante = null;
                    MessageBox.Show("Estudiante eliminado de la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridEstudiante();
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 1)
                {
                    using (GestorProfesor elProfesor = new GestorProfesor())
                    {
                        if (int.Parse(this.dtEstudiante.Rows[0]["Profesor_id"].ToString()) != 0)
                            elProfesor.EliminarProfesor(int.Parse(this.dtEstudiante.Rows[0]["Profesor_id"].ToString()));
                    }
                    dtEstudiante = null;
                    dsEstudiante = null;
                    MessageBox.Show("Profesor eliminado de la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGridProfesor();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Solicitud no procesado!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvTablas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 0)
                {
                    int numeroFila = dgvTablas.CurrentCell.RowIndex;
                    int Estudiante_id = int.Parse(this.dgvTablas[0, numeroFila].Value.ToString());

                    using (GestorEstudiante Estudiante = new GestorEstudiante())
                    {
                        this.dsEstudiante = Estudiante.ConsultarEstudiante(Estudiante_id);
                        this.dtEstudiante = this.dsEstudiante.Tables[0];
                    }
                }
                else if (int.Parse(cbxTabla.SelectedIndex.ToString()) == 1)
                {
                    int numeroFila = dgvTablas.CurrentCell.RowIndex;
                    int Profesor_id = int.Parse(this.dgvTablas[0, numeroFila].Value.ToString());

                    using (GestorProfesor Profesor = new GestorProfesor())
                    {
                        this.dsEstudiante = Profesor.ConsultarProfesor(Profesor_id);
                        this.dtEstudiante = this.dsEstudiante.Tables[0];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CargarGridEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                dgvTablas.DataSource = elEstudiante.ListarEstudiante();

                dgvTablas.Columns["Estudiante_id"].Visible = false;
                dgvTablas.Columns["Estudiante_cedula"].HeaderText = "Cédula";
                dgvTablas.Columns["Estudiante_nombre"].HeaderText = "Nombre";
                dgvTablas.Columns["Estudiante_primerApellido"].HeaderText = "Apellido";
                dgvTablas.Columns["Estudiante_segundoApellido"].HeaderText = "Apellido2";
                dgvTablas.Columns["Estudiante_telefono"].HeaderText = "Teléfono";
                dgvTablas.Columns["Estudiante_correoElectronico"].HeaderText = "Email";
                dgvTablas.Columns["Estudiante_direccion"].HeaderText = "Direccion";
                dgvTablas.Columns["Estudiante_estado"].Visible = false;
            }
        }

        private void CargarGridProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                dgvTablas.DataSource = elProfesor.ListarProfesor();

                dgvTablas.Columns["Profesor_id"].Visible = false;
                dgvTablas.Columns["Profesor_cedula"].HeaderText = "Cédula";
                dgvTablas.Columns["Profesor_nombre"].HeaderText = "Nombre";
                dgvTablas.Columns["Profesor_primerApellido"].HeaderText = "Apellido";
                dgvTablas.Columns["Profesor_segundoApellido"].HeaderText = "Apellido2";
                dgvTablas.Columns["Profesor_telefono"].HeaderText = "Teléfono";
                dgvTablas.Columns["Profesor_correoElectronico"].HeaderText = "Email";
                dgvTablas.Columns["Profesor_direccion"].HeaderText = "Direccion";
                dgvTablas.Columns["Profesor_estado"].Visible = false;
            }
        }

        private void frmEliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form principal = new frmPrincipal("si");
            principal.Show();
        }
    }
}

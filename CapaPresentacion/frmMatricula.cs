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
    public partial class frmMatricula : Form
    {
        DataSet dsMatricula;
        DataTable dtMatricula;
        private bool iniciandoMatricula = true;

        public frmMatricula()
        {
            InitializeComponent();
        }

        private void frmMatricula_Load(object sender, EventArgs e)
        {
            CargarComboEstudiante();
            CargarComboGrupo();
            CargarComboCurso();
            CargarComboProfesor();
            CargarComboHorario();
            CargarComboAula();
            CargarGridMatricula();
            iniciandoMatricula = false;
        }

        private void btnInsertarMatricula_Click(object sender, EventArgs e)
        {

            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                laMatricula.InsertarMatricula(int.Parse(cbxEstudiante.SelectedValue.ToString()), int.Parse(cbxGrupo.SelectedValue.ToString()), int.Parse(cbxCurso.SelectedValue.ToString()),
                                              int.Parse(cbxProfesor.SelectedValue.ToString()), int.Parse(cbxHorario.SelectedValue.ToString()), int.Parse(cbxAula.SelectedValue.ToString()), txtMatri_comprobante.Text, "A");
            }
            CargarGridMatricula();
            txtMatri_comprobante.Clear();
            MessageBox.Show("Matricula agregado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (GestorMatricula elMatricula = new GestorMatricula())
                {
                    elMatricula.ModificarMatricula(int.Parse(this.dtMatricula.Rows[0]["Matricula_id"].ToString()), int.Parse(cbxEstudiante.SelectedValue.ToString()), int.Parse(cbxGrupo.SelectedValue.ToString()), int.Parse(cbxCurso.SelectedValue.ToString()),
                                                   int.Parse(cbxProfesor.SelectedValue.ToString()), int.Parse(cbxHorario.SelectedValue.ToString()), int.Parse(cbxAula.SelectedValue.ToString()), txtMatri_comprobante.Text, "A");
                }
                dtMatricula = null;
                dsMatricula = null;
                MessageBox.Show("Matricula modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridMatricula();
                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Matricula no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvMatricula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvMatricula.CurrentCell.RowIndex;
                int Matricula_id = int.Parse(this.dgvMatricula[0, numeroFila].Value.ToString());

                using (GestorMatricula Matricula = new GestorMatricula())
                {
                    this.dsMatricula = Matricula.ConsultarMatricula(Matricula_id);
                    this.dtMatricula = this.dsMatricula.Tables[0];
                }
                CargarDatosMatricula();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                using (GestorMatricula laMatricula = new GestorMatricula())
                {
                    if (int.Parse(this.dtMatricula.Rows[0]["Matricula_id"].ToString()) != 0)
                        laMatricula.InactivarMatricula(int.Parse(this.dtMatricula.Rows[0]["Matricula_id"].ToString()));
                }
                dtMatricula = null;
                dsMatricula = null;
                txtMatri_comprobante.Clear();
                CargarGridMatricula();
                MessageBox.Show("Matricula inactivado de la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Matricula no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------

        private void CargarComboEstudiante()
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                cbxEstudiante.DataSource = elEstudiante.ListarEstudiante();
                cbxEstudiante.ValueMember = "Estudiante_id";
                cbxEstudiante.DisplayMember = "Estudiante_nombre";
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

        private void CargarComboCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                cbxCurso.DataSource = elCurso.ListarCurso();
                cbxCurso.ValueMember = "Curso_id";
                cbxCurso.DisplayMember = "Curso_nombre";
            }
        }

        private void CargarComboProfesor()
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                cbxProfesor.DataSource = elProfesor.ListarProfesor();
                cbxProfesor.ValueMember = "Profesor_id";
                cbxProfesor.DisplayMember = "Profesor_nombre";
            }
        }

        private void CargarComboHorario()
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                cbxHorario.DataSource = elHorario.ListarHorario();
                cbxHorario.ValueMember = "Horario_id";
                cbxHorario.DisplayMember = "Horario_descripcion";
            }
        }

        private void CargarComboAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                cbxAula.DataSource = elAula.ListarAula();
                cbxAula.ValueMember = "Aula_id";
                cbxAula.DisplayMember = "Aula_descripcion";
            }
        }

        private void CargarGridMatricula()
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                dgvMatricula.DataSource = laMatricula.ListarMatricula();

                dgvMatricula.Columns["Matricula_id"].Visible = false;
                dgvMatricula.Columns["Estudiante_id"].HeaderText = "Estudiante";
                dgvMatricula.Columns["Grupo_id"].HeaderText = "Grupo";
                dgvMatricula.Columns["Curso_id"].HeaderText = "Curso";
                dgvMatricula.Columns["Profesor_id"].HeaderText = "Profesor";
                dgvMatricula.Columns["Horario_id"].HeaderText = "Horario";
                dgvMatricula.Columns["Aula_id"].HeaderText = "Aula";
                dgvMatricula.Columns["Matricula_comprobante"].HeaderText = "Comprobante";
                dgvMatricula.Columns["Matricula_estado"].Visible = false;
            }

        }

        private void CargarDatosMatricula()
        {
            txtMatri_comprobante.Text = this.dtMatricula.Rows[0]["Matricula_comprobante"].ToString();
            cbxAula.SelectedValue = this.dtMatricula.Rows[0]["Aula_id"].ToString();
            cbxCurso.SelectedValue = this.dtMatricula.Rows[0]["Curso_id"].ToString();
            cbxEstudiante.SelectedValue = this.dtMatricula.Rows[0]["Estudiante_id"].ToString();
            cbxGrupo.SelectedValue = this.dtMatricula.Rows[0]["Grupo_id"].ToString();
            cbxHorario.SelectedValue = this.dtMatricula.Rows[0]["Horario_id"].ToString();
            cbxProfesor.SelectedValue = this.dtMatricula.Rows[0]["Profesor_id"].ToString();

        }

        private void lbxBuscarMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoMatricula) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_matricula.Text = this.lbxBuscarMatricula.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvMatricula.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvMatricula.Rows)
                {

                    if (fila.Cells["Estudiante_primerApellido"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_matricula.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_matricula.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_matricula.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Estudiante_primerApellido"].Value.ToString())
                        {

                            this.dgvMatricula.Rows[fila.Index].Selected = true;

                            this.dgvMatricula.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_matricula.Text == fila.Cells["Estudiante_primerApellido_nombre"].Value.ToString())
                        {
                            this.dgvMatricula.Rows[fila.Index].Selected = true;

                            this.dgvMatricula.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void txtFiltar_matricula_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoMatricula)
                return;

            DataRow[] filas;

            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                dgvMatricula.DataSource = laMatricula.ListarMatricula();
                filas = laMatricula.ListarMatricula().Select("Matricula_comprobante LIKE '%" + txtFiltar_matricula.Text + "%'");

                this.lbxBuscarMatricula.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarMatricula.Items.Add(dr["Matricula_comprobante"].ToString() + " , " +
                            dr["Matricula_id"].ToString());
                    }

                }
            }
        }

        private void frmMatricula_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form principal = new frmPrincipal("si");
            principal.Show();
        }
    }
}

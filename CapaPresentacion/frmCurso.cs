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
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }

        DataSet dsCurso;
        DataTable dtCurso;
        private bool iniciandoCurso = true;

        private void frmCurso_Load(object sender, EventArgs e)
        {
            CargarGridCurso();
            iniciandoCurso = false;
        }

        private void btnInsertarCupo_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorCurso elCurso = new GestorCurso())
                {
                    elCurso.InsertarCurso(txtCurso_nombre.Text, txtCurso_creditos.Text, txtCurso_cupo.Text, "A");
                }
                MessageBox.Show("Curso agregado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridCurso();
                dtCurso = null;
                dsCurso = null;
                BorrarDatosCurso();
            }
        }

        private void btnModificarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorCurso elCurso = new GestorCurso())
                {
                    elCurso.ModificarCurso(int.Parse(this.dtCurso.Rows[0]["Curso_id"].ToString()),
                                           txtCurso_nombre.Text, txtCurso_creditos.Text, txtCurso_cupo.Text, "A");
                }
                CargarGridCurso();
                dtCurso = null;
                dsCurso = null;
                BorrarDatosCurso();
                MessageBox.Show("Curso modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Curso no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvCurso.CurrentCell.RowIndex;
                int Curso_id = int.Parse(this.dgvCurso[0, numeroFila].Value.ToString());

                using (GestorCurso Curso = new GestorCurso())
                {
                    this.dsCurso = Curso.ConsultarCurso(Curso_id);
                    this.dtCurso = this.dsCurso.Tables[0];
                }
                CargarDatosCurso();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorCurso elCurso = new GestorCurso())
                {
                    if (int.Parse(this.dtCurso.Rows[0]["Curso_id"].ToString()) != 0)
                        elCurso.InactivarCurso(int.Parse(this.dtCurso.Rows[0]["Curso_id"].ToString()));
                }
                dtCurso = null;
                dsCurso = null;
                BorrarDatosCurso();
                CargarGridCurso();
                MessageBox.Show("Curso inactivado de la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Curso no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //-----------------------------------------------------Parte de metodos----------------------------------------------------------------------------------

        private void CargarDatosCurso()
        {
            try
            {
                txtCurso_nombre.Text = this.dtCurso.Rows[0]["Curso_nombre"].ToString();
                txtCurso_creditos.Text = this.dtCurso.Rows[0]["Curso_creditos"].ToString();
                txtCurso_cupo.Text = this.dtCurso.Rows[0]["Curso_cupo"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Curso no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CargarGridCurso()
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                dgvCurso.DataSource = elCurso.ListarCurso();

                dgvCurso.Columns["Curso_id"].Visible = false;
                dgvCurso.Columns["Curso_nombre"].HeaderText = "Nombre";
                dgvCurso.Columns["Curso_creditos"].HeaderText = "Creditos";
                dgvCurso.Columns["Curso_cupo"].HeaderText = "Cupo";
                dgvCurso.Columns["Curso_estado"].Visible = false;
            }

        }

        private void BorrarDatosCurso()
        {
            txtCurso_nombre.Text = "";
            txtCurso_creditos.Text = "";
            txtCurso_cupo.Text = "";
        }

        private int Validar()
        {
            epError.Clear();
             if (txtCurso_nombre.Text.Trim() == "")
            {
                epError.SetError(txtCurso_nombre, "Insertar Nombre...");
                txtCurso_nombre.Focus();
                return 1;
            }
            else if (txtCurso_creditos.Text.Trim() == "")
            {
                epError.SetError(txtCurso_creditos, "Insertar creditos...");
                txtCurso_creditos.Focus();
                return 1;
            }
            else if (txtCurso_cupo.Text.Trim() == "")
            {
                epError.SetError(txtCurso_cupo, "Insertar cupo...");
                txtCurso_cupo.Focus();
                return 1;
            }
            
            else
            {
                return 0;
            }

        }

        private void lbxBuscarCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoCurso) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_curso.Text = this.lbxBuscarCurso.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvCurso.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvCurso.Rows)
                {

                    if (fila.Cells["Curso_nombre"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_curso.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_curso.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_curso.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Curso_nombre"].Value.ToString())
                        {

                            this.dgvCurso.Rows[fila.Index].Selected = true;

                            this.dgvCurso.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_curso.Text == fila.Cells["Curso_nombre_creditos"].Value.ToString())
                        {
                            this.dgvCurso.Rows[fila.Index].Selected = true;

                            this.dgvCurso.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void txtFiltar_curso_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoCurso)
                return;

            DataRow[] filas;

            using (GestorCurso elCurso = new GestorCurso())
            {
                dgvCurso.DataSource = elCurso.ListarCurso();
                filas = elCurso.ListarCurso().Select("Curso_nombre LIKE '%" + txtFiltar_curso.Text + "%'");

                this.lbxBuscarCurso.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarCurso.Items.Add(dr["Curso_nombre"].ToString() + " , " +
                            dr["Curso_creditos"].ToString());
                    }

                }
            }
        }

        private void frmCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form principal = new frmPrincipal("si");
            principal.Show();
        }
    }
}
    


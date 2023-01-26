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
    public partial class frmAula : Form
    {
        DataSet dsAula;
        DataTable dtAula;
        private bool iniciandoAula = true;

        public frmAula()
        {
            InitializeComponent();
        }

        private void frmAula_Load(object sender, EventArgs e)
        {
            CargarGridAula();
            iniciandoAula = false;
        }

        private void dgvAula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvAula.CurrentCell.RowIndex;
                int Aula_id = int.Parse(this.dgvAula[0, numeroFila].Value.ToString());

                using (GestorAula Aula = new GestorAula())
                {
                    this.dsAula = Aula.ConsultarAula(Aula_id);
                    this.dtAula = this.dsAula.Tables[0];
                }
                txtAula_descripcion.Text = this.dtAula.Rows[0]["Aula_descripcion"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorAula elAula = new GestorAula())
                {
                    elAula.InsertarAula(txtAula_descripcion.Text, "A");
                }
                MessageBox.Show("Aula agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridAula();
                txtAula_descripcion.Clear();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorAula elAula = new GestorAula())
                {
                    elAula.ModificarAula(int.Parse(this.dtAula.Rows[0]["Aula_id"].ToString()), txtAula_descripcion.Text, "A");
                }
                CargarGridAula();
                txtAula_descripcion.Clear();
                MessageBox.Show("Aula modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtAula = null;
                dsAula = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Aula no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorAula elAula = new GestorAula())
                {
                    if (int.Parse(this.dtAula.Rows[0]["Aula_id"].ToString()) != 0)
                        elAula.InactivarAula(int.Parse(this.dtAula.Rows[0]["Aula_id"].ToString()));
                }
                CargarGridAula();
                MessageBox.Show("Aula Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtAula = null;

                txtAula_descripcion.Clear();
                

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Aula no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbxBuscarAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoAula) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_aula.Text = this.lbxBuscarAula.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvAula.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvAula.Rows)
                {

                    if (fila.Cells["Aula_descripcion"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_aula.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_aula.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_aula.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Aula_descripcion"].Value.ToString())
                        {

                            this.dgvAula.Rows[fila.Index].Selected = true;

                            this.dgvAula.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_aula.Text == fila.Cells["Aula_descripcion"].Value.ToString())
                        {
                            this.dgvAula.Rows[fila.Index].Selected = true;

                            this.dgvAula.FirstDisplayedScrollingRowIndex = fila.Index;
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
    

        private int Validar()
        {

            if (txtAula_descripcion.Text.Trim() == "")
            {
                epError.SetError(txtAula_descripcion, "Insertar descripcion...");
                txtAula_descripcion.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void CargarGridAula()
        {
            using (GestorAula elAula = new GestorAula())
            {
                dgvAula.DataSource = elAula.ListarAula();

                dgvAula.Columns["Aula_id"].Visible = false;
                dgvAula.Columns["Aula_descripcion"].HeaderText = "Descripción";


            }

        }

        private void txtFiltar_aula_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoAula)
                return;

            DataRow[] filas;

            using (GestorAula elAula = new GestorAula())
            {
                dgvAula.DataSource = elAula.ListarAula();
                filas = elAula.ListarAula().Select("Aula_descripcion LIKE '%" + txtFiltar_aula.Text + "%'");

                this.lbxBuscarAula.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarAula.Items.Add(dr["Aula_descripcion"].ToString() + " , " +
                            dr["Aula_id"].ToString());
                    }

                }
            }
        }

        private void frmAula_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form principal = new frmPrincipal("si");
            principal.Show();
        }
    }
}

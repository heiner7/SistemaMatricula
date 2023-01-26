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
    public partial class frmGrupo : Form
    {
        DataSet dsGrupo;
        DataTable dtGrupo;
        private bool iniciandoGrupo = true;

        public frmGrupo()
        {
            InitializeComponent();
        }

        private void CargarGridGrupo()
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                dgvGrupo.DataSource = elGrupo.ListarGrupo();

                dgvGrupo.Columns["Grupo_id"].Visible = false;
                dgvGrupo.Columns["Grupo_descripcion"].HeaderText = "Descripción";

               
            }

        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            CargarGridGrupo();
            iniciandoGrupo = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorGrupo elGrupo = new GestorGrupo())
                {
                    elGrupo.InsertarGrupo(txtGrupo_descripcion.Text, "A");
                }
                MessageBox.Show("Grupo agregado exitosamente en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGridGrupo();
                txtGrupo_descripcion.Clear();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorGrupo elGrupo = new GestorGrupo())
                {
                    elGrupo.ModificarGrupo(int.Parse(this.dtGrupo.Rows[0]["Grupo_id"].ToString()), txtGrupo_descripcion.Text, "A");
                }
                CargarGridGrupo();
                txtGrupo_descripcion.Clear();
                MessageBox.Show("Grupo modificado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtGrupo = null;
                dsGrupo = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Grupo no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvGrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvGrupo.CurrentCell.RowIndex;
                int Grupo_id = int.Parse(this.dgvGrupo[0, numeroFila].Value.ToString());

                using (GestorGrupo Grupo = new GestorGrupo())
                {
                    this.dsGrupo = Grupo.ConsultarGrupo(Grupo_id);
                    this.dtGrupo = this.dsGrupo.Tables[0];
                }
                txtGrupo_descripcion.Text = this.dtGrupo.Rows[0]["Grupo_descripcion"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorGrupo elGrupo= new GestorGrupo())
                {
                    if (int.Parse(this.dtGrupo.Rows[0]["Grupo_id"].ToString()) != 0)
                        elGrupo.InactivarGrupo(int.Parse(this.dtGrupo.Rows[0]["Grupo_id"].ToString()));
                }
                MessageBox.Show("Grupo Inactivado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtGrupo = null;
                txtGrupo_descripcion.Clear();
                CargarGridGrupo(); 

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Grupo no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int Validar()
        {
            
            if (txtGrupo_descripcion.Text.Trim() == "")
            {
                epError.SetError(txtGrupo_descripcion, "Insertar descripcion...");
                txtGrupo_descripcion.Focus();
                return 1;
            }
            else
            {
                epError.Clear();
                return 0;
            }
        }

        private void lbxBuscarGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoGrupo) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_gupo.Text = this.lbxBuscarGrupo.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvGrupo.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvGrupo.Rows)
                {

                    if (fila.Cells["Grupo_descripcion"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_gupo.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_gupo.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_gupo.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Grupo_descripcion"].Value.ToString())
                        {

                            this.dgvGrupo.Rows[fila.Index].Selected = true;

                            this.dgvGrupo.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_gupo.Text == fila.Cells["Grupo_descripcion"].Value.ToString())
                        {
                            this.dgvGrupo.Rows[fila.Index].Selected = true;

                            this.dgvGrupo.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void txtFiltar_gupo_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoGrupo)
                return;

            DataRow[] filas;

            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                dgvGrupo.DataSource = elGrupo.ListarGrupo();
                filas = elGrupo.ListarGrupo().Select("Grupo_descripcion LIKE '%" + txtFiltar_gupo.Text + "%'");

                this.lbxBuscarGrupo.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarGrupo.Items.Add(dr["Grupo_descripcion"].ToString());
                    }

                }
            }
        }

        private void frmGrupo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form principal = new frmPrincipal("si");
            principal.Show();
        }
    }
}

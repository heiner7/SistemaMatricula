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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        DataSet dsUsuario;
        DataTable dtUsuario;
        private bool iniciandoUsuario = true;

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CargarGridUsuario();
            iniciandoUsuario = false;
        }

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            if (Validar() == 0)
            {
                using (GestorUsuario elUsuario = new GestorUsuario())
                {
                    elUsuario.InsertarUsuario(txtUsuario_nombre.Text, txtUsuario_contrasenna.Text, "A");
                }
                CargarGridUsuario();
                txtUsuario_nombre.Clear();
                txtUsuario_contrasenna.Clear();
                MessageBox.Show("Usuario agregado en la Base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorUsuario elUsuario = new GestorUsuario())
                {
                    elUsuario.ModificarUsuario(int.Parse(this.dtUsuario.Rows[0]["Usuario_id"].ToString()), txtUsuario_nombre.Text, txtUsuario_contrasenna.Text,"A");
                }
                CargarGridUsuario();
                dsUsuario = null;
                dtUsuario = null;
                txtUsuario_nombre.Clear(); txtUsuario_contrasenna.Clear();
                MessageBox.Show("Datos de Usuario modificado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Usuario no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnInactivarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                using (GestorUsuario elUsuario = new GestorUsuario())
                {
                    if (int.Parse(this.dtUsuario.Rows[0]["Usuario_id"].ToString()) != 0)
                        elUsuario.InactivarUsuario(int.Parse(this.dtUsuario.Rows[0]["Usuario_id"].ToString()));
                }
                dtUsuario = null;
                dsUsuario = null;
                CargarGridUsuario();
                txtUsuario_contrasenna.Clear(); txtUsuario_nombre.Clear();
                MessageBox.Show("Datos de Usuario Inactivado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Usuario no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numeroFila = dgvUsuario.CurrentCell.RowIndex;
                int Usuario_id = int.Parse(this.dgvUsuario[0, numeroFila].Value.ToString());

                using (GestorUsuario Usuario = new GestorUsuario())
                {
                    this.dsUsuario = Usuario.ConsultarUsuario(Usuario_id);
                    this.dtUsuario = this.dsUsuario.Tables[0];
                }
                CargarDatosUsuario();
            }
            catch (Exception)
            {
                MessageBox.Show("Base de datos vacía", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int Validar()
        {
            epError.Clear();
            if (txtUsuario_nombre.Text.Trim() == "")
            {
                epError.SetError(txtUsuario_nombre, "Insertar Nombre...");
                txtUsuario_nombre.Focus();
                return 1;
            }

            else if (txtUsuario_contrasenna.Text.Trim() == "")
            {
                epError.SetError(txtUsuario_contrasenna, "Insertar contraseña...");
                txtUsuario_contrasenna.Focus();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void CargarGridUsuario()
        {
            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                dgvUsuario.DataSource = elUsuario.ListarUsuario();

                dgvUsuario.Columns["Usuario_id"].Visible = false;
                dgvUsuario.Columns["Usuario_nombre"].HeaderText = "Nombre";
                dgvUsuario.Columns["Usuario_contrasenna"].HeaderText = "Contraseña";
                dgvUsuario.Columns["Usuario_estado"].Visible = false;
            }

        }

        private void CargarDatosUsuario()
        {
            try
            {
                txtUsuario_nombre.Text = this.dtUsuario.Rows[0]["Usuario_nombre"].ToString();
                txtUsuario_contrasenna.Text = this.dtUsuario.Rows[0]["Usuario_contrasenna"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario no encontado en la Base de datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbxBuscarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (iniciandoUsuario) return;

                // Al hacer clic, mostrar el dato
                this.txtFiltar_usuario.Text = this.lbxBuscarUsuario.SelectedItem.ToString();

                // Eliminar las selecciones anteriores
                this.dgvUsuario.ClearSelection();

                // Recorrer las filas para buscar 
                foreach (DataGridViewRow fila in this.dgvUsuario.Rows)
                {

                    if (fila.Cells["Usuario_nombre"].Value == null || fila.Cells == null)
                    {
                        break;
                    }

                    int i = this.txtFiltar_usuario.Text.IndexOf(",");

                    if (i > -1)
                    {

                        string nombre, descripcion;
                        nombre = this.txtFiltar_usuario.Text.Substring(0, i).TrimEnd();
                        descripcion = this.txtFiltar_usuario.Text.Substring(i + 1).TrimStart();

                        if (nombre == fila.Cells["Usuario_nombre"].Value.ToString())
                        {

                            this.dgvUsuario.Rows[fila.Index].Selected = true;

                            this.dgvUsuario.FirstDisplayedScrollingRowIndex = fila.Index;
                            break;
                        }
                    }
                    else
                    {
                        if (this.txtFiltar_usuario.Text == fila.Cells["Usuario_contrasenna_nombre"].Value.ToString())
                        {
                            this.dgvUsuario.Rows[fila.Index].Selected = true;

                            this.dgvUsuario.FirstDisplayedScrollingRowIndex = fila.Index;
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

        private void txtFiltar_usuario_TextChanged(object sender, EventArgs e)
        {
            if (iniciandoUsuario)
                return;

            DataRow[] filas;

            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                dgvUsuario.DataSource = elUsuario.ListarUsuario();
                filas = elUsuario.ListarUsuario().Select("Usuario_nombre LIKE '%" + txtFiltar_usuario.Text + "%'");

                this.lbxBuscarUsuario.Items.Clear();

                if (filas.Length > 0)
                {
                    foreach (DataRow dr in filas)
                    {
                        this.lbxBuscarUsuario.Items.Add(dr["Usuario_nombre"].ToString() + " , " +
                            dr["Usuario_contrasenna"].ToString());
                    }

                }
            }
        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form principal = new frmPrincipal("si");
            principal.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaMatricula.CapaIntegracion;

namespace MatriWeb
{
    public partial class frmEstudiante : System.Web.UI.Page
    {
        DataTable dtEstudiante = new DataTable();
        DataSet dsEstudiante = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridEstudiante();
            cargarComboGrupo();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.InsertarEstudiante(int.Parse(ddlGrupo.SelectedValue.ToString()), txtEstudiante_cedula.Text,
                                                txtEstudiante_nombre.Text, txtEstudiante_primerApellido.Text, txtEstudiante_segundoApellido.Text,
                                                txtEstudiante_telefono.Text, txtEstudiante_correoElectronico.Text, txtEstudiante_direccion.Text, "A");
            }
            Clear();
            cargarGridEstudiante();
            lblSuccessMessage.Text = "Agregado Exitosamente";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                    elEstudiante.InactivarEstudiante(Convert.ToInt32(lblSuccessMessage.Text));
            }
            Clear();
            cargarGridEstudiante();
            lblSuccessMessage.Text = "Eliminado Exitosamente";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorEstudiante elEstudiante = new GestorEstudiante())
            {
                elEstudiante.ModificarEstudiante(Convert.ToInt32(lblSuccessMessage.Text), int.Parse(ddlGrupo.SelectedValue.ToString()), txtEstudiante_cedula.Text,
                                                txtEstudiante_nombre.Text, txtEstudiante_primerApellido.Text, txtEstudiante_segundoApellido.Text,
                                                txtEstudiante_telefono.Text, txtEstudiante_correoElectronico.Text, txtEstudiante_direccion.Text, "A");
            }
            Clear();
            cargarGridEstudiante();
            lblSuccessMessage.Text = "Modificado Exitosamente";
        }

        //---------------------------------------------- Metodos----------------------------------------------------------------------------
        public void Clear()
        {
            txtEstudiante_cedula.Text = txtEstudiante_nombre.Text = txtEstudiante_primerApellido.Text = 
                txtEstudiante_segundoApellido.Text = txtEstudiante_telefono.Text = txtEstudiante_correoElectronico.Text =
                txtEstudiante_direccion.Text = "";
            lblSuccessMessage.Text = "";
            
        }

        public void cargarGridEstudiante()
        {
            using (GestorEstudiante estudiante = new GestorEstudiante())
            {
                dgvEstudiante.DataSource = estudiante.ListarEstudiante();
                dgvEstudiante.DataBind();
            }
        }

        public void cargarComboGrupo()
        {
            try
            {
                using (GestorGrupo grupo = new GestorGrupo())
                {
                    if (!IsPostBack)
                    {
                        ddlGrupo.DataSource = grupo.ListarGrupo();
                        ddlGrupo.DataValueField = "Grupo_id";
                        ddlGrupo.DataTextField = "Grupo_descripcion";
                        ddlGrupo.DataBind();
                        ddlGrupo.SelectedIndex = 0;
                    }
                }
            }
            catch
            {

            }
        }

        private void CargarDatosEstudiante()
        {
            ddlGrupo.SelectedValue = this.dtEstudiante.Rows[0]["Grupo_id"].ToString();
            txtEstudiante_cedula.Text = this.dtEstudiante.Rows[0]["Estudiante_cedula"].ToString();
            txtEstudiante_nombre.Text = this.dtEstudiante.Rows[0]["Estudiante_nombre"].ToString();
            txtEstudiante_primerApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_primerApellido"].ToString();
            txtEstudiante_segundoApellido.Text = this.dtEstudiante.Rows[0]["Estudiante_segundoApellido"].ToString();
            txtEstudiante_telefono.Text = this.dtEstudiante.Rows[0]["Estudiante_telefono"].ToString();
            txtEstudiante_correoElectronico.Text = this.dtEstudiante.Rows[0]["Estudiante_correoElectronico"].ToString();
            txtEstudiante_direccion.Text = this.dtEstudiante.Rows[0]["Estudiante_direccion"].ToString();
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            lblSuccessMessage.Text = Convert.ToString(contactID);
            using (GestorEstudiante Estudiante = new GestorEstudiante())
            {
                this.dsEstudiante = Estudiante.ConsultarEstudiante(contactID);
                this.dtEstudiante = this.dsEstudiante.Tables[0];
            }
            CargarDatosEstudiante();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        protected void dgvEstudiante_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Seleccionar";
                e.Row.Cells[1].Text = "ID";
                e.Row.Cells[2].Text = "Grupo";
                e.Row.Cells[3].Text = "Cedula";
                e.Row.Cells[4].Text = "Nombre";
                e.Row.Cells[5].Text = "Primer apellido";
                e.Row.Cells[6].Text = "Segundo apellido";
                e.Row.Cells[7].Text = "Telefono";
                e.Row.Cells[8].Text = "Correo electronico";
                e.Row.Cells[9].Text = "Direccion";
            }
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[10].Visible = false;
        }

    }
}
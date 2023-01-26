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
    public partial class frmProfesor : System.Web.UI.Page
    {
        DataTable dtProfesor = new DataTable();
        DataSet dsProfesor = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridProfesor();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.InsertarProfesor(txtProfesor_cedula.Text, txtProfesor_nombre.Text, txtProfesor_primerApellido.Text,
                                            txtProfesor_segundoApellido.Text, txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text,
                                            txtProfesor_direccion.Text, "A");
            }
            Clear();
            cargarGridProfesor();
            lblSuccessMessage.Text = "Agregado Exitosamente";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                    elProfesor.InactivarProfesor(Convert.ToInt32(lblSuccessMessage.Text));
            }           
            Clear();
            cargarGridProfesor();
            lblSuccessMessage.Text = "Eliminado Exitosamente";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorProfesor elProfesor = new GestorProfesor())
            {
                elProfesor.ModificarProfesor(Convert.ToInt32(lblSuccessMessage.Text), txtProfesor_cedula.Text, txtProfesor_nombre.Text,
                                            txtProfesor_primerApellido.Text, txtProfesor_segundoApellido.Text, txtProfesor_telefono.Text, txtProfesor_correoElectronico.Text,
                                            txtProfesor_direccion.Text, "A");
            }
            Clear();
            cargarGridProfesor();
            lblSuccessMessage.Text = "Modificado Exitosamente";
        }

        //-----------------------------------Metodos------------------------------------------------------------------------

        public void cargarGridProfesor()
        {
            using (GestorProfesor profesor = new GestorProfesor())
            {
                dgvProfesor.DataSource = profesor.ListarProfesor();
                dgvProfesor.DataBind();
            }
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            lblSuccessMessage.Text = Convert.ToString(contactID);
            using (GestorProfesor Profesor = new GestorProfesor())
            {
                this.dsProfesor = Profesor.ConsultarProfesor(contactID);
                this.dtProfesor = this.dsProfesor.Tables[0];
            }
            CargarDatosProfesor();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void CargarDatosProfesor()
        {
            txtProfesor_cedula.Text = this.dtProfesor.Rows[0]["Profesor_cedula"].ToString();
            txtProfesor_nombre.Text = this.dtProfesor.Rows[0]["Profesor_nombre"].ToString();
            txtProfesor_primerApellido.Text = this.dtProfesor.Rows[0]["Profesor_primerApellido"].ToString();
            txtProfesor_segundoApellido.Text = this.dtProfesor.Rows[0]["Profesor_segundoApellido"].ToString();
            txtProfesor_telefono.Text = this.dtProfesor.Rows[0]["Profesor_telefono"].ToString();
            txtProfesor_correoElectronico.Text = this.dtProfesor.Rows[0]["Profesor_correoElectronico"].ToString();
            txtProfesor_direccion.Text = this.dtProfesor.Rows[0]["Profesor_direccion"].ToString();
        }

        protected void dgvProfesor_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Seleccionar";
                e.Row.Cells[1].Text = "ID";
                e.Row.Cells[2].Text = "Cedula";
                e.Row.Cells[3].Text = "Nombre";
                e.Row.Cells[4].Text = "Primer apellido";
                e.Row.Cells[5].Text = "Segundo apellido";
                e.Row.Cells[6].Text = "Telefono";
                e.Row.Cells[7].Text = "Correo electronico";
                e.Row.Cells[8].Text = "Direccion";
            }
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[9].Visible = false;
        }

        public void Clear()
        {
            txtProfesor_cedula.Text = txtProfesor_nombre.Text = txtProfesor_primerApellido.Text =
                txtProfesor_segundoApellido.Text = txtProfesor_telefono.Text = txtProfesor_correoElectronico.Text =
                txtProfesor_direccion.Text = "";
            lblSuccessMessage.Text = "";

        }
    }
}
using SistemaMatricula.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MatriWeb
{
    public partial class frmCurso : System.Web.UI.Page
    {
        DataTable dtCurso = new DataTable();
        DataSet dsCurso = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridCurso();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.InsertarCurso(txtCurso_nombre.Text, txtCurso_creditos.Text, txtCurso_cupo.Text, "A");
            }
            Clear();
            cargarGridCurso();
            lblSuccessMessage.Text = "Agregado Exitosamente";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                    elCurso.InactivarCurso(Convert.ToInt32(lblSuccessMessage.Text));
            }
            Clear();
            cargarGridCurso();
            lblSuccessMessage.Text = "Eliminado Exitosamente";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorCurso elCurso = new GestorCurso())
            {
                elCurso.ModificarCurso(Convert.ToInt32(lblSuccessMessage.Text),
                                       txtCurso_nombre.Text, txtCurso_creditos.Text, txtCurso_cupo.Text, "A");
            }
            Clear();
            cargarGridCurso();
            lblSuccessMessage.Text = "Modificado Exitosamente";
        }

        //---------------------------------------------- Metodos----------------------------------------------------------------------------

        public void Clear()
        {
            txtCurso_nombre.Text = txtCurso_cupo.Text = txtCurso_creditos.Text =  "";
            lblSuccessMessage.Text = "";

        }

        public void cargarGridCurso()
        {
            using (GestorCurso curso = new GestorCurso())
            {
                dgvCurso.DataSource = curso.ListarCurso();
                dgvCurso.DataBind();
            }
        }

        private void CargarDatosCurso()
        {
            txtCurso_nombre.Text = this.dtCurso.Rows[0]["Curso_nombre"].ToString();
            txtCurso_creditos.Text = this.dtCurso.Rows[0]["Curso_creditos"].ToString();
            txtCurso_cupo.Text = this.dtCurso.Rows[0]["Curso_cupo"].ToString();           
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            lblSuccessMessage.Text = Convert.ToString(contactID);
            using (GestorCurso Curso = new GestorCurso())
            {
                this.dsCurso = Curso.ConsultarCurso(contactID);
                this.dtCurso = this.dsCurso.Tables[0];
            }
            CargarDatosCurso();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        protected void dgvCurso_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Seleccionar";
                e.Row.Cells[1].Text = "ID";
                e.Row.Cells[2].Text = "Nombre";
                e.Row.Cells[3].Text = "Creditos";
                e.Row.Cells[4].Text = "Cupo";
            }
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[5].Visible = false;
        }
    }
}
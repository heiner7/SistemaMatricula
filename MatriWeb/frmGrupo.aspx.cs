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
    public partial class frmGrupo : System.Web.UI.Page
    {
        DataTable dtGrupo = new DataTable();
        DataSet dsGrupo = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridGrupo();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.InsertarGrupo(txtGrupo_descripcion.Text, "A");
            }
            Clear();
            cargarGridGrupo();
            lblSuccessMessage.Text = "Agregado Exitosamente";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                    elGrupo.InactivarGrupo(Convert.ToInt32(lblSuccessMessage.Text));
            }
            Clear();
            cargarGridGrupo();
            lblSuccessMessage.Text = "Eliminado Exitosamente";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorGrupo elGrupo = new GestorGrupo())
            {
                elGrupo.ModificarGrupo(Convert.ToInt32(lblSuccessMessage.Text), txtGrupo_descripcion.Text, "A");
            }
            Clear();
            cargarGridGrupo();
            lblSuccessMessage.Text = "Modificado Exitosamente";
        }

        //---------------------------------------------- Metodos----------------------------------------------------------------------------
        public void Clear()
        {
            txtGrupo_descripcion.Text = "";
            lblSuccessMessage.Text = "";

        }

        public void cargarGridGrupo()
        {
            using (GestorGrupo grupo = new GestorGrupo())
            {
                dgvGrupo.DataSource = grupo.ListarGrupo();
                dgvGrupo.DataBind();
            }
        }

        private void CargarDatosGrupo()
        {
            txtGrupo_descripcion.Text = this.dtGrupo.Rows[0]["Grupo_descripcion"].ToString();
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            lblSuccessMessage.Text = Convert.ToString(contactID);
            using (GestorGrupo Grupo = new GestorGrupo())
            {
                this.dsGrupo = Grupo.ConsultarGrupo(contactID);
                this.dtGrupo = this.dsGrupo.Tables[0];
            }
            CargarDatosGrupo();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        protected void dgvGrupo_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Seleccionar";
                e.Row.Cells[1].Text = "ID";
                e.Row.Cells[2].Text = "Descripción";
            }
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[3].Visible = false;
        }
    }
}
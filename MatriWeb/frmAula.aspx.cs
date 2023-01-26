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
    public partial class frmAulaGrupo : System.Web.UI.Page
    {
        DataTable dtTabla = new DataTable();
        DataSet dsTabla = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
           cargarGridAula();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.InsertarAula(txtAula_descripcion.Text, "A");
            }
            Clear();
            cargarGridAula();
            lblSuccessMessage.Text = "Agregado Exitosamente";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                    elAula.InactivarAula(Convert.ToInt32(lblSuccessMessage.Text));
            }
            Clear();
            cargarGridAula();
            lblSuccessMessage.Text = "Eliminado Exitosamente";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorAula elAula = new GestorAula())
            {
                elAula.ModificarAula(Convert.ToInt32(lblSuccessMessage.Text), txtAula_descripcion.Text, "A");
            }
            Clear();
            cargarGridAula();
            lblSuccessMessage.Text = "Modificado Exitosamente";
        }

        //---------------------------------------------- Metodos----------------------------------------------------------------------------
        public void Clear()
        {
            txtAula_descripcion.Text = "";
            lblSuccessMessage.Text = "";

        }

        public void cargarGridAula()
        {
            using (GestorAula aula = new GestorAula())
            {
                dgvAula.DataSource = aula.ListarAula();
                dgvAula.DataBind();
            }
        }        

        private void CargarDatosAula()
        {
            txtAula_descripcion.Text = this.dtTabla.Rows[0]["Aula_descripcion"].ToString();
        }
        

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            lblSuccessMessage.Text = Convert.ToString(contactID);
            using (GestorAula Aula = new GestorAula())
            {
                this.dsTabla = Aula.ConsultarAula(contactID);
                this.dtTabla = this.dsTabla.Tables[0];
            }
            CargarDatosAula();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        protected void dgvAula_RowDataBound(object sender, GridViewRowEventArgs e)
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
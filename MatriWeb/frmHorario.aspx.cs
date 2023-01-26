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
    public partial class frmHorario : System.Web.UI.Page
    {
        DataTable dtHorario = new DataTable();
        DataSet dsHorario = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridHorario();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                elHorario.InsertarHorario(txtHorario_descripcion.Text, txtHorario_dia.Text,
                                          txtHorario_horaInicio.Text, txtHorario_horaFinal.Text, "A");
            }
            Clear();
            cargarGridHorario();
            lblSuccessMessage.Text = "Agregado Exitosamente";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                    elHorario.InactivarHorario(Convert.ToInt32(lblSuccessMessage.Text));
            }
            Clear();
            cargarGridHorario();
            lblSuccessMessage.Text = "Eliminado Exitosamente";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorHorario elHorario = new GestorHorario())
            {
                elHorario.ModificarHorario(Convert.ToInt32(lblSuccessMessage.Text), txtHorario_descripcion.Text, txtHorario_dia.Text,
                                        txtHorario_horaInicio.Text, txtHorario_horaFinal.Text, "A");
            }
            Clear();
            cargarGridHorario();
            lblSuccessMessage.Text = "Modificado Exitosamente";
        }

        //----------------------------------------------------Metodos-------------------------------------------------------------------

        public void Clear()
        {
            txtHorario_descripcion.Text = txtHorario_dia.Text = txtHorario_horaFinal.Text =
                txtHorario_horaInicio.Text =  "";
            lblSuccessMessage.Text = "";

        }

        public void cargarGridHorario()
        {
            using (GestorHorario horario = new GestorHorario())
            {
                dgvHorario.DataSource = horario.ListarHorario();
                dgvHorario.DataBind();
            }
        }

        private void CargarDatosHorario()
        {
            txtHorario_descripcion.Text = this.dtHorario.Rows[0]["Horario_descripcion"].ToString();
            txtHorario_dia.Text = this.dtHorario.Rows[0]["Horario_dia"].ToString();
            txtHorario_horaInicio.Text = this.dtHorario.Rows[0]["Horario_horaInicio"].ToString();
            txtHorario_horaFinal.Text = this.dtHorario.Rows[0]["Horario_horaFinal"].ToString();
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            lblSuccessMessage.Text = Convert.ToString(contactID);
            using (GestorHorario Horario = new GestorHorario())
            {
                this.dsHorario = Horario.ConsultarHorario(contactID);
                this.dtHorario = this.dsHorario.Tables[0];
            }
            CargarDatosHorario();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        protected void dgvHorario_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Seleccionar";
                e.Row.Cells[1].Text = "ID";
                e.Row.Cells[2].Text = "Descripción";
                e.Row.Cells[3].Text = "Día";
                e.Row.Cells[4].Text = "Hora Inicial";
                e.Row.Cells[5].Text = "Hora Final";
            }
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[6].Visible = false;
        }
    }
}
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

    public partial class frmMatricula : System.Web.UI.Page
    {
        DataTable dtMatricula = new DataTable();
        DataSet dsMatricula = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGridMatricula();
            cargarComboEstudiante();
            cargarComboGrupo();
            cargarComboCurso();
            cargarComboProfesor();
            cargarComboHorario();
            cargarComboAula();
            cargarComboHorario();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                laMatricula.InsertarMatricula(int.Parse(ddlEstudiante.SelectedValue.ToString()), int.Parse(ddlGrupo.SelectedValue.ToString()), int.Parse(ddlCurso.SelectedValue.ToString()),
                                              int.Parse(ddlProfesor.SelectedValue.ToString()), int.Parse(ddlHorario.SelectedValue.ToString()), int.Parse(ddlAula.SelectedValue.ToString()), txtMatricula_comprobante.Text, "A");
            }
            Clear();
            cargarGridMatricula();
            lblSuccessMessage.Text = "Agregado Exitosamente";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula laMatricula = new GestorMatricula())
            {
                    laMatricula.InactivarMatricula(Convert.ToInt32(lblSuccessMessage.Text));
            }
            Clear();
            cargarGridMatricula();
            lblSuccessMessage.Text = "Eliminado Exitosamente";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            using (GestorMatricula elMatricula = new GestorMatricula())
            {
                elMatricula.ModificarMatricula(Convert.ToInt32(lblSuccessMessage.Text), int.Parse(ddlEstudiante.SelectedValue.ToString()), int.Parse(ddlGrupo.SelectedValue.ToString()), int.Parse(ddlCurso.SelectedValue.ToString()),
                                               int.Parse(ddlProfesor.SelectedValue.ToString()), int.Parse(ddlHorario.SelectedValue.ToString()), int.Parse(ddlAula.SelectedValue.ToString()), txtMatricula_comprobante.Text, "A");
            }
            Clear();
            cargarGridMatricula();
            lblSuccessMessage.Text = "Modificado Exitosamente";
        }


        //-----------------------------------Metodos-------------------------------------------------------------

        public void Clear()
        {
            txtMatricula_comprobante.Text = "";
            lblSuccessMessage.Text = "";

        }

        public void cargarGridMatricula()
        {
            using (GestorMatricula matricula = new GestorMatricula())
            {
                dgvMatricula.DataSource = matricula.ListarMatricula();
                dgvMatricula.DataBind();
            }
        }

        public void cargarComboEstudiante()
        {
            try
            {
                using (GestorEstudiante estudiante = new GestorEstudiante())
                {
                    if (!IsPostBack)
                    {
                        ddlEstudiante.DataSource = estudiante.ListarEstudiante();
                        ddlEstudiante.DataValueField = "Estudiante_id";
                        ddlEstudiante.DataTextField = "Estudiante_nombre";
                        ddlEstudiante.DataBind();
                        ddlEstudiante.SelectedIndex = 0;
                    }
                }
            }
            catch
            {

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

        public void cargarComboCurso()
        {
            try
            {
                using (GestorCurso curso = new GestorCurso())
                {
                    if (!IsPostBack)
                    {
                        ddlCurso.DataSource = curso.ListarCurso();
                        ddlCurso.DataValueField = "Curso_id";
                        ddlCurso.DataTextField = "Curso_nombre";
                        ddlCurso.DataBind();
                        ddlCurso.SelectedIndex = 0;
                    }
                }
            }
            catch
            {

            }
        }

        public void cargarComboProfesor()
        {
            try
            {
                using (GestorProfesor profesor = new GestorProfesor())
                {
                    if (!IsPostBack)
                    {
                        ddlProfesor.DataSource = profesor.ListarProfesor();
                        ddlProfesor.DataValueField = "Profesor_id";
                        ddlProfesor.DataTextField = "Profesor_nombre";
                        ddlProfesor.DataBind();
                        ddlProfesor.SelectedIndex = 0;
                    }
                }
            }
            catch
            {

            }
        }

        public void cargarComboHorario()
        {
            try
            {
                using (GestorHorario horario = new GestorHorario())
                {
                    if (!IsPostBack)
                    {
                        ddlHorario.DataSource = horario.ListarHorario();
                        ddlHorario.DataValueField = "Horario_id";
                        ddlHorario.DataTextField = "Horario_descripcion";
                        ddlHorario.DataBind();
                        ddlHorario.SelectedIndex = 0;
                    }
                }
            }
            catch
            {

            }
        }

        public void cargarComboAula()
        {
            try
            {
                using (GestorAula aula = new GestorAula())
                {
                    if (!IsPostBack)
                    {
                        ddlAula.DataSource = aula.ListarAula();
                        ddlAula.DataValueField = "Aula_id";
                        ddlAula.DataTextField = "Aula_descripcion";
                        ddlAula.DataBind();
                        ddlAula.SelectedIndex = 0;
                    }
                }
            }
            catch
            {

            }
        }

        protected void lnk_OnClick(object sender, EventArgs e)
        {
            int contactID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            lblSuccessMessage.Text = Convert.ToString(contactID);
            using (GestorMatricula Matricula = new GestorMatricula())
            {
                this.dsMatricula = Matricula.ConsultarMatricula(contactID);
                this.dtMatricula = this.dsMatricula.Tables[0];
            }
            CargarDatosMatricula();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void CargarDatosMatricula()
        {
            ddlEstudiante.SelectedValue = this.dtMatricula.Rows[0]["Estudiante_id"].ToString();
            ddlGrupo.SelectedValue = this.dtMatricula.Rows[0]["Grupo_id"].ToString();
            ddlCurso.SelectedValue = this.dtMatricula.Rows[0]["Curso_id"].ToString();
            ddlProfesor.SelectedValue = this.dtMatricula.Rows[0]["Profesor_id"].ToString();
            ddlHorario.SelectedValue = this.dtMatricula.Rows[0]["Horario_id"].ToString();
            ddlAula.SelectedValue = this.dtMatricula.Rows[0]["Aula_id"].ToString();
            txtMatricula_comprobante.Text = this.dtMatricula.Rows[0]["Matricula_comprobante"].ToString();
        }

        protected void dgvMatricula_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Seleccionar";
                e.Row.Cells[1].Text = "ID";
                e.Row.Cells[2].Text = "Estudiante";
                e.Row.Cells[3].Text = "Grupo";
                e.Row.Cells[4].Text = "Curso";
                e.Row.Cells[5].Text = "Profesor";
                e.Row.Cells[6].Text = "Horario";
                e.Row.Cells[7].Text = "Aula";
                e.Row.Cells[8].Text = "Comprobante";
            }
            e.Row.Cells[1].Visible = false;
            e.Row.Cells[9].Visible = false;
        }
    }
}
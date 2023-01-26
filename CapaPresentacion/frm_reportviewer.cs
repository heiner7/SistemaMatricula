using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frm_reportviewer : Form
    {
        string identificador;
        public frm_reportviewer(int id, string identi)
        {
            ID =  id;
            identificador = identi;
            InitializeComponent();
        }

        public int ID { get; private set; }

        private void frm_reportviewer_Load(object sender, EventArgs e)
        {
            ReportDocument myreport = new ReportDocument();

            switch (this.Tag.ToString())
            {
                case "0":
                    if (identificador == "Estudiante")
                    {
                        myreport.Load(@"..\..\reports\ReportEstudiante.rpt");
                        myreport.SetParameterValue("prm_dato", "Reporte de listar Estudiante");
                        crystalReportViewer1.ReportSource = myreport;
                    }else if(identificador == "Profesor"){
                        myreport.Load(@"..\..\reports\ReportProfesor.rpt");
                        myreport.SetParameterValue("prm_dato", "Reporte de listar Profesor");
                        crystalReportViewer1.ReportSource = myreport;
                    }
                    break;

                case "1":
                    if (identificador == "Estudiante")
                    {
                        myreport.Load(@"..\..\reports\ReportEstudianteConsu.rpt");
                        myreport.SetParameterValue("prm_dato", "Reporte de Consulta Estudiante");
                        myreport.SetParameterValue("@Estudiante_id", ID);
                        crystalReportViewer1.ReportSource = myreport;
                    }
                    else if(identificador == "Profesor"){
                        myreport.Load(@"..\..\reports\ReportProfesorConsu.rpt");
                        myreport.SetParameterValue("prm_dato", "Reporte de Consulta Profesor");
                        myreport.SetParameterValue("@Profesor_id", ID);
                        crystalReportViewer1.ReportSource = myreport;
                    }
                    break;
            }
        }

        
    }
}

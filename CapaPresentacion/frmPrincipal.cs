using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        private string activar;

        public frmPrincipal(string acti)
        {
            InitializeComponent();
            activar = acti;

        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            Form form = new frmEstudiante(activar);
            form.Show();
            this.Dispose();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            Form form = new frmProfesor(activar);
            form.Show();
            this.Dispose();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            Form form = new frmGrupo();
            form.Show();
            this.Dispose();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            Form form = new frmCurso();
            form.Show();
            this.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form form = new frmEliminar();
            form.Show();
            this.Dispose();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            Form form = new frmMatricula();
            form.Show();
            this.Dispose();
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            Form form = new frmHorario();
            form.Show();
            this.Dispose();
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            Form form = new frmAula();
            form.Show();
            this.Dispose();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Form form = new frmUsuario();
            form.Show();
            this.Dispose();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();     
        }
    }
}

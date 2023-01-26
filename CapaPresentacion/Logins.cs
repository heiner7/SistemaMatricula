using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatricula.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class Logins : Form
    {
        

        public Logins()
        {
            InitializeComponent();
        }

        public void login(string usuario, string contra)
        {
            if (txtUsuario.Text.Trim() != "")
            {
                
                if (txtContra.Text.Trim() != "")
                {
                    try
                    {    
                        GestorEstudiante activar = new GestorEstudiante(usuario, contra);
                        txtUsuario.Text = txtContra.Text = "";
                        Form principal = new frmPrincipal("si");
                        principal.Show();
                    }catch(Exception)
                    {
                        txtUsuario.Text = txtContra.Text = "";
                        MessageBox.Show("Datos de Usuario o Contraseña son incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

            }
                                     
            /* try
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("SELECT Usuario_nombre, Usuario_contrasenna FROM TUsuario WHERE Usuario_nombre = @usuario AND Usuario_contrasenna = @contra", con);
                 cmd.Parameters.AddWithValue("usuario", usuario);
                 cmd.Parameters.AddWithValue("contra", contra);
                 SqlDataAdapter sda = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 sda.Fill(dt);

                 if (dt.Rows.Count == 1)
                 {
                     this.Hide();
                     if (dt.Rows[0][0].ToString() == "Admin")
                     {

                         Form principal = new frmPrincipal("si");
                         principal.Show();

                     }
                     else if (dt.Rows[0][0].ToString() == "Usuario")
                     {
                         Form principal = new frmPrincipal("no");
                         principal.Show();
                     }
                 }
                 else
                 {
                     MessageBox.Show("Usuario o Contraseña Incorrecta");
                 }
             }
             catch (Exception e)
             {
                 MessageBox.Show(e.Message);
             }
             finally
             {
                 con.Close();
             }*/

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            login(txtUsuario.Text, txtContra.Text);
        }

        private void Logins_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}

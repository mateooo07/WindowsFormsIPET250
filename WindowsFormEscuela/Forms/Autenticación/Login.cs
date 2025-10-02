using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormEscuela.Conexiones;

namespace WindowsFormEscuela
{
    public partial class Login : Form
    {
        UsuarioConexion usuarioConexion = new UsuarioConexion();
        public Login()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            errorLabel.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = usuarioTxt.Text;
                string contraseña = contraseñaTxt.Text;

                bool loginValido = usuarioConexion.VerificarCredenciales(usuario, contraseña);

                if (!loginValido)
                {
                    errorLabel.Show();
                    usuarioTxt.Text = null;
                    contraseñaTxt.Text = null;
                    return;
                }

                Principal formPrincipal = new Principal();
                formPrincipal.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al iniciar sesión: " + ex.Message);
            }
        }


    }
}

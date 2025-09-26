using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEscuela
{
    public partial class Login : Form
    {
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
            string usuario = usuarioTxt.Text;
            string contraseña = contraseñaTxt.Text;

            if (usuario != "mateooo07" || contraseña != "talleres2025")
            {
                errorLabel.Show();
                return;
            }

            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            this.Hide();

        }

    }
}

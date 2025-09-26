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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void estudianteBtn_Click(object sender, EventArgs e)
        {
            EstudianteForm estudianteForm = new EstudianteForm();
            estudianteForm.Show();
            this.Close();
        }

        private void exAlumnoBtn_Click(object sender, EventArgs e)
        {
            ExAlumnoForm exAlumnoForm = new ExAlumnoForm();
            exAlumnoForm.Show();
            this.Close();
        }

        private void docenteBtn_Click(object sender, EventArgs e)
        {
            DocenteForm docenteForm = new DocenteForm();
            docenteForm.Show();
            this.Close();
        }

        private void noDocenteBtn_Click(object sender, EventArgs e)
        {
            NoDocenteForm noDocenteForm = new NoDocenteForm();
            noDocenteForm.Show();
            this.Close();
        }
    }
}

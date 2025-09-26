using Ejercicio5_objetos;
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
    public partial class DocenteForm : Form
    {
        DocenteConexion conexion = new DocenteConexion();
        List<Docente> docentes = new List<Docente>();
        private bool esEdicion = false;
        private int idSeleccionado = -1;

        public DocenteForm()
        {
            InitializeComponent();
            docentes = conexion.LeerDocentes();
            docenteDGV.DataSource = docentes;
        }

        private void añadirBtn_Click(object sender, EventArgs e)
        {
            esEdicion = false;
            activarTxts();
            limpiarTxts();
            errorLabel.Text = "";
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtPuesto.Text) ||
                string.IsNullOrWhiteSpace(txtAntiguedad.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                errorLabel.Text = "No pueden haber campos vacíos";
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad) ||
                !int.TryParse(txtAntiguedad.Text, out int antiguedad) ||
                !int.TryParse(txtSalario.Text, out int salario))
            {
                errorLabel.Text = "Edad, Antiguedad y Salario deben ser números válidos";
                return;
            }

            Docente d = new Docente(txtNombre.Text, edad, txtPuesto.Text, antiguedad, salario);

            if (esEdicion)
            {
                d.Id = idSeleccionado;
                conexion.EditarDocente(d);
            }
            else
            {
                conexion.AgregarDocente(d);
            }

            docentes = conexion.LeerDocentes();
            docenteDGV.DataSource = docentes;

            desactivarTxts();
            limpiarTxts();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (docenteDGV.SelectedRows.Count == 0)
            {
                errorLabel.Text = "Seleccione un docente para editar";
                return;
            }

            esEdicion = true;
            idSeleccionado = Convert.ToInt32(docenteDGV.CurrentRow.Cells["Id"].Value);
            activarTxts();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (docenteDGV.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(docenteDGV.SelectedRows[0].Cells["Id"].Value);
                bool eliminado = conexion.EliminarDocente(id);

                if (eliminado)
                {
                    MessageBox.Show("Docente eliminado correctamente.");
                    docentes = conexion.LeerDocentes();
                    docenteDGV.DataSource = docentes;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el docente.");
                }
            }
        }

        private void docenteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombre.Text = docenteDGV.CurrentRow.Cells["Nombre"].Value.ToString();
                txtEdad.Text = docenteDGV.CurrentRow.Cells["Edad"].Value.ToString();
                txtPuesto.Text = docenteDGV.CurrentRow.Cells["Puesto"].Value.ToString();
                txtAntiguedad.Text = docenteDGV.CurrentRow.Cells["Antiguedad"].Value.ToString();
                txtSalario.Text = docenteDGV.CurrentRow.Cells["Salario"].Value.ToString();
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreBuscar.Text.Trim();
            string puesto = txtPuestoBuscar.Text.Trim();
            string edad = txtEdadBuscar.Text.Trim();
            string salario = txtSalarioBuscar.Text.Trim();

            docentes = conexion.BuscarDocentes(nombre, puesto, edad, salario);
            docenteDGV.DataSource = docentes;
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            limpiarTxts();
            desactivarTxts();
        }

        private void activarTxts()
        {
            txtNombre.Enabled = true;
            txtEdad.Enabled = true;
            txtPuesto.Enabled = true;
            txtAntiguedad.Enabled = true;
            txtSalario.Enabled = true;
        }

        private void desactivarTxts()
        {
            txtNombre.Enabled = false;
            txtEdad.Enabled = false;
            txtPuesto.Enabled = false;
            txtAntiguedad.Enabled = false;
            txtSalario.Enabled = false;
        }

        private void limpiarTxts()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtPuesto.Text = "";
            txtAntiguedad.Text = "";
            txtSalario.Text = "";
        }

        private void retrocederBtn_Click(object sender, EventArgs e)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            this.Close();
        }

        private void habilitarButton_Click(object sender, EventArgs e)
        {
            activarBuscar();
        }

        private void desactivarBuscar()
        {
            txtNombreBuscar.Enabled = false;
            txtEdadBuscar.Enabled = false;
            txtPuestoBuscar.Enabled = false;
            txtSalarioBuscar.Enabled = false;
            txtAntiguedadBuscar.Enabled = false;
            buscarBtn.Enabled = false;
        }

        private void activarBuscar()
        {
            txtNombreBuscar.Enabled = true;
            txtEdadBuscar.Enabled = true;
            txtPuestoBuscar.Enabled = true;
            txtSalarioBuscar.Enabled = true;
            txtAntiguedadBuscar.Enabled = true;
            buscarBtn.Enabled = true;
        }

        private void DocenteForm_Load(object sender, EventArgs e)
        {
            docenteDGV.DataSource = docentes;
            desactivarTxts();
            desactivarBuscar();
        }
    }

}

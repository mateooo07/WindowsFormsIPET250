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
    public partial class AlumnoForm : Form
    {
        AlumnoConexion conexion = new AlumnoConexion();
        List<Cursando> alumnos = new List<Cursando>();
        private bool esEdicion = false;
        private int idSeleccionado = -1;

        public AlumnoForm()
        {
            InitializeComponent();
            alumnos = conexion.LeerAlumnos();
        }
        private void añadirBtn_Click(object sender, EventArgs e)
        {
            esEdicion = false;
            activarTxts();
            limpiarTxts();
            errorLabel.Text = "";
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (alumnoDGV.SelectedRows.Count == 0)
            {
                errorLabel.Text = "Seleccione un alumno para editar";
                return;
            }

            esEdicion = true;
            idSeleccionado = Convert.ToInt32(alumnoDGV.CurrentRow.Cells["Id"].Value);
            activarTxts();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            if (string.IsNullOrWhiteSpace(txtCarrera.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtMateria.Text)|| 
                string.IsNullOrWhiteSpace(txtAño.Text) ||
                string.IsNullOrWhiteSpace(txtNota.Text))
            {
                errorLabel.Text = "No pueden haber campos vacíos";
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                errorLabel.Text = "Edad debe ser un número entero";
                return;
            }

            if (!int.TryParse(txtNota.Text, out int nota))
            {
                errorLabel.Text = "Nota debe ser un número válido";
                return;
            }

            if (edad < 18 || nota < 0 || nota > 10)
            {
                errorLabel.Text = "Edad debe ser >= 18 y nota entre 0 y 10";
                return;
            }

            Cursando crs = new Cursando(txtNombre.Text, edad, txtCarrera.Text, chkCursando.Checked, txtAño.Text, txtMateria.Text, nota);

            if (esEdicion)
            {
                crs.Id = idSeleccionado;
                conexion.EditarAlumno(crs);
            }
            else
            {
                conexion.AgregarAlumno(crs);
            }

            alumnos = conexion.LeerAlumnos();
            alumnoDGV.DataSource = alumnos;

            desactivarTxts();
            limpiarTxts();
        }


        private void retrocederBtn_Click(object sender, EventArgs e)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            this.Close();
        }

        private void alumnoForm_Load(object sender, EventArgs e)
        {
            alumnoDGV.DataSource = alumnos;
            desactivarTxts();
            desactivarBuscar();
        }

        private void alumnoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombre.Text = alumnoDGV.CurrentRow.Cells["Nombre"].Value.ToString();
                txtCarrera.Text = alumnoDGV.CurrentRow.Cells["Carrera"].Value.ToString();
                txtEdad.Text = alumnoDGV.CurrentRow.Cells["Edad"].Value.ToString();
                txtAño.Text = alumnoDGV.CurrentRow.Cells["Año"].Value.ToString();
                txtMateria.Text = alumnoDGV.CurrentRow.Cells["Materia"].Value.ToString();
                txtNota.Text = alumnoDGV.CurrentRow.Cells["Nota"].Value.ToString();
                chkCursando.Checked = Convert.ToBoolean(alumnoDGV.CurrentRow.Cells["Estado"].Value);
            }
        }
        private void buscarBtn_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreBuscar.Text.Trim();
            string carrera = txtCarreraBuscar.Text.Trim();
            string edad = txtEdadBuscar.Text.Trim();
            string anio = txtAñoBuscar.Text.Trim();
            string materia = txtMateriaBuscar.Text.Trim();
            string nota = txtNotaBuscar.Text.Trim();
            bool cursando = chkCursandoBuscar.Checked ? true : false;

            alumnos = conexion.BuscarAlumnos(nombre, carrera, edad, cursando, anio, materia, nota);
            alumnoDGV.DataSource = alumnos;
        }


        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            limpiarTxts();
            desactivarTxts();
        }
        private void desactivarTxts()
        {
            txtCarrera.Enabled = false;
            txtEdad.Enabled = false;
            txtNombre.Enabled = false;
            txtAño.Enabled = false;
            txtMateria.Enabled = false;
            txtNota.Enabled = false;
            chkCursando.Enabled = false;
        }

        private void activarTxts()
        {
            txtCarrera.Enabled = true;
            txtEdad.Enabled = true;
            txtNombre.Enabled = true;
            txtAño.Enabled = true;
            txtMateria.Enabled = true;
            txtNota.Enabled = true;
            chkCursando.Enabled = true;
        }

        private void desactivarBuscar()
        {
            txtNombreBuscar.Enabled = false;
            txtEdadBuscar.Enabled = false;
            txtCarreraBuscar.Enabled = false;
            txtAñoBuscar.Enabled = false;
            txtMateriaBuscar.Enabled = false;
            txtNotaBuscar.Enabled = false;
            chkCursandoBuscar.Enabled = false;
            buscarBtn.Enabled = false;
        }

        private void activarBuscar()
        {
            txtNombreBuscar.Enabled = true;
            txtEdadBuscar.Enabled = true;
            txtCarreraBuscar.Enabled = true;
            txtAñoBuscar.Enabled = true;
            txtMateriaBuscar.Enabled = true;
            txtNotaBuscar.Enabled = true;
            chkCursandoBuscar.Enabled = true;
            buscarBtn.Enabled = true;
        }

        private void limpiarTxts()
        {
            txtCarrera.Text = null;
            txtNombre.Text = null;
            txtEdad.Text = null;
            txtPromedio.Text = null;
            chkCursando.Checked = false;
        }

        private void habilitarButton_Click_1(object sender, EventArgs e)
        {
            activarBuscar();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (exAlumnoDGV.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(exAlumnoDGV.SelectedRows[0].Cells["Id"].Value);

                bool eliminado = conexion.EliminarExAlumno(id);

                if (eliminado)
                {
                    MessageBox.Show("Alumno eliminado correctamente.");
                    exAlumnos = conexion.LeerExAlumnos();
                    exAlumnoDGV.DataSource = exAlumnos;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el alumno. Verifica el Id.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un alumno para eliminar.");
            }
        }


    }
}

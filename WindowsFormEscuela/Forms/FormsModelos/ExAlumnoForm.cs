using Ejercicio1WF;
using Ejercicio5_objetos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormEscuela.Conexiones;

namespace WindowsFormEscuela
{
    public partial class ExAlumnoForm : Form
    {
        ExAlumnoConexion conexion = new ExAlumnoConexion();
        List<ExAlumno> exAlumnos = new List<ExAlumno>();
        private bool esEdicion = false;
        private int idSeleccionado = -1;

        public ExAlumnoForm()
        {
            InitializeComponent();
            exAlumnos = conexion.LeerExAlumnos();
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
            if (exAlumnoDGV.SelectedRows.Count == 0)
            {
                errorLabel.Text = "Seleccione un alumno para editar";
                return;
            }

            esEdicion = true;
            idSeleccionado = Convert.ToInt32(exAlumnoDGV.CurrentRow.Cells["Id"].Value);
            activarTxts();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            if (string.IsNullOrWhiteSpace(txtCarrera.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtPromedio.Text))
            {
                errorLabel.Text = "No pueden haber campos vacíos";
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                errorLabel.Text = "Edad debe ser un número entero";
                return;
            }

            if (!double.TryParse(txtPromedio.Text, out double promedio))
            {
                errorLabel.Text = "Promedio debe ser un número válido";
                return;
            }

            if (edad < 18 || promedio < 0 || promedio > 10)
            {
                errorLabel.Text = "Edad debe ser >= 18 y promedio entre 0 y 10";
                return;
            }

            ExAlumno ex = new ExAlumno(txtNombre.Text, edad, txtCarrera.Text, chkCursando.Checked, promedio);

            try
            {
                if (esEdicion)
                {
                    ex.Id = idSeleccionado;
                    conexion.EditarExAlumno(ex);
                }
                else
                {
                    conexion.AgregarExAlumno(ex);
                }

                exAlumnos = conexion.LeerExAlumnos();
                exAlumnoDGV.DataSource = exAlumnos;
            }
            catch (Exception exx)
            {
                MessageBox.Show("Error al guardar el alumno: " + exx.Message);
            }

            desactivarTxts();
            limpiarTxts();
        }


        private void retrocederBtn_Click(object sender, EventArgs e)
        {
            Principal formPrincipal = new Principal();
            formPrincipal.Show();
            this.Close();
        }

        private void ExAlumnoForm_Load(object sender, EventArgs e)
        {
            try
            {
                exAlumnoDGV.DataSource = exAlumnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alumnos: " + ex.Message);
            }

            desactivarTxts();
            desactivarBuscar();
        }

        private void exAlumnoDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txtNombre.Text = exAlumnoDGV.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtCarrera.Text = exAlumnoDGV.CurrentRow.Cells["Carrera"].Value.ToString();
                    txtEdad.Text = exAlumnoDGV.CurrentRow.Cells["Edad"].Value.ToString();
                    txtPromedio.Text = exAlumnoDGV.CurrentRow.Cells["Promedio"].Value.ToString();
                    chkCursando.Checked = Convert.ToBoolean(exAlumnoDGV.CurrentRow.Cells["Estado"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar alumno: " + ex.Message);
                }
            }
        }
        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreBuscar.Text.Trim();
                string carrera = txtCarreraBuscar.Text.Trim();
                string edad = txtEdadBuscar.Text.Trim();
                string promedio = txtPromedioBuscar.Text.Trim();
                bool cursando = chkCursandoBuscar.Checked;

                exAlumnos = conexion.BuscarExAlumnos(nombre, carrera, edad, promedio, cursando);
                exAlumnoDGV.DataSource = exAlumnos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
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
            txtPromedio.Enabled = false;
            chkCursando.Enabled = false;
        }

        private void activarTxts()
        {
            txtCarrera.Enabled = true;
            txtEdad.Enabled = true;
            txtNombre.Enabled = true;
            txtPromedio.Enabled = true;
            chkCursando.Enabled = true;
        }

        private void desactivarBuscar()
        {
            txtNombreBuscar.Enabled = false;
            txtEdadBuscar.Enabled = false;
            txtCarreraBuscar.Enabled = false;
            txtPromedioBuscar.Enabled = false;
            chkCursandoBuscar.Enabled = false;
            buscarBtn.Enabled = false;
        }

        private void activarBuscar()
        {
            txtNombreBuscar.Enabled = true;
            txtEdadBuscar.Enabled = true;
            txtCarreraBuscar.Enabled = true;
            txtPromedioBuscar.Enabled = true;
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
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el alumno: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un alumno para eliminar.");
            }
        }
    }
}

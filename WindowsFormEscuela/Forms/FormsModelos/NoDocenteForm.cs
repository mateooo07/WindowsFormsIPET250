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
    public partial class NoDocenteForm : Form
    {
        NoDocenteConexion conexion = new NoDocenteConexion();
        List<NoDocente> noDocentes = new List<NoDocente>();
        private bool esEdicion = false;
        private int idSeleccionado = -1;

        public NoDocenteForm()
        {
            InitializeComponent();
            noDocentes = conexion.LeerNoDocentes();
            noDocenteDGV.DataSource = noDocentes;
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

            NoDocente noDocente = new NoDocente(txtNombre.Text, edad, txtPuesto.Text, antiguedad, salario);

            try
            {
                if (esEdicion)
                {
                    noDocente.Id = idSeleccionado;
                    conexion.EditarNoDocente(noDocente);
                }
                else
                {
                    conexion.AgregarNoDocente(noDocente);
                }

                noDocentes = conexion.LeerNoDocentes();
                noDocenteDGV.DataSource = noDocentes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el docente: " + ex.Message);
            }

            desactivarTxts();
            limpiarTxts();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (noDocenteDGV.SelectedRows.Count == 0)
            {
                errorLabel.Text = "Seleccione un docente para editar";
                return;
            }

            esEdicion = true;
            idSeleccionado = Convert.ToInt32(noDocenteDGV.CurrentRow.Cells["Id"].Value);
            activarTxts();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (noDocenteDGV.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(noDocenteDGV.SelectedRows[0].Cells["Id"].Value);
                    bool eliminado = conexion.EliminarNoDocente(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Docente eliminado correctamente.");
                        noDocentes = conexion.LeerNoDocentes();
                        noDocenteDGV.DataSource = noDocentes;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el docente. Verifica el Id.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el docente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un docente para eliminar.");
            }
        }

        private void noDocenteDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    txtNombre.Text = noDocenteDGV.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtEdad.Text = noDocenteDGV.CurrentRow.Cells["Edad"].Value.ToString();
                    txtPuesto.Text = noDocenteDGV.CurrentRow.Cells["Puesto"].Value.ToString();
                    txtAntiguedad.Text = noDocenteDGV.CurrentRow.Cells["Antiguedad"].Value.ToString();
                    txtSalario.Text = noDocenteDGV.CurrentRow.Cells["Salario"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar docente: " + ex.Message);
                }
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreBuscar.Text.Trim();
                string puesto = txtPuestoBuscar.Text.Trim();
                string edad = txtEdadBuscar.Text.Trim();
                string salario = txtSalarioBuscar.Text.Trim();
                string antiguedad = txtAntiguedadBuscar.Text.Trim();

                noDocentes = conexion.BuscarNoDocentes(nombre, puesto, edad, salario, antiguedad);
                noDocenteDGV.DataSource = noDocentes;
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

        private void NoDocenteForm_Load(object sender, EventArgs e)
        {
            try
            {
                noDocenteDGV.DataSource = noDocentes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar no docentes: " + ex.Message);
            }

            desactivarTxts();
            desactivarBuscar();
        }
    }
}

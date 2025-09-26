using Ejercicio1WF;
using Ejercicio5_objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormEscuela.Conexiones
{
    internal class ExAlumnoConexion : Conexion
    {
        public List<ExAlumno> LeerExAlumnos()
        {
            List<ExAlumno> listaExAlumno = new List<ExAlumno>();

            conexion.ConnectionString = "data source=localhost; initial catalog=Empleados_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM ExAlumno";
            comando.Connection = conexion;
            AbrirConexion();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                ExAlumno exalumno = new ExAlumno
                {
                    Id = lector.GetInt32(0),          // 🔹 agregado
                    Nombre = lector.GetString(1),
                    Edad = lector.GetInt32(2),
                    Carrera = lector.GetString(3),
                    Estado = lector.GetBoolean(4),
                    Promedio = lector.GetDouble(5)
                };
                listaExAlumno.Add(exalumno);
            }

            CerrarConexion();
            return listaExAlumno;
        }

        public void AgregarExAlumno(ExAlumno exalumno)
        {
            comando.Parameters.Clear();
            conexion.ConnectionString = "data source=localhost; initial catalog=Empleados_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "insert into ExAlumno values (@nombre, @edad, @carrera, @estado, @promedio)";

            comando.Parameters.AddWithValue("@nombre", exalumno.Nombre);
            comando.Parameters.AddWithValue("@edad", exalumno.Edad);
            comando.Parameters.AddWithValue("@carrera", exalumno.Carrera);
            comando.Parameters.AddWithValue("@estado", exalumno.Estado);
            comando.Parameters.AddWithValue("@promedio", exalumno.Promedio);

            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();

        }

        public bool EliminarExAlumno(int id)
        {
            bool eliminado = false;
            SqlConnection conexion = new SqlConnection("data source=localhost; initial catalog=Empleados_DB; integrated security=sspi");
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM ExAlumno WHERE Id = @id";
            comando.Parameters.AddWithValue("@id", id);

            AbrirConexion();
            int filasAfectadas = comando.ExecuteNonQuery();

            if (filasAfectadas > 0)
                eliminado = true;

            comando.Dispose();
            CerrarConexion();

            return eliminado;
        }


        public List<ExAlumno> BuscarExAlumnos(string nombre, string carrera, string edad, string promedio, bool cursando)
        {
            List<ExAlumno> listaExAlumnos = new List<ExAlumno>();
            SqlConnection conexion = new SqlConnection("data source=localhost; initial catalog=Empleados_DB; integrated security=sspi");
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector = null;

            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;

            StringBuilder query = new StringBuilder("SELECT * FROM ExAlumno WHERE 1=1");

            if (!string.IsNullOrWhiteSpace(nombre))
                query.Append(" AND Nombre LIKE @nombre");
            if (!string.IsNullOrWhiteSpace(carrera))
                query.Append(" AND Carrera LIKE @carrera");
            if (!string.IsNullOrWhiteSpace(edad))
                query.Append(" AND Edad = @edad");
            if (!string.IsNullOrWhiteSpace(promedio))
                query.Append(" AND Promedio = @promedio");
            if (cursando)
                query.Append(" AND Estado = @estado");

            comando.CommandText = query.ToString();

            if (!string.IsNullOrWhiteSpace(nombre))
                comando.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            if (!string.IsNullOrWhiteSpace(carrera))
                comando.Parameters.AddWithValue("@carrera", "%" + carrera + "%");
            if (!string.IsNullOrWhiteSpace(edad) && int.TryParse(edad, out int edadInt))
                comando.Parameters.AddWithValue("@edad", edadInt);
            if (!string.IsNullOrWhiteSpace(promedio) && double.TryParse(promedio, out double promedioDouble))
                comando.Parameters.AddWithValue("@promedio", promedioDouble);
            if (cursando)
                comando.Parameters.AddWithValue("@estado", cursando);

            AbrirConexion();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                ExAlumno ex = new ExAlumno();
                ex.Id = lector.GetInt32(0);
                ex.Nombre = lector.GetString(1);
                ex.Edad = lector.GetInt32(2);
                ex.Carrera = lector.GetString(3);
                ex.Estado = lector.GetBoolean(4);
                ex.Promedio = lector.GetDouble(5);

                listaExAlumnos.Add(ex);
            }

            lector.Close();
            comando.Dispose();
            CerrarConexion();

            return listaExAlumnos;
        }



        public void EditarExAlumno(ExAlumno exalumno)
        {
            comando.Parameters.Clear();
            conexion.ConnectionString = "data source=localhost; initial catalog=Empleados_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "UPDATE ExAlumno SET Nombre=@nombre, Edad=@edad, Carrera=@carrera, Estado=@estado, Promedio=@promedio WHERE Id=@id";

            comando.Parameters.AddWithValue("@nombre", exalumno.Nombre);
            comando.Parameters.AddWithValue("@edad", exalumno.Edad);
            comando.Parameters.AddWithValue("@carrera", exalumno.Carrera);
            comando.Parameters.AddWithValue("@estado", exalumno.Estado);
            comando.Parameters.AddWithValue("@promedio", exalumno.Promedio);
            comando.Parameters.AddWithValue("@id", exalumno.Id);

            AbrirConexion();
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}

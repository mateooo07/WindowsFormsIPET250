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
    internal class AlumnoConexion : Conexion
    {
        public List<Cursando> LeerAlumnos()
        {
            List<Cursando> listaAlumnos = new List<Cursando>();

            conexion.ConnectionString = "data source=localhost; initial catalog=Empleados_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM Alumno"; // cambio aquí
            comando.Connection = conexion;
            AbrirConexion();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Cursando alumno = new Cursando
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Edad = lector.GetInt32(2),
                    Carrera = lector.GetString(3),
                    Estado = lector.GetBoolean(4),
                    Anio = lector.GetString(5),
                    Materia = lector.GetString(6),
                    Nota = lector.GetInt32(7)
                };
                listaAlumnos.Add(alumno);
            }

            CerrarConexion();
            return listaAlumnos;
        }
    }
}

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
    internal class DocenteConexion : Conexion
    {
        public List<Docente> LeerDocentes()
        {
            List<Docente> listaDocente = new List<Docente>();

            conexion.ConnectionString = "data source=localhost; initial catalog=Empleados_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Docente";
            comando.Connection = conexion;
            AbrirConexion();

            SqlDataReader lector;

            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Docente docente = new Docente
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Edad = lector.GetInt32(2),
                    Puesto = lector.GetString(3),
                    Antiguedad = lector.GetInt32(4),
                    Salario = lector.GetInt32(5)
                };

                listaDocente.Add(docente);
            }

            CerrarConexion();

            return listaDocente;
        }
    }
}

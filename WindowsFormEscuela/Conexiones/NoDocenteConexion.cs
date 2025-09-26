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
    internal class NoDocenteConexion : Conexion
    {
        public List<NoDocente> LeerNoDocentes()
        {
            List<NoDocente> listaNoDocente = new List<NoDocente>();

            conexion.ConnectionString = "data source=localhost; initial catalog=Empleados_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM NoDocente";
            comando.Connection = conexion;
            AbrirConexion();

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                NoDocente nd = new NoDocente
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Edad = lector.GetInt32(2),
                    Puesto = lector.GetString(3),
                    Antiguedad = lector.GetInt32(4),
                    Salario = lector.GetInt32(5)
                };
                listaNoDocente.Add(nd);
            }

            CerrarConexion();
            return listaNoDocente;
        }
    }
}

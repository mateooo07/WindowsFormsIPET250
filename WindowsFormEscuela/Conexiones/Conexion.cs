using Ejercicio5_objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1WF
{
    internal class Conexion
    {
        protected string connectionString = "data source=localhost; initial catalog=Empleados_DB; integrated security=sspi";
        protected SqlConnection conexion;
        protected SqlCommand comando;

        public Conexion()
        {
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        protected void AbrirConexion()
        {
            if (conexion == null)
                conexion = new SqlConnection(connectionString);

            if (conexion.State != ConnectionState.Open)
                conexion.Open();

            comando.Connection = conexion;
        }

        protected void CerrarConexion()
        {
            if (conexion != null && conexion.State != ConnectionState.Closed)
                conexion.Close();
        }

    }
}

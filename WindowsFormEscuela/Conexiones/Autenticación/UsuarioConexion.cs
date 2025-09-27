using Ejercicio1WF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormEscuela.Conexiones
{
    internal class UsuarioConexion : Conexion
    {
        public bool VerificarCredenciales(string username, string password)
        {
            comando.Parameters.Clear();
            comando.CommandText = "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @username AND Contraseña = @password";
            comando.Parameters.AddWithValue("@username", username);
            comando.Parameters.AddWithValue("@password", password);
            AbrirConexion();
            int count = Convert.ToInt32(comando.ExecuteScalar());
            CerrarConexion();
            return count == 1;
        }
    }
}

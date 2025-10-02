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
            List<Docente> listaDocentes = new List<Docente>();
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = "SELECT * FROM Docente";
                AbrirConexion();

                SqlDataReader lector = comando.ExecuteReader();

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
                    listaDocentes.Add(docente);
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer docentes: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
            return listaDocentes;
        }

        public void AgregarDocente(Docente docente)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO Docente (Nombre, Edad, Puesto, Antiguedad, Salario) " +
                                      "VALUES (@nombre, @edad, @puesto, @antiguedad, @salario)";
                comando.Parameters.AddWithValue("@nombre", docente.Nombre);
                comando.Parameters.AddWithValue("@edad", docente.Edad);
                comando.Parameters.AddWithValue("@puesto", docente.Puesto);
                comando.Parameters.AddWithValue("@antiguedad", docente.Antiguedad);
                comando.Parameters.AddWithValue("@salario", docente.Salario);

                AbrirConexion();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar docente: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool EliminarDocente(int id)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = "DELETE FROM Docente WHERE Id=@id";
                comando.Parameters.AddWithValue("@id", id);

                AbrirConexion();
                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar docente: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EditarDocente(Docente docente)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = "UPDATE Docente SET Nombre=@nombre, Edad=@edad, Puesto=@puesto, Antiguedad=@antiguedad, Salario=@salario " +
                                      "WHERE Id=@id";

                comando.Parameters.AddWithValue("@nombre", docente.Nombre);
                comando.Parameters.AddWithValue("@edad", docente.Edad);
                comando.Parameters.AddWithValue("@puesto", docente.Puesto);
                comando.Parameters.AddWithValue("@antiguedad", docente.Antiguedad);
                comando.Parameters.AddWithValue("@salario", docente.Salario);
                comando.Parameters.AddWithValue("@id", docente.Id);

                AbrirConexion();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar docente: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public List<Docente> BuscarDocentes(string nombre, string puesto, string edad, string salario, string antiguedad)
        {
            List<Docente> listaDocentes = new List<Docente>();
            try
            {
                comando.Parameters.Clear();

                StringBuilder query = new StringBuilder("SELECT * FROM Docente WHERE 1=1");

                if (!string.IsNullOrWhiteSpace(nombre))
                    query.Append(" AND Nombre LIKE @nombre");
                if (!string.IsNullOrWhiteSpace(puesto))
                    query.Append(" AND Puesto LIKE @puesto");
                if (!string.IsNullOrWhiteSpace(edad))
                    query.Append(" AND Edad=@edad");
                if (!string.IsNullOrWhiteSpace(salario))
                    query.Append(" AND Salario=@salario");
                if (!string.IsNullOrWhiteSpace(antiguedad))
                    query.Append(" AND Antiguedad=@antiguedad");

                comando.CommandText = query.ToString();

                if (!string.IsNullOrWhiteSpace(nombre))
                    comando.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                if (!string.IsNullOrWhiteSpace(puesto))
                    comando.Parameters.AddWithValue("@puesto", "%" + puesto + "%");
                if (!string.IsNullOrWhiteSpace(edad) && int.TryParse(edad, out int edadInt))
                    comando.Parameters.AddWithValue("@edad", edadInt);
                if (!string.IsNullOrWhiteSpace(salario) && int.TryParse(salario, out int salarioInt))
                    comando.Parameters.AddWithValue("@salario", salarioInt);
                if (!string.IsNullOrWhiteSpace(antiguedad) && int.TryParse(antiguedad, out int antiguedadInt))
                    comando.Parameters.AddWithValue("@antiguedad", antiguedadInt);

                AbrirConexion();
                SqlDataReader lector = comando.ExecuteReader();

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
                    listaDocentes.Add(docente);
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar docentes: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
            return listaDocentes;
        }
    }
}

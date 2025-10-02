using Ejercicio1WF;
using Ejercicio5_objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

internal class NoDocenteConexion : Conexion
{
    public List<NoDocente> LeerNoDocentes()
    {
        List<NoDocente> lista = new List<NoDocente>();
        try
        {
            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM NoDocente";
            AbrirConexion();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(new NoDocente
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Edad = lector.GetInt32(2),
                    Puesto = lector.GetString(3),
                    Antiguedad = lector.GetInt32(4),
                    Salario = lector.GetInt32(5)
                });
            }
            lector.Close();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al leer no-docentes: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
        return lista;
    }

    public void AgregarNoDocente(NoDocente nd)
    {
        try
        {
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO NoDocente (Nombre, Edad, Puesto, Antiguedad, Salario) VALUES (@nombre,@edad,@puesto,@antiguedad,@salario)";
            comando.Parameters.AddWithValue("@nombre", nd.Nombre);
            comando.Parameters.AddWithValue("@edad", nd.Edad);
            comando.Parameters.AddWithValue("@puesto", nd.Puesto);
            comando.Parameters.AddWithValue("@antiguedad", nd.Antiguedad);
            comando.Parameters.AddWithValue("@salario", nd.Salario);

            AbrirConexion();
            comando.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al agregar no-docente: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
    }

    public void EditarNoDocente(NoDocente nd)
    {
        try
        {
            comando.Parameters.Clear();
            comando.CommandText = "UPDATE NoDocente SET Nombre=@nombre, Edad=@edad, Puesto=@puesto, Antiguedad=@antiguedad, Salario=@salario WHERE Id=@id";
            comando.Parameters.AddWithValue("@nombre", nd.Nombre);
            comando.Parameters.AddWithValue("@edad", nd.Edad);
            comando.Parameters.AddWithValue("@puesto", nd.Puesto);
            comando.Parameters.AddWithValue("@antiguedad", nd.Antiguedad);
            comando.Parameters.AddWithValue("@salario", nd.Salario);
            comando.Parameters.AddWithValue("@id", nd.Id);

            AbrirConexion();
            comando.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al editar no-docente: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
    }

    public bool EliminarNoDocente(int id)
    {
        try
        {
            comando.Parameters.Clear();
            comando.CommandText = "DELETE FROM NoDocente WHERE Id=@id";
            comando.Parameters.AddWithValue("@id", id);

            AbrirConexion();
            return comando.ExecuteNonQuery() > 0;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al eliminar no-docente: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
    }

    public List<NoDocente> BuscarNoDocentes(string nombre, string puesto, string edad, string salario, string antiguedad)
    {
        List<NoDocente> lista = new List<NoDocente>();
        try
        {
            comando.Parameters.Clear();
            StringBuilder query = new StringBuilder("SELECT * FROM NoDocente WHERE 1=1");

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
                lista.Add(new NoDocente
                {
                    Id = lector.GetInt32(0),
                    Nombre = lector.GetString(1),
                    Edad = lector.GetInt32(2),
                    Puesto = lector.GetString(3),
                    Antiguedad = lector.GetInt32(4),
                    Salario = lector.GetInt32(5)
                });
            }
            lector.Close();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al buscar no-docentes: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
        return lista;
    }
}

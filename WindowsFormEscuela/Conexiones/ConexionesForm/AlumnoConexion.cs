using Ejercicio1WF;
using Ejercicio5_objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

internal class AlumnoConexion : Conexion
{
    public List<Cursando> LeerAlumnos()
    {
        List<Cursando> listaAlumnos = new List<Cursando>();
        try
        {
            comando.Parameters.Clear();
            comando.CommandText = "SELECT * FROM Alumno";
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

            lector.Close();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al leer alumnos: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
        return listaAlumnos;
    }

    public void AgregarAlumno(Cursando alumno)
    {
        try
        {
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO Alumno (Nombre, Edad, Carrera, Estado, Anio, Materia, Nota) " +
                                  "VALUES (@nombre, @edad, @carrera, @estado, @año, @materia, @nota)";
            comando.Parameters.AddWithValue("@nombre", alumno.Nombre);
            comando.Parameters.AddWithValue("@edad", alumno.Edad);
            comando.Parameters.AddWithValue("@carrera", alumno.Carrera);
            comando.Parameters.AddWithValue("@estado", alumno.Estado);
            comando.Parameters.AddWithValue("@año", alumno.Anio);
            comando.Parameters.AddWithValue("@materia", alumno.Materia);
            comando.Parameters.AddWithValue("@nota", alumno.Nota);

            AbrirConexion();
            comando.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al agregar alumno: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
    }

    public bool EliminarAlumno(int id)
    {
        try
        {
            comando.Parameters.Clear();
            comando.CommandText = "DELETE FROM Alumno WHERE Id=@id";
            comando.Parameters.AddWithValue("@id", id);

            AbrirConexion();
            int filasAfectadas = comando.ExecuteNonQuery();

            return filasAfectadas > 0;
        }
        catch (Exception ex)
        {
            throw new Exception("Error al eliminar alumno: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
    }

    public void EditarAlumno(Cursando alumno)
    {
        try
        {
            comando.Parameters.Clear();
            comando.CommandText = "UPDATE Alumno SET Nombre=@nombre, Edad=@edad, Carrera=@carrera, Estado=@estado, Anio=@año, Materia=@materia, Nota=@nota " +
                                  "WHERE Id=@id";

            comando.Parameters.AddWithValue("@nombre", alumno.Nombre);
            comando.Parameters.AddWithValue("@edad", alumno.Edad);
            comando.Parameters.AddWithValue("@carrera", alumno.Carrera);
            comando.Parameters.AddWithValue("@estado", alumno.Estado);
            comando.Parameters.AddWithValue("@año", alumno.Anio);
            comando.Parameters.AddWithValue("@materia", alumno.Materia);
            comando.Parameters.AddWithValue("@nota", alumno.Nota);
            comando.Parameters.AddWithValue("@id", alumno.Id);

            AbrirConexion();
            comando.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al editar alumno: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
    }

    public List<Cursando> BuscarAlumnos(string nombre, string carrera, string edad, string año, string materia, string nota, bool cursando)
    {
        List<Cursando> listaAlumnos = new List<Cursando>();
        try
        {
            comando.Parameters.Clear();

            StringBuilder query = new StringBuilder("SELECT * FROM Alumno WHERE 1=1");

            if (!string.IsNullOrWhiteSpace(nombre))
                query.Append(" AND Nombre LIKE @nombre");
            if (!string.IsNullOrWhiteSpace(carrera))
                query.Append(" AND Carrera LIKE @carrera");
            if (!string.IsNullOrWhiteSpace(edad))
                query.Append(" AND Edad=@edad");
            if (!string.IsNullOrWhiteSpace(año))
                query.Append(" AND Año LIKE @año");
            if (!string.IsNullOrWhiteSpace(materia))
                query.Append(" AND Materia LIKE @materia");
            if (!string.IsNullOrWhiteSpace(nota))
                query.Append(" AND Nota=@nota");
            if (cursando)
                query.Append(" AND Estado=@estado");

            comando.CommandText = query.ToString();

            if (!string.IsNullOrWhiteSpace(nombre))
                comando.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            if (!string.IsNullOrWhiteSpace(carrera))
                comando.Parameters.AddWithValue("@carrera", "%" + carrera + "%");
            if (!string.IsNullOrWhiteSpace(edad) && int.TryParse(edad, out int edadInt))
                comando.Parameters.AddWithValue("@edad", edadInt);
            if (!string.IsNullOrWhiteSpace(año))
                comando.Parameters.AddWithValue("@año", "%" + año + "%"); // corregido parámetro
            if (!string.IsNullOrWhiteSpace(materia))
                comando.Parameters.AddWithValue("@materia", "%" + materia + "%");
            if (!string.IsNullOrWhiteSpace(nota) && int.TryParse(nota, out int notaInt))
                comando.Parameters.AddWithValue("@nota", notaInt);
            if (cursando)
                comando.Parameters.AddWithValue("@estado", cursando);

            AbrirConexion();
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Cursando crs = new Cursando()
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
                listaAlumnos.Add(crs);
            }

            lector.Close();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al buscar alumnos: " + ex.Message, ex);
        }
        finally
        {
            CerrarConexion();
        }
        return listaAlumnos;
    }
}

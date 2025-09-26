using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_objetos
{
    internal sealed class ExAlumno : Estudiante // sellar clase con "sealed"
    {
        private double promedio;
        public double Promedio { get => promedio; set => promedio = value; }

        public ExAlumno() { }

        public ExAlumno(string nombre, int edad, string carrera, bool estado, double promedio) : base(nombre,edad,carrera,estado)
        {
            Promedio = promedio;
        }

        public override void Condición()
        {
            Console.WriteLine($"Exalumno con promedio de {promedio}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_objetos
{
    internal class Estudiante: Persona
    {
        private string carrera;
        private bool estado;
        public string Carrera { get => carrera; set => carrera = value; }
        public bool Estado { get => estado; set => estado = value; }

        public Estudiante()
        {

        }

        public Estudiante(string nombre, int edad, string carrera, bool estado) : base(nombre, edad)
        {
            Carrera = carrera;
            Estado = estado;
        }

        public override void InfoPersona()
        {
            Console.WriteLine($"{Nombre} es un alumno de la Universidad que se encuentra en la carrera {Carrera} en estado: {Estado}.");

        }

    }
}

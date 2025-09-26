using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_objetos
{
    internal abstract class Persona
    {
        private int id;
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Id { get => id; set => id = value; }

        public Persona() { 
        
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void Condición()
        {
            Console.WriteLine($"{Nombre} es una Persona.");
        }

        public abstract void InfoPersona();
    }


}

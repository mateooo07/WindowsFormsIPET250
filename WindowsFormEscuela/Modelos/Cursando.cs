using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_objetos
{
    internal class Cursando : Estudiante, IRangoEdades
    {
        private string anio;
        private string materia;
        private int nota;

        public string Anio { get => anio; set => anio = value; }
        public string Materia { get => materia; set => materia = value; }
        public int Nota { get => nota; set => nota = value; }

        public Cursando()
        {

        }

        public Cursando(string nombre, int edad, string carrera, bool estado, string anio, string materia, int nota) : base(nombre, edad, carrera, estado)
        {
            Anio = anio;
            Materia = materia;
            Nota = nota;
        }

        public override void Condición()
        {
            Console.WriteLine($"Se encuentra en {anio} año.");
        } 

        public string RangoEdades()
        {
            if(Edad < 18)
            {
                return "menor de edad";
            }else if(Edad >= 18 && Edad <= 29)
            {
                return "joven";
            }else if(Edad >= 30 && Edad <= 39)
            {
                return "adulto joven";
            }else if(Edad >= 40 && Edad <= 59)
            {
                return "adulto";
            }else
            {
                return "adulto mayor";
            }
        }
        
    }
}

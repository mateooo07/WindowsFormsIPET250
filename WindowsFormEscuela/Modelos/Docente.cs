using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_objetos
{
    internal class Docente: Empleado, IRangoEdades
    {
        public Docente()
        {

        }

        public Docente(string nombre, int edad, string puesto, int antiguedad, int salario) : base(nombre, edad, puesto, antiguedad, salario)
        {
           
        }
        public string RangoEdades()
        {
            if (Edad >= 18 && Edad <= 29)
            {
                return "joven";
            }
            else if (Edad >= 30 && Edad <= 39)
            {
                return "adulto joven";
            }
            else if (Edad >= 40 && Edad <= 59)
            {
                return "adulto";
            }
            else
            {
                return "adulto mayor";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_objetos
{
    internal class Empleado : Persona
    {
        private string puesto;
        private int antiguedad;
        private int salario;

        public string Puesto { get => puesto; set => puesto = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public int Salario { get => salario; set => salario = value; }

        public Empleado() { 
        
        }

        public Empleado(string nombre, int edad, string puesto, int antiguedad, int salario) : base( nombre, edad)
        {
            Antiguedad = antiguedad;
            Puesto = puesto;
            Salario = salario;
        }

        public override void InfoPersona()
        {
            Console.WriteLine($"{Nombre} es un empleado de la Universidad que se encuentra en el puesto: {Puesto}");
        }

    }
}

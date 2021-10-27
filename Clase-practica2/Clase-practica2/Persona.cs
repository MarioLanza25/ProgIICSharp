using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_practica2
{
    class Persona
    {
        private string nombre; /*{ get; set; }*/
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        //Click nombre dato, opc 2
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public virtual void mostrarSaludo()
        {
            Console.WriteLine("Hola mi nombre es :"+this.nombre);
        }
    }
}

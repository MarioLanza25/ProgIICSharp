using System;

namespace Clase_practica2
{
    class Program
    {

        /*Clase practica  herencia
         * Clase persona 
        */
        static void Main(string[] args)
        {
            PersonaIngles ingles = new PersonaIngles("Carlos", 23);
            ingles.mostrarSaludo();
            ingles.tomarTe();

        }
    }
}

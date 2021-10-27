using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_practica2
{
    class PersonaIngles :Persona
    {
                                //atributos a agregar  en el base atributos padre
        public PersonaIngles(string nombre, int edad) : base(nombre, edad)
        {

        }

        public virtual void tomarTe()
        {
            Console.WriteLine("Me gusta tomar te!");
        }

        //para sobreescribir metodo del padre usar palabra virtual
        public override void mostrarSaludo()
        {

        }
    }
}

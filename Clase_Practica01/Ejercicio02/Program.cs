using System;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, ingrese la informaciòn que se le pide!!");
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su sueldo:");
            float sueldo = float.Parse(Console.ReadLine());

            Console.WriteLine("¿Cual es su numero de hijos?");
            int numHijos = int.Parse(Console.ReadLine());

            float bono;

            if (numHijos >=3)
            {
                bono = numHijos * 10;
                Console.WriteLine("Su sueldo es: "+  (sueldo + bono));
            }
            else
            {
                bono = numHijos * 20;
                Console.WriteLine("Su sueldo a recibir mas el bono es: " + (sueldo + bono));
            }
        }
    }
}

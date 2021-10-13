using System;

namespace Clase_Practica01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese primer numero:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese primer numero:");
            int b = int.Parse(Console.ReadLine());


            int op = ((a+b) * (a-b));

            Console.WriteLine("El resultado es :" + op);
        }
    }
}

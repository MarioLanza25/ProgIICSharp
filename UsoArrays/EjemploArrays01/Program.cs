using System;

namespace EjemploArrays01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] nombre = new string[5];
            int[] edades = new int[5];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese nombre:");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese edad:");
                edades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Personas mayores de edad:");

            for (int i = 0; i < nombre.Length; i++)
            {
                if (edades[i] >= 18)
                    Console.WriteLine(nombre[i]);
            }
        }
    }
}

using System;

namespace EjemploArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos elementos quieres que tenga el array?");
            string respuesta = Console.ReadLine();
            int numElementos = int.Parse(respuesta);
            int[] datos = new int[numElementos];

            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion {i}");
                respuesta = Console.ReadLine();
                int datosElementos = int.Parse(respuesta);
                datos[i] = datosElementos;
            }

            Console.WriteLine("-------------");

            foreach (int elementos in datos)
            {
                Console.WriteLine(elementos);
            }
        }
    }
}

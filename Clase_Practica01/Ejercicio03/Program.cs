using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido!!");
            Console.WriteLine("Ingrese cantidad de estudiantes:");
            int cantidad = int.Parse(Console.ReadLine());

            string [] nombres = new string[cantidad];
            float[] notas = new float[3]; ;
            float suma = 0;
            float []promedio = new float[cantidad];
            int k =0;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese nombre del estudiante " +(i+1) + ":");
                string nombre = Console.ReadLine();
                nombres[i] = nombre;
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese nota " + (j + 1) + ":");
                    float nota = float.Parse(Console.ReadLine());
                    notas[j] = nota;
                    suma += notas[j];

                }
                promedio[k] = suma / notas.Length;
                k++;
            }

            //Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Nombre: " + nombres[i] + ", promedio: " + promedio[i]);
            }

        }
    }
}

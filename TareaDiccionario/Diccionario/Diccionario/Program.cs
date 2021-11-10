using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Program
    {
        static Dictionary<string, string> palabras;
        static void Main(string[] args)
        {
            //key - value
            //palabra - traduccion
             
            int op;
            
            Console.WriteLine("Bienvenido\n");

            Console.WriteLine(" App de traduccion");
            do {
                menuDeOpciones();
                Console.WriteLine("Ingrese una opcion");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (op)
                {
                    case 1:
                        System.Console.Clear();
                        crearDiccionario();
                        break;
                    case 2:
                        System.Console.Clear();
                        Console.WriteLine("Palabras dentro del diccionario");
                        listaPalabrasDelDiccionario();
                        break;
                    case 3:
                        System.Console.Clear();
                        obtenerTraduccion();
                        break;
                    case 4:
                        Console.WriteLine("Presione una tecla...");
                        Console.Read();
                        break;
                    default:
                        break;
                }
            } while (op != 4);

        }
        
        private static void menuDeOpciones()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Crear diccionario");
            Console.WriteLine("2. Ver palabras en el diccionario");
            Console.WriteLine("3. Traducción ingles-español");
            Console.WriteLine("4. Salir");
            Console.WriteLine("---------------------------------");
        }

        private static void crearDiccionario()
        {
            int cantidad;

            do
            {
                Console.WriteLine("Ingrese cantidad de palabras en el diccionario (No mas de 100)");
                cantidad = int.Parse(Console.ReadLine());
            } while (cantidad <1 || cantidad >100);

            List<string> list = new List<string>();
            palabras = new Dictionary<string, string>();

                for (int i = 0; i <cantidad; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese pareja "+(i + 1)+" <ingles:español> (divididos por :)");
                    string line = Console.ReadLine();
                    string[] split = line.Split(':');
                    palabras.Add(split[0], split[1]);                   
                }  
        }

        private static void  listaPalabrasDelDiccionario()
        {
            int i = 0;
            foreach (KeyValuePair<string, string> pares in palabras)
            {
                Console.WriteLine((i+1)+"."+" Key= {0}, Value = {1}", pares.Key, pares.Value);
                i++;
            }
        }

        private static void obtenerTraduccion()
        {
            Console.WriteLine("Ingrese palabra en ingles:");
            string txtKey = Console.ReadLine();


                //Console.WriteLine("Key = {0}, Value = {1}", pares.Key, pares.Value);
                if (palabras.TryGetValue(txtKey, out string result))
                {
                    Console.WriteLine("");
                    Console.WriteLine("La traduccion de la palabra "+txtKey+" es: "+result); //verde
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("La palabra "+txtKey+ " no se encuentra en el diccionario.");
                    Console.WriteLine("");
                }
        }

    }
}

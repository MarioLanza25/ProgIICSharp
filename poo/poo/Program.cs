using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carro c = new Carro(1, "Toyota", "Yaris", 500, 350000, false);
            //Moto m = new Moto(2, "BMW", "R12", 100, 175000, false);

            //Console.WriteLine("Precio del carro: " + c.Precio.ToString("C"));
            //Console.WriteLine("Precio de la moto: " + m.Precio.ToString("C"));

            //Console.WriteLine(c.ToString());
            //Console.WriteLine(m.ToString());

            Carro c = new Carro(1, "Toyota", "Yaris", 500, 350000, true);
            Moto m = new Moto(2, "BMW", "R12", 100, 175000, true);

            Console.WriteLine("Precio del carro: " + c.Precio.ToString("C"));
            Console.WriteLine("Precio de la moto: " + m.Precio.ToString("C"));

            Console.WriteLine(c.ToString());
            Console.WriteLine(m.ToString());
        }
    }
}

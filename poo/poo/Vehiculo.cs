using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Vehiculo
    {
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private double precio;

        public Vehiculo(int id, string marca, string modelo, int km, double precio)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public virtual double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return "Marca: " + marca + ", modelo: " + modelo + " con precio de " + precio.ToString("C");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    class Telefono
    {
        private string nombre;
        private string marca;
        private double precio;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Precio { get => precio; set => precio = value; }

        public Telefono(string nombre, string marca, double precio)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
        }
    }
}

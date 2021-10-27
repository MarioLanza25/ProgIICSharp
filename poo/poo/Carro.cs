using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Carro : Vehiculo
    {
        private bool airbag;

        public Carro(int id, string marca, string modelo, int km, double precio, bool airbag)
            : base(id, marca, modelo, km, precio)
        {
            this.airbag = airbag;
        }

        public override double Precio
        {
            get
            {
                if (this.airbag)
                    return base.Precio + 7000;
                else
                    return base.Precio;
            }
        }

        public bool Airbag { get => airbag; set => airbag = value; }

        public override string ToString()
        {
            if (this.airbag)
                return base.ToString() + " y tiene airbag";
            else
                return base.ToString() + " y no tiene airbag";
        }
    }
}

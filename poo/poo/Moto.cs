using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    class Moto : Vehiculo
    {
        private bool sidecar;

        public Moto(int id, string marca, string modelo, int km, double precio, bool sidecar)
            : base(id, marca, modelo, km, precio)
        {
            this.sidecar = sidecar;
        }

        public bool Sidecar { get => sidecar; set => sidecar = value; }

        public override double Precio
        {
            get
            {
                if (this.sidecar)
                    return base.Precio + 1750;
                else
                    return base.Precio;
            }
        }

        public override string ToString()
        {
            if (this.sidecar)
                return base.ToString() + " y tiene sidecar";
            else
                return base.ToString() + " y no tiene sidecar";
        }
    }
}

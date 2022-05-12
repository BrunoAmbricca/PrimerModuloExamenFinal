using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerModuloExamenFinal.Models
{
    public class Pantalon : Prenda
    {
        private bool chupin;

        public Pantalon(bool premium, int stock, bool chupin) : base(premium, stock)
        {
            this.chupin = chupin;
        }

        public bool Chupin { get => chupin; }

        public override double calcularPrecio()
        {
            double precioFinal = this.Price;

            if (chupin)
            {
                precioFinal -= precioFinal * 0.12;
            }

            if (this.Premium)
            {
                precioFinal += precioFinal * 0.3;
            }

            return precioFinal;
        }
    }
}

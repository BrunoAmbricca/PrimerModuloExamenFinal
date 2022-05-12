using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerModuloExamenFinal.Models
{
    public class Camisa : Prenda
    {
        private bool shortSleeve;
        private bool maoNeck;

        public Camisa(bool premium, int stock, bool shortSleeve, bool maoNeck) : base(premium, stock)
        {
            this.shortSleeve = shortSleeve;
            this.maoNeck = maoNeck;
        }

        public bool ShortSleeve { get => shortSleeve; }
        public bool MaoNeck { get => maoNeck; }

        public override double calcularPrecio()
        {
            double precioFinal = this.Price;

            if (shortSleeve)
            {
                precioFinal -= precioFinal * 0.1;
            }

            if (maoNeck)
            {
                precioFinal += precioFinal * 0.03;
            }

            if (this.Premium)
            {
                precioFinal += precioFinal * 0.3;
            }

            return precioFinal;
        }
    }
}

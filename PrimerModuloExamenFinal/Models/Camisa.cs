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

        public override double calcularPrecio(double precioUnitario)
        {
            if (shortSleeve)
            {
                precioUnitario -= precioUnitario * 0.1;
            }

            if (maoNeck)
            {
                precioUnitario += precioUnitario * 0.03;
            }

            if (this.Premium)
            {
                precioUnitario += precioUnitario * 0.3;
            }

            return precioUnitario;
        }
    }
}

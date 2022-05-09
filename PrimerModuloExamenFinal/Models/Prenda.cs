using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerModuloExamenFinal.Models
{
    public abstract class Prenda
    {
        private bool premium;
        //private double price { get; set; }
        private int stock;

        public Prenda(bool premium, int stock)
        {
            this.premium = premium;
            this.stock = stock;
        }

        public bool Premium { get => premium;}
        public int Stock { get => stock;}

        public abstract double calcularPrecio(double precioUnitario);

    }
}

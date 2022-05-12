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
        private double price;
        private int stock;

        public Prenda(bool premium, int stock)
        {
            this.premium = premium;
            this.price = 0;
            this.stock = stock;
        }

        public bool Premium { get => premium;}
        public int Stock { get => stock;}
        public double Price { get => price; set => price = value; }

        public abstract double calcularPrecio();

    }
}

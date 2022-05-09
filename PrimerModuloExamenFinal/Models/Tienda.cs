using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerModuloExamenFinal.Models
{
    public class Tienda
    {
        private string name;
        private string adress;
        private List<Prenda> products;

        public Tienda(string name, string adress, List<Prenda> products)
        {
            this.name = name;
            this.adress = adress;
            this.products = products;
        }

        public List<Prenda> Products { get => products;}
        public string Adress { get => adress;}
        public string Name { get => name;}
    }
}

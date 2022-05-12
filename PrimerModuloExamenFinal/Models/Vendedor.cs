using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerModuloExamenFinal.Models
{
    public class Vendedor
    {
        private string name;
        private string surname;
        private string sellerCode;

        public string SellerCode { get => sellerCode; }
        public string Name { get => name;}
        public string Surname { get => surname;}

        public Vendedor(string name, string surname, string sellerCode)
        {
            this.name = name;
            this.surname = surname;
            this.sellerCode = sellerCode;
        }

        
    }
}

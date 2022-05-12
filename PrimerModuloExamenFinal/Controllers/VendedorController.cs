using PrimerModuloExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerModuloExamenFinal.Controllers
{
    public class VendedorController
    {
        private Vendedor vendedor;

        public VendedorController()
        {
            this.vendedor = new Vendedor("Juan", "Perez", "BL35SD1");
        }

        public Vendedor getVendedor()
        {
            return vendedor;
        }
    }
}

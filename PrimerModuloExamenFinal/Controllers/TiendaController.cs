using PrimerModuloExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerModuloExamenFinal.Controllers
{
    public class TiendaController
    {
        private Tienda tienda;
        
        

        public TiendaController()
        {
            List<Prenda> products = initializeProducts();
            this.tienda = new Tienda("Cabildo Style", "Cabildo 365", products);           
        }

        private List<Prenda> initializeProducts()
        {
            List<Prenda> products = new List<Prenda>();
            //Pantalones creacion
            products.Add(new Pantalon(false, 750, true));
            products.Add(new Pantalon(false, 250, false));
            products.Add(new Pantalon(true, 750, true));
            products.Add(new Pantalon(true, 250, false));
            //Camisas creacion
            products.Add(new Camisa(false, 100, true, true));
            products.Add(new Camisa(true, 100, true, true));
            products.Add(new Camisa(false, 150, true, false));
            products.Add(new Camisa(true, 150, true, false));
            products.Add(new Camisa(false, 75, false, true));
            products.Add(new Camisa(true, 75, false, true));
            products.Add(new Camisa(false, 175, false, false));
            products.Add(new Camisa(true, 175, false, false));

            return products;
 
        }

        

        public Prenda getPrendaFromTienda(bool chupinCheckBox, bool camisaRadioBtn, bool shortSleeveCheckBox, bool maoNeckCheckBox, bool premiumRadioBtn)
        {
            return tienda.getPrenda(chupinCheckBox, camisaRadioBtn, shortSleeveCheckBox, maoNeckCheckBox, premiumRadioBtn);
        }

        

        public Tienda getTienda()
        {
            return tienda;
        }

        

    }
}

using PrimerModuloExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerModuloExamenFinal.Controllers
{
    public class CotizacionController
    {
        private List<Cotizacion> cotizaciones;

        public CotizacionController()
        {
            this.cotizaciones = new List<Cotizacion>();
        }

        public double crearCotizacion(Tienda tienda, Vendedor vendedor, bool chupinCheckBox, bool camisaRadioBtn, bool shortSleeveCheckBox, bool maoNeckCheckBox, bool premiumRadioBtn, string priceTextBox, string quantityTextBox)
        {
            Prenda product = tienda.getPrenda(chupinCheckBox, camisaRadioBtn, shortSleeveCheckBox, maoNeckCheckBox, premiumRadioBtn);
            product.Price = double.Parse(priceTextBox);

            double result = product.calcularPrecio() * int.Parse(quantityTextBox);

            Cotizacion cotizacion = new Cotizacion(this.cotizaciones.Count(), DateTime.Now, vendedor.SellerCode, product, int.Parse(quantityTextBox), result);

            cotizaciones.Add(cotizacion);

            return result;
        }

        public string getListaCotizaciones()
        {
            string cotizacionesShow = "Historial de Cotizaciones\n";

            foreach (Cotizacion cot in cotizaciones)
            {
                cotizacionesShow += cot.imprimir();
            }

            return cotizacionesShow;
        }
    }
}

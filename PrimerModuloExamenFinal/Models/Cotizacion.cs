using PrimerModuloExamenFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerModuloExamenFinal.Models
{
    public class Cotizacion : IImprimible
    {
        private int id;
        private DateTime created;
        private string sellerCode;
        private Prenda product;
        private int productQuantity;
        private double result;

        public Cotizacion(int id, DateTime created, string sellerCode, Prenda product, int productQuantity, double result)
        {
            this.id = id;
            this.created = created;
            this.sellerCode = sellerCode;
            this.product = product;
            this.productQuantity = productQuantity;
            this.result = result;
        }

        public int Id { get => id;}
        public DateTime Created { get => created;}
        public string SellerCode { get => sellerCode;}
        public Prenda Product { get => product;}
        public int ProductQuantity { get => productQuantity;}
        public double Result { get => result;}

        public string imprimir()
        {
            string product = "";
            string specifications = "";

            if (this.Product is Camisa)
            {
                Camisa camisa = (Camisa)this.Product;
                string sleeve = camisa.ShortSleeve ? "Manga Corta" : "Manga Larga";
                string neck = camisa.MaoNeck ? "Cuello Mao" : "Cuello Comun";
                string quality = camisa.Premium ? "Premium" : "Standard";

                product = "Camisa";
                specifications = sleeve + " - " + neck + " - " + quality;
            }
            else
            {
                Pantalon pantalon = (Pantalon)this.Product;
                string type = pantalon.Chupin ? "Chupin" : "Comun";
                string quality = pantalon.Premium ? "Premium" : "Standard";

                product = "Pantalon";
                specifications = type + " - " + quality;
            }

            string cotizacionShow = ("-------------------------\n"
                               + "Id: " + this.Id + "\n"
                               + "Fecha: " + this.Created + "\n"
                               + "Codigo de Vendedor: " + this.SellerCode + "\n"
                               + "Producto: " + product + " " + specifications + "\n"
                               + "Cantidad: " + this.ProductQuantity + "\n"
                               + "Precio Cotizado: " + this.Result + "\n");

            return cotizacionShow;
        }
    }
}

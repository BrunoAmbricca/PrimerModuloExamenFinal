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

        public Prenda getPrenda(bool isChupin, bool isCamisa, bool isShortSleeve, bool isMaoNeck, bool isPremium)
        {
            Prenda product = null;
            int index = 0;
            if (isCamisa)
            {
                while (index < this.Products.Count() && product == null)
                {
                    Prenda prod = this.Products[index];

                    if (prod is Camisa)
                    {
                        Camisa camisa = (Camisa)prod;

                        if (camisa.ShortSleeve == isShortSleeve && camisa.MaoNeck == isMaoNeck && camisa.Premium == isPremium)
                        {
                            product = camisa;
                        }
                    }
                    index++;
                }
            }
            else
            {
                while (index < this.Products.Count() && product == null)
                {
                    Prenda prod = this.Products[index];

                    if (prod is Pantalon)
                    {
                        Pantalon pantalon = (Pantalon)prod;

                        if (pantalon.Chupin == isChupin && pantalon.Premium == isPremium)
                        {
                            product = pantalon;
                        }
                    }
                    index++;
                }

            }

            return product;
        }
    }
}

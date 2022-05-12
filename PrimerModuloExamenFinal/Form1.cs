using PrimerModuloExamenFinal.Controllers;
using PrimerModuloExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerModuloExamenFinal
{
    public partial class Form1 : Form
    {
        public TiendaController tiendaController;
        public CotizacionController cotizacionController;
        public VendedorController vendedorController;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tiendaController = new TiendaController();
            this.cotizacionController = new CotizacionController();
            this.vendedorController = new VendedorController();

            Tienda tienda = this.tiendaController.getTienda();
            Vendedor vendedor = this.vendedorController.getVendedor();


            tiendaNameLabel.Text = tienda.Name;
            adressTiendaLabel.Text = tienda.Adress;
            sellerNameLabel.Text = vendedor.Name + " " + vendedor.Surname + " | " + vendedor.SellerCode; ;
            resultLabel.Text = "";
            stockLabel.Text = "";
            chupinCheckBox.Enabled = false;
            cotizarBtn.Enabled = false;

        }

        private void cotizarBtn_Click(object sender, EventArgs e)
        {
            if(int.Parse(quantityTextBox.Text) > int.Parse(stockLabel.Text))
            {
                MessageBox.Show("ERROR, No hay suficiente stock para realizar la cotizacion");
            }
            else
            {
                double result = cotizacionController.crearCotizacion(tiendaController.getTienda(), vendedorController.getVendedor(), chupinCheckBox.Checked, camisaRadioBtn.Checked, shortSleeveCheckBox.Checked, maoNeckCheckBox.Checked, premiumRadioBtn.Checked, priceTextBox.Text, quantityTextBox.Text);
                resultLabel.Text = "" + result;
            }
            
        }

        private void camisaRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Prenda prenda = tiendaController.getPrendaFromTienda(chupinCheckBox.Checked, camisaRadioBtn.Checked, shortSleeveCheckBox.Checked, maoNeckCheckBox.Checked, premiumRadioBtn.Checked);
            stockLabel.Text = "" + prenda.Stock;

            chupinCheckBox.Enabled = false;
            maoNeckCheckBox.Enabled = true;
            shortSleeveCheckBox.Enabled = true;
        }

        private void pantalonRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            chupinCheckBox.Enabled = true;
            maoNeckCheckBox.Enabled = false;
            shortSleeveCheckBox.Enabled = false;
        }

        private void premiumRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Prenda prenda = tiendaController.getPrendaFromTienda(chupinCheckBox.Checked, camisaRadioBtn.Checked, shortSleeveCheckBox.Checked, maoNeckCheckBox.Checked, premiumRadioBtn.Checked);
            stockLabel.Text = "" + prenda.Stock;
        }

        private void shortSleeveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Prenda prenda = tiendaController.getPrendaFromTienda(chupinCheckBox.Checked, camisaRadioBtn.Checked, shortSleeveCheckBox.Checked, maoNeckCheckBox.Checked, premiumRadioBtn.Checked);
            stockLabel.Text = "" + prenda.Stock;
        }

        private void maoNeckCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Prenda prenda = tiendaController.getPrendaFromTienda(chupinCheckBox.Checked, camisaRadioBtn.Checked, shortSleeveCheckBox.Checked, maoNeckCheckBox.Checked, premiumRadioBtn.Checked);
            stockLabel.Text = "" + prenda.Stock;
        }

        private void chupinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Prenda prenda = tiendaController.getPrendaFromTienda(chupinCheckBox.Checked, camisaRadioBtn.Checked, shortSleeveCheckBox.Checked, maoNeckCheckBox.Checked, premiumRadioBtn.Checked);
            stockLabel.Text = "" + prenda.Stock;
        }

        private void historialLabel_Click(object sender, EventArgs e)
        {
            string cotizacionesShow = cotizacionController.getListaCotizaciones();
            MessageBox.Show(cotizacionesShow);
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(priceTextBox.Text, out int n))
            {
                priceTextBox.Text = "";
            }

            if (priceTextBox.Text != "" && quantityTextBox.Text != "")
            {
                cotizarBtn.Enabled = true;
            }
            else
            {
                cotizarBtn.Enabled = false;
            }
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(quantityTextBox.Text, out int n))
            {
                quantityTextBox.Text = "";
            }

            if (priceTextBox.Text != "" && quantityTextBox.Text != "")
            {
                cotizarBtn.Enabled = true;
            }
            else
            {
                cotizarBtn.Enabled = false;
            }
        }

    }
}

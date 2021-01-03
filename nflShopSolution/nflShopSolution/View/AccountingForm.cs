using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nflShopSolution.View
{
    public partial class AccountingForm : Form
    {
        Shop shop;

        public AccountingForm(Shop shop)
        {
            this.shop = shop;

            InitializeComponent();
            CenterToScreen();

            DisplayValues();
        }

        private void DisplayValues()
        {
            labelRendelesSzam.Text = shop.GetOrdersCount() + "db";
            labelBeszerAr.Text = "$" + shop.GetTotalBeszerzesiAr();
            labelEladAr.Text = "$" + shop.GetTotalEladasiAr();
            labelNyereseg.Text = "$" + shop.GetTotalProfit();
        }
    }
}

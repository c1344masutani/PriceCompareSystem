using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem
{
    public partial class F_Admin : Form
    {
        public F_Admin()
        {
            InitializeComponent();
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            F_Store f_Store = new F_Store();
            f_Store.ShowDialog();
        }

        private void buttonPriceList_Click(object sender, EventArgs e)
        {
            F_PriceList.stname = "admin";
            F_PriceList f_PriceList = new F_PriceList();
            f_PriceList.ShowDialog();
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            F_Genre f_Genre = new F_Genre();
            f_Genre.ShowDialog();
        }

        private void buttonMaker_Click(object sender, EventArgs e)
        {
            F_Maker f_Maker = new F_Maker();
            f_Maker.ShowDialog();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            F_Product f_Product = new F_Product();
            f_Product.ShowDialog();
        }

        private void F_Admin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

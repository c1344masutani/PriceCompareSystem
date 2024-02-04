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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Store f_Store = new F_Store();
            f_Store.ShowDialog();
            f_Store.Dispose();
        }

        private void buttonPriceList_Click(object sender, EventArgs e)
        {
            F_PriceList.stname = "管理者";
            F_PriceList f_PriceList = new F_PriceList();
            f_PriceList.ShowDialog();
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Genre f_Genre = new F_Genre();
            f_Genre.ShowDialog();
            f_Genre.Dispose();
        }

        private void buttonMaker_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Maker f_Maker = new F_Maker();
            f_Maker.ShowDialog();
            f_Maker.Dispose();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Product f_Product = new F_Product();
            f_Product.ShowDialog();
            f_Product.Dispose();
        }

        private void F_Admin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void F_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Menu f_Menu = new F_Menu();
            f_Menu.ShowDialog();
            f_Menu.Dispose();
        }

        private void buttonPWChange_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_AdminPW f_AdminPW = new F_AdminPW();
            f_AdminPW.ShowDialog();
            f_AdminPW.Dispose();
        }
    }
}

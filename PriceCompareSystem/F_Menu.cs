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
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Login f_Login = new F_Login();
            f_Login.ShowDialog();
            f_Login.Dispose();
        }

        private void buttonEasySearch_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_EasySearch f_EasySearch = new F_EasySearch();
            f_EasySearch.ShowDialog();
            f_EasySearch.Dispose();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Serach f_Serach = new F_Serach();
            f_Serach.ShowDialog();
            f_Serach.Dispose();
        }

        private void F_Menu_Activated(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Opacity = 1;
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("終了してもよろしいですか？", "終了確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            Application.Exit();
        }

        private void F_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

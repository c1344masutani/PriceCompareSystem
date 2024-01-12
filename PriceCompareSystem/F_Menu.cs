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
            F_Login f_Login = new F_Login();
            f_Login.ShowDialog();
        }

        private void buttonEasySearch_Click(object sender, EventArgs e)
        {
            F_EasySearch f_EasySearch = new F_EasySearch();
            f_EasySearch.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            F_Serach f_Serach = new F_Serach();
            f_Serach.ShowDialog();
        }
    }
}

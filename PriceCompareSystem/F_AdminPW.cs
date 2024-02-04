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
    public partial class F_AdminPW : Form
    {
        public F_AdminPW()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string nowPW = textBoxNowPassWord.Text.Trim();
            string newPW = textBoxNewPassWord.Text.Trim();
            bool flg;

            try
            {
                var context = new PriceCompareSystemContext();
                flg = context.M_Users.Any(x => x.UserName == "admin" && x.PassWord == nowPW);
                if(flg == true)
                {
                    DialogResult result = MessageBox.Show("パスワードを変更してもよろしいですか？", "変更確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                    var admin = context.M_Users.Single(x => x.UserName == "admin");
                    admin.PassWord = newPW;
                    context.SaveChanges();
                    context.Dispose();
                    textBoxNewPassWord.Text = "";
                    textBoxNowPassWord.Text = "";
                    MessageBox.Show("パスワードを変更しました");
                }
                else
                {
                    MessageBox.Show("現在のパスワードが違います");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Admin f_Admin = new F_Admin();
            f_Admin.ShowDialog();
            f_Admin.Dispose();
        }
    }
}

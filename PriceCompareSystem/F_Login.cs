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
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string stid = textBoxStID.Text.Trim();
            string password = textBoxPassWord.Text.Trim();
            bool flg;
            if(String.IsNullOrEmpty(textBoxStID.Text.Trim()) || String.IsNullOrEmpty(textBoxPassWord.Text.Trim()))
            {
                MessageBox.Show("IDまたはパスワードが入力されていません");
                return;
            }

            if(stid == "admin")
            {
                try
                {
                    var context = new PriceCompareSystemContext();
                    flg = context.M_Users.Any(x => x.UserName == stid && x.PassWord == password);
                    if(flg == true)
                    {
                        Form frm = new F_Admin();

                        Opacity = 0;
                        frm.ShowDialog();


                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("管理者パスワードが違います");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                try
                {
                    var context = new PriceCompareSystemContext();
                    flg = context.M_Stores.Any(x => x.StID.ToString() == stid && x.StPassWord == password);
                    if (flg == true)
                    {
                        var login = context.M_Stores.Single(x => x.StID.ToString() == stid);
                        F_PriceList.stid = login.StID.ToString();
                        F_PriceList.stname = login.StName;
                        F_PriceList.pfid = login.Prefectures.ToString();
                        Form frm = new F_PriceList();

                        Opacity = 0;
                        frm.ShowDialog();


                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("IDまたはPWが違います。");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }
    }
}

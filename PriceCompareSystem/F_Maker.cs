using PriceCompareSystem.Entity;
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
    public partial class F_Maker : Form
    {
        public F_Maker()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AllClear()
        {
            labelMaID.Text = "";
            textBoxMaName.Text = "";
            textBoxMaAddress.Text = "";
            textBoxPhone.Text = "";
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new PriceCompareSystemContext();
                foreach(var p in context.M_Makers)
                {
                    dataGridViewDsp.Rows.Add(p.MaID, p.MaName, p.MaAddress, p.MaPhone);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegester_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMaName.Text.Trim()))
            {
                MessageBox.Show("メーカー名を入力してください");
                return;
            }
            else if(textBoxMaName.TextLength > 50)
            {
                MessageBox.Show("メーカー名は50文字以内です");
                return;
            }
            if (String.IsNullOrEmpty(textBoxMaAddress.Text.Trim()))
            {
                MessageBox.Show("住所を入力してください");
                return;
            }
            else if(textBoxMaAddress.TextLength > 50)
            {
                MessageBox.Show("住所は50文字以内です");
                return;
            }
            if (String.IsNullOrEmpty(textBoxPhone.Text.Trim()))
            {
                MessageBox.Show("電話番号を入力してください");
                return;
            }
            else if(textBoxPhone.TextLength > 13)
            {
                MessageBox.Show("電話番号は13文字以内です");
                return; 
            }

            var context = new PriceCompareSystemContext();
            int count = context.M_Makers.Where(x => x.MaName == textBoxMaName.Text).Count();
            if(count >= 1)
            {
                MessageBox.Show("入力されたメーカー名は既に使用されています");
                return;
            }

            var maker = new M_Makers
            {
                MaName = textBoxMaName.Text.Trim(),
                MaAddress = textBoxMaAddress.Text.Trim(),
                MaPhone = textBoxPhone.Text.Trim()
            };

            try
            {
                DialogResult result = MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                context.M_Makers.Add(maker);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                AllClear();
                MessageBox.Show("登録完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labelMaID.Text))
            {
                MessageBox.Show("更新したい項目を選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxMaName.Text.Trim()))
            {
                MessageBox.Show("メーカー名を入力してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxMaAddress.Text.Trim()))
            {
                MessageBox.Show("住所を入力してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxPhone.Text.Trim()))
            {
                MessageBox.Show("電話番号を入力してください");
                return;
            }

            var context = new PriceCompareSystemContext();

            try
            {
                DialogResult result = MessageBox.Show("更新してもよろしいですか？", "更新確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                int maid = int.Parse(labelMaID.Text);
                var maker = context.M_Makers.Single(x => x.MaID == maid);
                maker.MaName = textBoxMaName.Text.Trim();
                maker.MaAddress = textBoxMaAddress.Text.Trim();
                maker.MaPhone = textBoxPhone.Text.Trim();
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                AllClear(); 
                MessageBox.Show("更新完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labelMaID.Text))
            {
                MessageBox.Show("削除したい項目を選択してください");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                int maid = int.Parse(labelMaID.Text.Trim());
                var context = new PriceCompareSystemContext();
                var maker = context.M_Makers.Single(x => x.MaID == maid);
                context.M_Makers.Remove(maker);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                AllClear();
                MessageBox.Show("削除完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_Maker_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 4;

            dataGridViewDsp.Columns[0].Width = 70;
            dataGridViewDsp.Columns[0].HeaderText = "メーカーID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "メーカー名";
            dataGridViewDsp.Columns[2].Width = 250;
            dataGridViewDsp.Columns[2].HeaderText = "住所";
            dataGridViewDsp.Columns[3].Width = 150;
            dataGridViewDsp.Columns[3].HeaderText = "電話番号";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelMaID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxMaName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxMaAddress.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

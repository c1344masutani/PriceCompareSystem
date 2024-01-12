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
    public partial class F_MajorGenre : Form
    {
        public F_MajorGenre()
        {
            InitializeComponent();
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new PriceCompareSystemContext();
                foreach (var p in context.M_MajorGenres)
                {
                    dataGridViewDsp.Rows.Add(p.MgID,p.MgName);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_MajorGenre_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 2;

            dataGridViewDsp.Columns[0].Width = 70;
            dataGridViewDsp.Columns[0].HeaderText = "大ジャンルID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "大ジャンル名";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();
        }

        private void buttonRegester_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMgName.Text.Trim()))
            {
                MessageBox.Show("大ジャンル名を入力してください");
                return;
            }
            else if (textBoxMgName.TextLength > 50)
            {
                MessageBox.Show("大ジャンル名は50文字以内です");
                return;
            }

            var majorgenre = new M_MajorGenre
            {
                MgName = textBoxMgName.Text.Trim()
            };

            var context = new PriceCompareSystemContext();
            int count = context.M_MajorGenres.Where(x => x.MgName == textBoxMgName.Text).Count();
            if (count >= 1)
            {
                MessageBox.Show("入力された大ジャンル名は既に使用されています");
                return;
            }

            try
            {
                context.M_MajorGenres.Add(majorgenre);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                MessageBox.Show("登録完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labelMgID.Text.Trim()))
            {
                MessageBox.Show("更新したい項目を選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxMgName.Text.Trim()))
            {
                MessageBox.Show("大ジャンル名を入力してください");
                return;
            }
            else if (textBoxMgName.TextLength > 50)
            {
                MessageBox.Show("大ジャンル名は50文字以内です");
                return;
            }

            var context = new PriceCompareSystemContext();
            int count = context.M_MajorGenres.Where(x => x.MgName == textBoxMgName.Text).Count();
            if (count >= 1)
            {
                MessageBox.Show("入力された大ジャンル名は既に使用されています");
                return;
            }

            try
            {
                int mgid = int.Parse(labelMgID.Text.Trim());
                var majorgenre = context.M_MajorGenres.Single(x => x.MgID == mgid);
                majorgenre.MgName = textBoxMgName.Text.Trim();
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                MessageBox.Show("更新完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labelMgID.Text.Trim()))
            {
                MessageBox.Show("更新したい項目を選択してください");
                return;
            }
            try
            {
                int mgid = int.Parse(labelMgID.Text.Trim());
                var context = new PriceCompareSystemContext();
                var majorgenre = context.M_MajorGenres.Single(x => x.MgID == mgid);
                context.M_MajorGenres.Remove(majorgenre);
                context.SaveChanges();
                context.Dispose();
                fncAllSelect();
                MessageBox.Show("削除完了");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelMgID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxMgName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
        }
    }
}

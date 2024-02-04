using PriceCompareSystem.DbAccess;
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
    public partial class F_Genre : Form
    {
        //大ジャンルコンボボックス用
        MajorGenreDataAccess majorGenreDataAccess = new MajorGenreDataAccess();
        private static List<M_MajorGenres> MajorGenre;

        public F_Genre()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetFormCombBox()
        {
            //大ジャンルコンボボックス
            MajorGenre = majorGenreDataAccess.GetMajorGenreDspData();
            comboBoxMajorGenre.DataSource = MajorGenre;
            comboBoxMajorGenre.DisplayMember = "MgName";
            comboBoxMajorGenre.ValueMember = "MgID";
            comboBoxMajorGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMajorGenre.SelectedIndex = -1;
        }

        private void AllClear()
        {
            labelGeID.Text = "";
            comboBoxMajorGenre.SelectedIndex = -1;
            textBoxGeName.Text = "";
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new PriceCompareSystemContext();
                var tb = from t1 in context.M_MajorGenres
                         join t2 in context.M_SmallGenres
                         on t1.MgID equals t2.MgID
                         select new
                         {
                             t2.SgID,
                             t1.MgName,
                             t2.SgName
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SgID, p.MgName,p.SgName);
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
            if(comboBoxMajorGenre.SelectedIndex == -1)
            {
                MessageBox.Show("大ジャンルを選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxGeName.Text.Trim()))
            {
                MessageBox.Show("ジャンル名を入力してください");
                return;
            }
            else if(textBoxGeName.TextLength > 50)
            {
                MessageBox.Show("ジャンル名は50文字以内です");
                return;
            }

            var context = new PriceCompareSystemContext();
            int count = context.M_SmallGenres.Where(x => x.SgName == textBoxGeName.Text).Count();
            if(count >= 1)
            {
                MessageBox.Show("入力されたジャンル名は既に使用されています");
                return;
            }

            var genre = new M_SmallGenres
            {
                MgID = int.Parse(comboBoxMajorGenre.SelectedValue.ToString()),
                SgName = textBoxGeName.Text.Trim()
            };

            try
            {
                DialogResult result = MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                context.M_SmallGenres.Add(genre);
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
            if (String.IsNullOrEmpty(labelGeID.Text.Trim()))
            {
                MessageBox.Show("更新したい項目を選択してください");
                return;
            }
            if (comboBoxMajorGenre.SelectedIndex == -1)
            {
                MessageBox.Show("大ジャンルを選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxGeName.Text.Trim()))
            {
                MessageBox.Show("ジャンル名を入力してください");
                return; 
            }
            else if (textBoxGeName.TextLength > 50)
            {
                MessageBox.Show("ジャンル名は50文字以内です");
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
                int sgid = int.Parse(labelGeID.Text);
                var genre = context.M_SmallGenres.Single(x => x.SgID == sgid);
                genre.MgID = int.Parse(comboBoxMajorGenre.SelectedValue.ToString());
                genre.SgName = textBoxGeName.Text.Trim();
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
            if (String.IsNullOrEmpty(labelGeID.Text))
            {
                MessageBox.Show("削除する項目を選択してください");
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                int sgid = int.Parse(labelGeID.Text);
                var context = new PriceCompareSystemContext();
                var genre = context.M_SmallGenres.Single(x => x.SgID == sgid);
                context.M_SmallGenres.Remove(genre);
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

        private void F_Genre_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 3;

            dataGridViewDsp.Columns[0].Width = 70;
            dataGridViewDsp.Columns[0].HeaderText = "ジャンルID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "大ジャンル名";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "小ジャンル名";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();
            SetFormCombBox();
        }

        private void buttonMajorGenre_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_MajorGenre f_MajorGenre = new F_MajorGenre();
            f_MajorGenre.ShowDialog();
            f_MajorGenre.Dispose();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGeID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxMajorGenre.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxGeName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            AllClear();
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

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
    public partial class F_Product : Form
    {
        //メーカーコンボボックス用
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        private static List<M_Maker> Maker;

        //大ジャンルコンボボックス用
        MajorGenreDataAccess majorGenreDataAccess = new MajorGenreDataAccess();
        private static List<M_MajorGenre> MajorGenre;

        //小ジャンルコンボボックス用
        SmallGenreDataAccess smallGenreDataAccess = new SmallGenreDataAccess();
        private static List<M_SmallGenre> SmallGenre;

        public F_Product()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AllClear()
        {
            labelPrID.Text = "";
            comboBoxMaker.SelectedIndex = -1;
            textBoxPrName.Text = "";
            textBoxPrPrice.Text = "";
            comboBoxMajorGenre.SelectedIndex = -1;
            comboBoxSmallGenre.SelectedIndex = -1;
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new PriceCompareSystemContext();
                var tb = from t1 in context.M_Products
                         join t2 in context.M_Makers
                         on t1.MaID equals t2.MaID
                         join t3 in context.M_MajorGenres
                         on t1.MgID equals t3.MgID
                         join t4 in context.M_SmallGenres
                         on t1.SgID equals t4.SgID
                         select new
                         {
                             t1.PrID,
                             t2.MaName,
                             t1.PrName,
                             t1.Price,
                             t3.MgName,
                             t4.SgName
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.PrID, p.MaName, p.PrName, p.Price,p.MgName,p.SgName);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFormCombBox()
        {
            //メーカーコンボボックス
            Maker = makerDataAccess.GetMakerDspData();
            comboBoxMaker.DataSource = Maker;
            comboBoxMaker.DisplayMember = "MaName";
            comboBoxMaker.ValueMember = "MaID";
            comboBoxMaker.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaker.SelectedIndex = -1;

            //大ジャンルコンボボックス
            MajorGenre = majorGenreDataAccess.GetMajorGenreDspData();
            comboBoxMajorGenre.DataSource = MajorGenre;
            comboBoxMajorGenre.DisplayMember = "MgName";
            comboBoxMajorGenre.ValueMember = "MgID";
            comboBoxMajorGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMajorGenre.SelectedIndex = -1;

            //小ジャンルコンボボックス(初期状態)
            int? mgid = null;
            if (comboBoxMajorGenre.SelectedIndex == -1)
            {
                SmallGenre = smallGenreDataAccess.GetSmallGenreDspData(mgid);
                comboBoxSmallGenre.DataSource = SmallGenre;
                comboBoxSmallGenre.DisplayMember = "SgName";
                comboBoxSmallGenre.ValueMember = "SgID";
                comboBoxSmallGenre.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxSmallGenre.SelectedIndex = -1;
            }
        }

        private void F_Product_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 6;

            dataGridViewDsp.Columns[0].Width = 70;
            dataGridViewDsp.Columns[0].HeaderText = "商品ID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "メーカー名";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "商品名";
            dataGridViewDsp.Columns[3].Width = 100;
            dataGridViewDsp.Columns[3].HeaderText = "希望小売価格";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "大ジャンル";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "小ジャンル";
            //選択モードを行単位.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();

            SetFormCombBox();
        }

        private void buttonRegester_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPrName.Text.Trim()))
            {
                MessageBox.Show("商品名を入力してください");
                return;
            }
            else if(textBoxPrName.TextLength > 50)
            {
                MessageBox.Show("商品名は50文字以内です");
                return;
            }
            if(comboBoxMaker.SelectedIndex == -1)
            {
                MessageBox.Show("メーカーを選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxPrPrice.Text.Trim()))
            {
                MessageBox.Show("希望小売価格を入力してください");
                return;
            }

            string s = textBoxPrPrice.Text;
            int i;
            bool numeric = int.TryParse(s, out i);
            if (numeric == false)
            {
                MessageBox.Show("希望小売価格は数字で入力してください");
                return;
            }

            if (comboBoxMajorGenre.SelectedIndex == -1)
            {
                MessageBox.Show("大ジャンルを選択してください");
                return;
            }
            if(comboBoxSmallGenre.SelectedIndex == -1)
            {
                MessageBox.Show("小ジャンルを選択してください");
                return;
            }

            var context = new PriceCompareSystemContext();
            int count = context.M_Products.Where(x => x.PrName == textBoxPrName.Text).Count();
            if(count >= 1)
            {
                MessageBox.Show("入力された商品名は既に登録されています");
                return;
            }

            var product = new M_Product
            {
                PrName = textBoxPrName.Text.Trim(),
                MaID = int.Parse(comboBoxMaker.SelectedValue.ToString()),
                Price = int.Parse(textBoxPrPrice.Text.Trim()),
                MgID = int.Parse(comboBoxMajorGenre.SelectedValue.ToString()),
                SgID = int.Parse(comboBoxSmallGenre.SelectedValue.ToString())
            };

            try
            {
                DialogResult result = MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                context.M_Products.Add(product);
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
            if (String.IsNullOrEmpty(labelPrID.Text.Trim()))
            {
                MessageBox.Show("更新したい項目を選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxPrName.Text.Trim()))
            {
                MessageBox.Show("商品名を入力してください");
                return;
            }
            else if(textBoxPrName.TextLength > 50)
            {
                MessageBox.Show("商品名は50文字以内です");
                return;
            }
            if (comboBoxMaker.SelectedIndex == -1)
            {
                MessageBox.Show("メーカーを選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxPrPrice.Text.Trim()))
            {
                MessageBox.Show("希望小売価格を入力してください");
                return;
            }

            string s = textBoxPrPrice.Text;
            int i;
            bool numeric = int.TryParse(s, out i);
            if (numeric == false)
            {
                MessageBox.Show("希望小売価格は数字で入力してください");
                return;
            }

            if (comboBoxMajorGenre.SelectedIndex == -1)
            {
                MessageBox.Show("大ジャンルを選択してください");
                return;
            }
            if (comboBoxSmallGenre.SelectedIndex == -1)
            {
                MessageBox.Show("小ジャンルを選択してください");
                return;
            }

            var context = new PriceCompareSystemContext();
            int count = context.M_Products.Where(x => x.PrName == textBoxPrName.Text).Count();

            try
            {
                DialogResult result = MessageBox.Show("更新してもよろしいですか？", "更新確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                int prid = int.Parse(labelPrID.Text.Trim());
                var product = context.M_Products.Single(x => x.PrID == prid);
                product.PrName = textBoxPrName.Text.Trim();
                product.MaID = int.Parse(comboBoxMaker.SelectedValue.ToString());
                product.Price = int.Parse(textBoxPrPrice.Text.Trim());
                product.MgID = int.Parse(comboBoxMajorGenre.SelectedValue.ToString());
                product.SgID = int.Parse(comboBoxSmallGenre.SelectedValue.ToString());
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
            if (String.IsNullOrEmpty(labelPrID.Text.Trim()))
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
                int prid = int.Parse(labelPrID.Text.Trim());
                var context = new PriceCompareSystemContext();
                var product = context.M_Products.Single(x => x.PrID == prid);
                context.M_Products.Remove(product);
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

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelPrID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            comboBoxMaker.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            textBoxPrName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxPrPrice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            comboBoxMajorGenre.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
            comboBoxSmallGenre.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void comboBoxSmallGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMajorGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxMajorGenre.SelectedIndex != -1)
            {
                //小ジャンルコンボボックス
                int mgid = int.Parse(comboBoxMajorGenre.SelectedValue.ToString());

                SmallGenre = smallGenreDataAccess.GetSmallGenreDspData(mgid);
                comboBoxSmallGenre.DataSource = SmallGenre;
                comboBoxSmallGenre.DisplayMember = "SgName";
                comboBoxSmallGenre.ValueMember = "SgID";
                comboBoxSmallGenre.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxSmallGenre.SelectedIndex = -1;
            }
        }

        private void dataGridViewDsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

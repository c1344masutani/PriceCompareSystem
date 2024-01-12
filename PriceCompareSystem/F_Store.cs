using PriceCompareSystem.DbAccess;
using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem
{
    public partial class F_Store : Form
    {
        //都道府県コンボボックス用
        PrefectureDataAccess prefectureDataAccess = new PrefectureDataAccess();
        private static List<M_Prefecture> Prefecture;

        public F_Store()
        {
            InitializeComponent();
        }

        private void SetFormCombBox()
        {
            //都道府県コンボボックス
            comboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegion.SelectedIndex = -1;
            int region = comboBoxRegion.SelectedIndex;
            Prefecture = prefectureDataAccess.GetPrefectureDspData(region);
            comboBoxPrefectures.DataSource = Prefecture;
            comboBoxPrefectures.DisplayMember = "PfName";
            comboBoxPrefectures.ValueMember = "PfID";
            comboBoxPrefectures.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrefectures.SelectedIndex = -1;
            
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            try
            {
                var context = new PriceCompareSystemContext();
                var tb = from t1 in context.M_Stores
                         join t2 in context.M_Prefectures
                         on t1.Prefectures equals t2.PfID
                         select new
                         {
                             t1.StID,
                             t1.StName,
                             t2.PfName,
                             t1.StAddress,
                             t1.StPhone
                         };
                foreach(var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.StID, p.StName, p.PfName, p.StAddress, p.StPhone);
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
            if (String.IsNullOrEmpty(textBoxStName.Text.Trim()))
            {
                MessageBox.Show("店舗名を入力してください");
                return;
            }
            else if(textBoxStName.TextLength > 50)
            {
                MessageBox.Show("店舗名は50文字以内です");
                return;
            }
            if(comboBoxPrefectures.SelectedIndex == -1)
            {
                MessageBox.Show("都道府県を選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxAddress.Text.Trim()))
            {
                MessageBox.Show("住所を入力してください");
                return;
            }
            else if(textBoxAddress.TextLength > 50)
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
            if (String.IsNullOrEmpty(textBoxPassWord.Text.Trim()))
            {
                MessageBox.Show("パスワードを入力してください");
                return;
            }
            else if(textBoxPassWord.TextLength > 50)
            {
                MessageBox.Show("パスワードは50文字以内です");
                return;
            }

            var context = new PriceCompareSystemContext();
            int count = context.M_Stores.Where(x => x.StName == textBoxStName.Text).Count();
            if(count >= 1)
            {
                MessageBox.Show("入力された店舗名は既に使用されています");
                return;
            }

            var store = new M_Store
            {
                StName = textBoxStName.Text.Trim(),
                Prefectures = int.Parse(comboBoxPrefectures.SelectedValue.ToString()),
                StAddress = textBoxAddress.Text.Trim(),
                StPhone = textBoxPhone.Text.Trim(),
                StPassWord = textBoxPassWord.Text.Trim()
            };

            try
            {
                context.M_Stores.Add(store);
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

        private void F_Store_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 5;

            dataGridViewDsp.Columns[0].Width = 70;
            dataGridViewDsp.Columns[0].HeaderText = "店舗ID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "店舗名";
            dataGridViewDsp.Columns[2].Width = 80;
            dataGridViewDsp.Columns[2].HeaderText = "都道府県";
            dataGridViewDsp.Columns[3].Width = 130;
            dataGridViewDsp.Columns[3].HeaderText = "住所";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "電話番号";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();

            SetFormCombBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStName.Text.Trim()))
            {
                MessageBox.Show("店舗名を入力してください");
                return;
            }
            else if (textBoxStName.TextLength > 50)
            {
                MessageBox.Show("店舗名は50文字以内です");
                return;
            }
            if (comboBoxPrefectures.SelectedIndex == -1)
            {
                MessageBox.Show("都道府県を選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxAddress.Text.Trim()))
            {
                MessageBox.Show("住所を入力してください");
                return;
            }
            else if (textBoxAddress.TextLength > 50)
            {
                MessageBox.Show("住所は50文字以内です");
                return;
            }
            if (String.IsNullOrEmpty(textBoxPhone.Text.Trim()))
            {
                MessageBox.Show("電話番号を入力してください");
                return;
            }
            else if (textBoxPhone.TextLength > 13)
            {
                MessageBox.Show("電話番号は13文字以内です");
                return;
            }
            if (String.IsNullOrEmpty(textBoxPassWord.Text.Trim()))
            {
                MessageBox.Show("パスワードを入力してください");
                return;
            }
            else if (textBoxPassWord.TextLength > 50)
            {
                MessageBox.Show("パスワードは50文字以内です");
                return;
            }

            var context = new PriceCompareSystemContext();
            int count = context.M_Stores.Where(x => x.StName == textBoxStName.Text).Count();
            if (count >= 1)
            {
                MessageBox.Show("入力された店舗名は既に使用されています");
                return;
            }

            try
            {
                int stid = int.Parse(labelStID.Text.Trim());
                var store = context.M_Stores.Single(x => x.StID == stid);
                store.StName = textBoxStName.Text.Trim();
                store.Prefectures = int.Parse(comboBoxPrefectures.SelectedValue.ToString());
                store.StAddress = textBoxAddress.Text.Trim();
                store.StPhone = textBoxPhone.Text.Trim();
                store.StPassWord = textBoxPassWord.Text.Trim();
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
            if (String.IsNullOrEmpty(labelStID.Text.Trim()))
            {
                MessageBox.Show("削除したい項目を選択してください");
                return;
            }
            try
            {
                int stid = int.Parse(labelStID.Text.Trim());
                var context = new PriceCompareSystemContext();
                var store = context.M_Stores.Single(x => x.StID == stid);
                context.M_Stores.Remove(store);
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
            labelStID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            textBoxStName.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            comboBoxPrefectures.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void comboBoxRegion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //都道府県コンボボックス
            int region = comboBoxRegion.SelectedIndex;
            Prefecture = prefectureDataAccess.GetPrefectureDspData(region);
            comboBoxPrefectures.DataSource = Prefecture;
            comboBoxPrefectures.DisplayMember = "PfName";
            comboBoxPrefectures.ValueMember = "PfID";
            comboBoxPrefectures.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrefectures.SelectedIndex = -1;
        }
    }
}

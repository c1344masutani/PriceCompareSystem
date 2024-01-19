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
    public partial class F_EasySearch : Form
    {
        //都道府県コンボボックス用
        PrefectureDataAccess prefectureDataAccess = new PrefectureDataAccess();
        private static List<M_Prefecture> Prefecture;

        public F_EasySearch()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SetFormCombBox()
        {
            //都道府県コンボボックス
            int region = comboBoxRegion.SelectedIndex;
            comboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegion.SelectedIndex = -1;
            Prefecture = prefectureDataAccess.GetPrefectureDspData(region);
            comboBoxPrefectures.DataSource = Prefecture;
            comboBoxPrefectures.DisplayMember = "PfName";
            comboBoxPrefectures.ValueMember = "PfID";
            comboBoxPrefectures.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrefectures.SelectedIndex = -1;
        }

        private void InputClear()
        {
            textBoxKewWord.Text = "";
            comboBoxRegion.SelectedIndex = -1;
            comboBoxPrefectures.SelectedIndex = -1;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string kewword = string.Empty;
            string pfid = string.Empty;

            if(comboBoxPrefectures.SelectedIndex != -1)
            {
                pfid = comboBoxPrefectures.SelectedValue.ToString();
            }

            if (!String.IsNullOrEmpty(textBoxKewWord.Text.Trim()))
            {
                kewword = textBoxKewWord.Text.Trim();
            }

            try
            {
                var context = new PriceCompareSystemContext();
                var tb = from t1 in context.M_PriceLists
                         join t2 in context.M_Products
                         on t1.PrID equals t2.PrID
                         join t3 in context.M_Makers
                         on t1.MaID equals t3.MaID
                         join t4 in context.M_SmallGenres
                         on t1.GeID equals t4.SgID
                         join t5 in context.M_Prefectures
                         on t1.PfID equals t5.PfID
                         join t6 in context.M_Stores
                         on t1.StID equals t6.StID
                         orderby t1.Price, t2.PrName
                         where t1.PfID.ToString().Contains(pfid) &&
                               t2.PrName.Contains(kewword)
                         select new
                         {
                             t4.SgName,
                             t3.MaName,
                             t2.PrName,
                             t1.Price,
                             t6.StName,
                             t5.PfName
                         };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SgName, p.MaName, p.PrName, p.Price, p.StName, p.PfName);
                }
                
                tb = from t1 in context.M_PriceLists
                     join t2 in context.M_Products
                     on t1.PrID equals t2.PrID
                     join t3 in context.M_Makers
                     on t1.MaID equals t3.MaID
                     join t4 in context.M_SmallGenres
                     on t1.GeID equals t4.SgID
                     join t5 in context.M_Prefectures
                     on t1.PfID equals t5.PfID
                     join t6 in context.M_Stores
                     on t1.StID equals t6.StID
                     orderby t1.Price, t2.PrName
                     where t1.PfID.ToString().Contains(pfid) &&
                           t3.MaName.Contains(kewword)
                     select new
                     {
                         t4.SgName,
                         t3.MaName,
                         t2.PrName,
                         t1.Price,
                         t6.StName,
                         t5.PfName
                     };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SgName, p.MaName, p.PrName, p.Price, p.StName, p.PfName);
                }

                tb = from t1 in context.M_PriceLists
                     join t2 in context.M_Products
                     on t1.PrID equals t2.PrID
                     join t3 in context.M_Makers
                     on t1.MaID equals t3.MaID
                     join t4 in context.M_SmallGenres
                     on t1.GeID equals t4.SgID
                     join t5 in context.M_Prefectures
                     on t1.PfID equals t5.PfID
                     join t6 in context.M_Stores
                     on t1.StID equals t6.StID
                     orderby t1.Price, t2.PrName
                     where t1.PfID.ToString().Contains(pfid) &&
                           t4.SgName.Contains(kewword)
                     select new
                     {
                         t4.SgName,
                         t3.MaName,
                         t2.PrName,
                         t1.Price,
                         t6.StName,
                         t5.PfName
                     };
                foreach (var p in tb)
                {
                    dataGridViewDsp.Rows.Add(p.SgName, p.MaName, p.PrName, p.Price, p.StName, p.PfName);
                }

                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //価格で昇順に並び替え
            if(dataGridViewDsp.CurrentCell != null)
            {
                dataGridViewDsp.Sort(dataGridViewDsp.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                dataGridViewDsp.CurrentCell = dataGridViewDsp[0, 0];
            }
        }

        private void F_EasySearch_Load(object sender, EventArgs e)
        {
            //列数の指定
            dataGridViewDsp.ColumnCount = 6;

            dataGridViewDsp.Columns[0].Width = 80;
            dataGridViewDsp.Columns[0].HeaderText = "ジャンル";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "メーカー";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "商品名";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "価格";
            dataGridViewDsp.Columns[4].Width = 130;
            dataGridViewDsp.Columns[4].HeaderText = "店舗名";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "都道府県";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            SetFormCombBox();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                F_Result.genre = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
                F_Result.maker = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
                F_Result.product = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
                F_Result.price = int.Parse(dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString());
                F_Result.store = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
                F_Result.prefectures = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[5].Value.ToString();
                F_Result f_Result = new F_Result();
                f_Result.ShowDialog();
            }
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

        private void buttonSearchForm_Click(object sender, EventArgs e)
        {
            F_Serach f_Serach = new F_Serach();
            f_Serach.ShowDialog();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            InputClear();
        }
    }
}

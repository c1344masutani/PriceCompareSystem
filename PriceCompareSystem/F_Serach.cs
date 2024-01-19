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
    public partial class F_Serach : Form
    {
        //大ジャンルコンボボックス用
        MajorGenreDataAccess majorGenreDataAccess = new MajorGenreDataAccess();
        private static List<M_MajorGenre> MajorGenre;

        //小ジャンルコンボボックス用
        SmallGenreDataAccess smallGenreDataAccess = new SmallGenreDataAccess();
        private static List<M_SmallGenre> SmallGenre;

        //メーカーコンボボックス用
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        private static List<M_Maker> Maker;


        //商品コンボボックス用
        ProductDataAccess productDataAccess = new ProductDataAccess();
        private static List<M_Product> Product;

        //都道府県コンボボックス用
        PrefectureDataAccess prefectureDataAccess = new PrefectureDataAccess();
        private static List<M_Prefecture> Prefecture;

        public F_Serach()
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

            //メーカーコンボボックス
            Maker = makerDataAccess.GetMakerDspData();
            comboBoxMaker.DataSource = Maker;
            comboBoxMaker.DisplayMember = "MaName";
            comboBoxMaker.ValueMember = "MaID";
            comboBoxMaker.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaker.SelectedIndex = -1;

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

            //商品コンボボックス(初期状態)
            int? sgid = null;
            int? maid = null;
            if (comboBoxSmallGenre.SelectedIndex == -1 && comboBoxMaker.SelectedIndex == -1)
            {
                Product = productDataAccess.GetProductDspData(mgid, sgid, maid);
                comboBoxProduct.DataSource = Product;
                comboBoxProduct.DisplayMember = "PrName";
                comboBoxProduct.ValueMember = "PrID";
                comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxProduct.SelectedIndex = -1;
            }
        }

        private void InputClear()
        {
            comboBoxMaker.SelectedIndex = -1;
            comboBoxProduct.SelectedIndex = -1;
            comboBoxMajorGenre.SelectedIndex = -1;
            comboBoxSmallGenre.SelectedIndex = -1;
            comboBoxRegion.SelectedIndex = -1;
            comboBoxPrefectures.SelectedIndex = -1;
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            F_Product f_Product = new F_Product();
            f_Product.ShowDialog();
        }

        private void buttonMaker_Click(object sender, EventArgs e)
        {
            F_Maker f_Maker = new F_Maker();
            f_Maker.ShowDialog();
        }

        private void F_Serach_Load(object sender, EventArgs e)
        {
            InputClear();

            //列数の指定
            dataGridViewDsp.ColumnCount = 6;

            dataGridViewDsp.Columns[0].Width = 130;
            dataGridViewDsp.Columns[0].HeaderText = "ジャンル";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "メーカー";
            dataGridViewDsp.Columns[2].Width = 200;
            dataGridViewDsp.Columns[2].HeaderText = "商品名";
            dataGridViewDsp.Columns[3].Width = 70;
            dataGridViewDsp.Columns[3].HeaderText = "価格";
            dataGridViewDsp.Columns[4].Width = 150;
            dataGridViewDsp.Columns[4].HeaderText = "店舗名";
            dataGridViewDsp.Columns[5].Width = 130;
            dataGridViewDsp.Columns[5].HeaderText = "都道府県";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            SetFormCombBox();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewDsp.Rows.Clear();
            string prid = string.Empty;
            string maid = string.Empty;
            string geid　=string.Empty;
            string pfid = string.Empty;

            if (comboBoxProduct.SelectedIndex != -1)
            {
                prid = comboBoxProduct.SelectedValue.ToString();
            }
            if(comboBoxMaker.SelectedIndex != -1)
            {
                maid = comboBoxMaker.SelectedValue.ToString();
            }
            if (comboBoxSmallGenre.SelectedIndex != -1)
            {
                geid = comboBoxSmallGenre.SelectedValue.ToString();
            }
            if(comboBoxPrefectures.SelectedIndex != -1)
            {
                pfid = comboBoxPrefectures.SelectedValue.ToString();
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
                         orderby t1.Price ,t2.PrName
                         where t1.PrID.ToString() == prid ||
                               t1.MaID.ToString() == maid ||
                               t1.PrID.ToString() == prid ||
                               t1.GeID.ToString() == geid ||
                               t1.PfID.ToString() == pfid
                         select new
                         {
                             t4.SgName,
                             t3.MaName,
                             t2.PrName,
                             t1.Price,
                             t6.StName,
                             t5.PfName
                         };
                foreach(var p in tb)
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
            if (dataGridViewDsp.CurrentCell != null)
            {
                dataGridViewDsp.Sort(dataGridViewDsp.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
                dataGridViewDsp.CurrentCell = dataGridViewDsp[0, 0];
            }
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            F_Store f_Store = new F_Store();
            f_Store.ShowDialog();
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            F_Genre f_Genre = new F_Genre();
            f_Genre.ShowDialog();
        }

        private void buttonPriceList_Click(object sender, EventArgs e)
        {
            F_PriceList f_PriceList = new F_PriceList();
            f_PriceList.ShowDialog();
        }

        private void comboBoxGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMaker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxMaker.SelectedIndex != -1)
            {
                //商品コンボボックス
                int maid = int.Parse(comboBoxMaker.SelectedValue.ToString());
                int? mgid = null;
                int? sgid = null;
                if (comboBoxMajorGenre.SelectedIndex != -1)
                {
                    mgid = int.Parse(comboBoxMajorGenre.SelectedValue.ToString());

                    if (comboBoxSmallGenre.SelectedIndex != -1)
                    {
                        sgid = int.Parse(comboBoxSmallGenre.SelectedValue.ToString());
                    }
                }
                Product = productDataAccess.GetProductDspData(mgid, sgid, maid);
                comboBoxProduct.DataSource = Product;
                comboBoxProduct.DisplayMember = "PrName";
                comboBoxProduct.ValueMember = "PrID";
                comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxProduct.SelectedIndex = -1;
            }
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

        private void comboBoxSmallGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxSmallGenre.SelectedIndex != -1)
            {
                //商品コンボボックス
                int? mgid = null;
                if(comboBoxMajorGenre.SelectedIndex != -1)
                {
                    mgid = int.Parse(comboBoxMajorGenre.SelectedValue.ToString());
                }
                int sgid = int.Parse(comboBoxSmallGenre.SelectedValue.ToString());
                int? maid = null;
                if (comboBoxMaker.SelectedIndex != -1)
                {
                    maid = int.Parse(comboBoxMaker.SelectedValue.ToString());
                }
                Product = productDataAccess.GetProductDspData(mgid, sgid, maid);
                comboBoxProduct.DataSource = Product;
                comboBoxProduct.DisplayMember = "PrName";
                comboBoxProduct.ValueMember = "PrID";
                comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxProduct.SelectedIndex = -1;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            InputClear();
        }

        private void labelPrefectures_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPrefectures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEasySearch_Click(object sender, EventArgs e)
        {
            F_EasySearch f_EasySearch = new F_EasySearch();
            f_EasySearch.ShowDialog();
        }

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
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
    }
}

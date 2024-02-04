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
        private static List<M_MajorGenres> MajorGenre;

        //小ジャンルコンボボックス用
        SmallGenreDataAccess smallGenreDataAccess = new SmallGenreDataAccess();
        private static List<M_SmallGenres> SmallGenre;

        //メーカーコンボボックス用
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        private static List<M_Makers> Maker;


        //商品コンボボックス用
        ProductDataAccess productDataAccess = new ProductDataAccess();
        private static List<M_Products> Product;

        //都道府県コンボボックス用
        PrefectureDataAccess prefectureDataAccess = new PrefectureDataAccess();
        private static List<M_Prefectures> Prefecture;

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
            SetFormCombBox();
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
            string mgid = string.Empty;
            string geid　=string.Empty;
            string pfid = string.Empty;
            string region = string.Empty;

            if (comboBoxProduct.SelectedIndex != -1)
            {
                prid = comboBoxProduct.SelectedValue.ToString();
            }
            if(comboBoxMaker.SelectedIndex != -1)
            {
                maid = comboBoxMaker.SelectedValue.ToString();
            }
            if(comboBoxMajorGenre.SelectedIndex != -1)
            {
                mgid = comboBoxMajorGenre.SelectedValue.ToString();
            }
            if (comboBoxSmallGenre.SelectedIndex != -1)
            {
                geid = comboBoxSmallGenre.SelectedValue.ToString();
            }
            if(comboBoxPrefectures.SelectedIndex != -1)
            {
                pfid = comboBoxPrefectures.SelectedValue.ToString();
            }
            if(comboBoxRegion.SelectedIndex != -1)
            {
                region = comboBoxRegion.SelectedIndex.ToString();
            }

            try
            {
                var context = new PriceCompareSystemContext();
                //商品が選択時(都道府県選択時)
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
                         join t7 in context.M_MajorGenres
                         on t1.MgID equals t7.MgID
                         orderby t1.Price, t2.PrName
                         where t1.PrID.ToString() == prid &&
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
                //商品選択時(都道府県未選択)
                if(comboBoxProduct.SelectedIndex != -1 && comboBoxPrefectures.SelectedIndex == -1)
                {
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
                         join t7 in context.M_MajorGenres
                         on t1.MgID equals t7.MgID
                         orderby t1.Price, t2.PrName
                         where t1.PrID.ToString() == prid &&
                               t5.region.ToString() == region
                         select new
                         {
                             t4.SgName,
                             t3.MaName,
                             t2.PrName,
                             t1.Price,
                             t6.StName,
                             t5.PfName
                         };
                }

                //メーカー、大ジャンル、小ジャンル選択時
                if(comboBoxMaker.SelectedIndex != -1 && comboBoxMajorGenre.SelectedIndex != -1 && comboBoxSmallGenre.SelectedIndex != -1)
                {
                    //都道府県選択時
                    if(comboBoxPrefectures.SelectedIndex != -1)
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.MaID.ToString() == maid &&
                                   t1.GeID.ToString() == geid &&
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
                    }
                    //都道府県未選択時
                    else
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.MaID.ToString() == maid &&
                                   t1.GeID.ToString() == geid &&
                                   t5.region.ToString() == region
                             select new
                             {
                                 t4.SgName,
                                 t3.MaName,
                                 t2.PrName,
                                 t1.Price,
                                 t6.StName,
                                 t5.PfName
                             };
                    }
                    
                }
                //メーカー、大ジャンル選択時
                else if(comboBoxMaker.SelectedIndex != -1 && comboBoxMajorGenre.SelectedIndex != -1)
                {
                    //都道府県選択時
                    if(comboBoxPrefectures.SelectedIndex != -1)
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.MaID.ToString() == maid &&
                                   t1.MgID.ToString() == mgid &&
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
                    }
                    //都道府県未選択時
                    else
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.MaID.ToString() == maid &&
                                   t1.MgID.ToString() == mgid &&
                                   t5.region.ToString() == region
                             select new
                             {
                                 t4.SgName,
                                 t3.MaName,
                                 t2.PrName,
                                 t1.Price,
                                 t6.StName,
                                 t5.PfName
                             };
                    }
                }
                //メーカーが選択時
                else if(comboBoxMaker.SelectedIndex != -1)
                {
                    //都道府県選択時
                    if(comboBoxPrefectures.SelectedIndex != -1)
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.MaID.ToString() == maid &&
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
                    }
                    //都道府県未選択時
                    else
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.MaID.ToString() == maid &&
                                   t5.region.ToString() == region
                             select new
                             {
                                 t4.SgName,
                                 t3.MaName,
                                 t2.PrName,
                                 t1.Price,
                                 t6.StName,
                                 t5.PfName
                             };
                    }
                }
                //小ジャンルが選択時
                else if(comboBoxSmallGenre.SelectedIndex != -1)
                {
                    //都道府県選択時
                    if(comboBoxPrefectures.SelectedIndex != -1)
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.GeID.ToString() == geid &&
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
                    }
                    //都道府県未選択時
                    else
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.GeID.ToString() == geid &&
                                   t5.region.ToString() == region
                             select new
                             {
                                 t4.SgName,
                                 t3.MaName,
                                 t2.PrName,
                                 t1.Price,
                                 t6.StName,
                                 t5.PfName
                             };
                    }
                }
                //大ジャンルが選択時
                else if(comboBoxMajorGenre.SelectedIndex != -1)
                {
                    //都道府県選択時
                    if(comboBoxPrefectures.SelectedIndex != -1)
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.MgID.ToString() == mgid &&
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
                    }
                    //都道府県未選択時
                    else
                    {
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
                             join t7 in context.M_MajorGenres
                             on t1.MgID equals t7.MgID
                             orderby t1.Price, t2.PrName
                             where t1.MgID.ToString() == mgid &&
                                   t5.region.ToString() == region
                             select new
                             {
                                 t4.SgName,
                                 t3.MaName,
                                 t2.PrName,
                                 t1.Price,
                                 t6.StName,
                                 t5.PfName
                             };
                    }
                }

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
            else
            {
                MessageBox.Show("検索結果：0件\n条件を変更してください");
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
            dataGridViewDsp.Rows.Clear();
        }

        private void labelPrefectures_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPrefectures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEasySearch_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_EasySearch f_EasySearch = new F_EasySearch();
            f_EasySearch.ShowDialog();
            f_EasySearch.Dispose(); 
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

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Menu f_Menu = new F_Menu();
            f_Menu.ShowDialog();
            f_Menu.Dispose();
        }

        private void comboBoxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedIndex != -1)
            {
                int prid = int.Parse(comboBoxProduct.SelectedValue.ToString());
                //メーカーが選択されていない時
                var context = new PriceCompareSystemContext();
                int maid = context.M_Products.Single(x => x.PrID == prid).MaID;
                string maname = context.M_Makers.Single(x => x.MaID == maid).MaName;
                comboBoxMaker.Text = maname;

                //大ジャンル、小ジャンルが選択されていない時
                int mgid = context.M_Products.Single(x => x.PrID == prid).MgID;
                string mgname = context.M_MajorGenres.Single(x => x.MgID == mgid).MgName;
                int sgid = context.M_Products.Single(x => x.PrID == prid).SgID;
                string sgname = context.M_SmallGenres.Single(x => x.SgID == sgid).SgName;
                comboBoxMajorGenre.Text = mgname;
                comboBoxSmallGenre.Text = sgname;
            }
        }
    }
}

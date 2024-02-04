using PriceCompareSystem.DbAccess;
using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem
{
    public partial class F_PriceList : Form
    {
        //ログインフォームから店舗情報継承用変数
        internal static string stid = "";
        internal static string stname = "";
        internal static string pfid = "";

        //大ジャンルコンボボックス用
        MajorGenreDataAccess majorGenreDataAccess = new MajorGenreDataAccess();
        private static List<M_MajorGenres> MajorGenre;

        //小ジャンルコンボボックス用
        SmallGenreDataAccess smallGenreDataAccess = new SmallGenreDataAccess();
        private static List<M_SmallGenres> SmallGenre;

        //商品コンボボックス用
        ProductDataAccess productDataAccess = new ProductDataAccess();
        private static List<M_Products> Product;

        //都道府県コンボボックス用
        PrefectureDataAccess prefectureDataAccess = new PrefectureDataAccess();
        private static List<M_Prefectures> Prefecture;

        //店舗コンボボックス用
        StoreDataAccess storeDataAccess = new StoreDataAccess();
        private static List<M_Stores> Store;

        //メーカーコンボボックス用
        MakerDataAccess makerDataAccess = new MakerDataAccess();
        private static List<M_Makers> Maker;

        public F_PriceList()
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


            //メーカーコンボボックス
            Maker = makerDataAccess.GetMakerDspData();
            comboBoxMaker.DataSource = Maker;
            comboBoxMaker.DisplayMember = "MaName";
            comboBoxMaker.ValueMember = "MaID";
            comboBoxMaker.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaker.SelectedIndex = -1;

            //商品コンボボックス(初期状態)
            int? mgid = null;
            int? sgid = null;
            int? maid = null;
            if(comboBoxMajorGenre.SelectedIndex == -1 && comboBoxSmallGenre.SelectedIndex == -1 && comboBoxMaker.SelectedIndex == -1)
            {
                Product = productDataAccess.GetProductDspData(mgid,sgid,maid);
                comboBoxProduct.DataSource = Product;
                comboBoxProduct.DisplayMember = "PrName";
                comboBoxProduct.ValueMember = "PrID";
                comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxProduct.SelectedIndex = -1;
            }

            //小ジャンルコンボボックス(初期状態)
            if(comboBoxMajorGenre.SelectedIndex == -1)
            {
                SmallGenre = smallGenreDataAccess.GetSmallGenreDspData(mgid);
                comboBoxSmallGenre.DataSource = SmallGenre;
                comboBoxSmallGenre.DisplayMember = "SgName";
                comboBoxSmallGenre.ValueMember = "SgID";
                comboBoxSmallGenre.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxSmallGenre.SelectedIndex = -1;
            }
        }

        private void fncAllSelect()
        {
            dataGridViewDsp.Rows.Clear();
            if(stname == "管理者")
            {
                try
                {
                    var context = new PriceCompareSystemContext();
                    var tb = from t1 in context.M_PriceLists
                             join t2 in context.M_SmallGenres
                             on t1.GeID equals t2.SgID
                             join t3 in context.M_Products
                             on t1.PrID equals t3.PrID
                             join t4 in context.M_Stores
                             on t1.StID equals t4.StID
                             join t5 in context.M_Prefectures
                             on t1.PfID equals t5.PfID
                             join t6 in context.M_Makers
                             on t1.MaID equals t6.MaID
                             select new
                             {
                                 t1.PlID,
                                 t2.SgName,
                                 t6.MaName,
                                 t3.PrName,
                                 t1.Price,
                                 t4.StName,
                                 t5.PfName
                             };
                    foreach (var p in tb)
                    {
                        dataGridViewDsp.Rows.Add(p.PlID, p.SgName, p.MaName, p.PrName, p.Price, p.StName, p.PfName);
                    }
                    context.Dispose();
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
                    var tb = from t1 in context.M_PriceLists
                             join t2 in context.M_SmallGenres
                             on t1.GeID equals t2.SgID
                             join t3 in context.M_Products
                             on t1.PrID equals t3.PrID
                             join t4 in context.M_Stores
                             on t1.StID equals t4.StID
                             join t5 in context.M_Prefectures
                             on t1.PfID equals t5.PfID
                             join t6 in context.M_Makers
                             on t1.MaID equals t6.MaID
                             where t1.StID.ToString() == stid
                             select new
                             {
                                 t1.PlID,
                                 t2.SgName,
                                 t6.MaName,
                                 t3.PrName,
                                 t1.Price,
                                 t4.StName,
                                 t5.PfName
                             };
                    foreach (var p in tb)
                    {
                        dataGridViewDsp.Rows.Add(p.PlID, p.SgName,p.MaName, p.PrName, p.Price, p.StName, p.PfName);
                    }
                    context.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AllClear()
        {
            labelPlID.Text = "";
            comboBoxMajorGenre.SelectedIndex = -1;
            comboBoxSmallGenre.SelectedIndex = -1;
            comboBoxMaker.SelectedIndex = -1;
            comboBoxProduct.SelectedIndex = -1;
            textBoxPrice.Text = "";
        }

        private void F_PriceList_Load(object sender, EventArgs e)
        {
            if(stname == "管理者")
            {
                textBoxPlID.Visible = true;
            }
            else
            {
                textBoxPlID.Visible = false;
            }

            labelStName.Text = stname;

            //列数の指定
            dataGridViewDsp.ColumnCount = 7;

            dataGridViewDsp.Columns[0].Width = 70;
            dataGridViewDsp.Columns[0].HeaderText = "価格リストID";
            dataGridViewDsp.Columns[1].Width = 130;
            dataGridViewDsp.Columns[1].HeaderText = "ジャンル";
            dataGridViewDsp.Columns[2].Width = 130;
            dataGridViewDsp.Columns[2].HeaderText = "メーカー";
            dataGridViewDsp.Columns[3].Width = 150;
            dataGridViewDsp.Columns[3].HeaderText = "商品名";
            dataGridViewDsp.Columns[4].Width = 80;
            dataGridViewDsp.Columns[4].HeaderText = "価格";
            dataGridViewDsp.Columns[5].Width = 150;
            dataGridViewDsp.Columns[5].HeaderText = "店舗名";
            dataGridViewDsp.Columns[6].Width = 130;
            dataGridViewDsp.Columns[6].HeaderText = "都道府県";
            //選択モードを行単位
            dataGridViewDsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewDsp.ReadOnly = true;
            //全データ表示
            fncAllSelect();

            SetFormCombBox();
        }

        private void comboBoxGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void buttonRegester_Click(object sender, EventArgs e)
        {
            if(comboBoxMajorGenre.SelectedIndex == -1)
            {
                MessageBox.Show("大ジャンルを選択してください");
                return;
            }

            if(comboBoxSmallGenre.SelectedIndex == -1)
            {
                MessageBox.Show("ジャンルを選択してください");
                return;
            }
            if(comboBoxMaker.SelectedIndex == -1)
            {
                MessageBox.Show("メーカーを選択してください");
                return;
            }
            if(comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("商品名を選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxPrice.Text.Trim()))
            {
                MessageBox.Show("価格を入力してください");
                return;
            }
            string s = textBoxPrice.Text;
            int i;
            bool numeric = int.TryParse(s, out i);
            if (numeric == false)
            {
                MessageBox.Show("価格は数字で入力してください");
                return;
            }

            int prid = int.Parse(comboBoxProduct.SelectedValue.ToString());
            int stid2 = int.Parse(stid);
            var context = new PriceCompareSystemContext();
            int count = context.M_PriceLists.Where(x => x.PrID == prid && x.StID == stid2).Count();
            if(count >= 1)
            {
                MessageBox.Show("入力された商品名は既に登録されています");
                return;
            }

            var pricelist = new M_PriceLists
            {
                MgID = int.Parse(comboBoxMajorGenre.SelectedValue.ToString()),
                GeID = int.Parse(comboBoxSmallGenre.SelectedValue.ToString()),
                MaID = int.Parse(comboBoxMaker.SelectedValue.ToString()),
                PrID = prid,
                Price = int.Parse(textBoxPrice.Text.Trim()),
                PfID = int.Parse(pfid),
                StID = int.Parse(stid)
            };
            try
            {
                DialogResult result = MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                context.M_PriceLists.Add(pricelist);
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

        private void comboBoxPrefecture_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int plid;
            if(stname == "管理者")
            {
                if (String.IsNullOrEmpty(textBoxPlID.Text))
                {
                    MessageBox.Show("価格リストIDが未入力です");
                    return;
                }

                plid = int.Parse(textBoxPlID.Text);
            }
            else if (String.IsNullOrEmpty(labelPlID.Text))
            {
                MessageBox.Show("更新する項目を選択してください");
                return;
            }

            plid = int.Parse(labelPlID.Text);

            if (comboBoxMajorGenre.SelectedIndex == -1)
            {
                MessageBox.Show("大ジャンルを選択してください");
                return;
            }

            if (comboBoxSmallGenre.SelectedIndex == -1)
            {
                MessageBox.Show("ジャンルを選択してください");
                return;
            }
            if (comboBoxMaker.SelectedIndex == -1)
            {
                MessageBox.Show("メーカーを選択してください");
                return;
            }
            if (comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("商品名を選択してください");
                return;
            }
            if (String.IsNullOrEmpty(textBoxPrice.Text.Trim()))
            {
                MessageBox.Show("価格を入力してください");
                return;
            }

            string s = textBoxPrice.Text;
            int i;
            bool numeric = int.TryParse(s, out i);
            if (numeric == false)
            {
                MessageBox.Show("価格は数字で入力してください");
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show("更新してもよろしいですか？", "更新確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                var context = new PriceCompareSystemContext();
                var pricelist = context.M_PriceLists.Single(x => x.PlID == plid);
                pricelist.MgID = int.Parse(comboBoxMajorGenre.SelectedValue.ToString());
                pricelist.GeID = int.Parse(comboBoxSmallGenre.SelectedValue.ToString());
                pricelist.MaID = int.Parse(comboBoxMaker.SelectedValue.ToString());
                pricelist.PrID = int.Parse(comboBoxProduct.SelectedValue.ToString());
                pricelist.Price = int.Parse(textBoxPrice.Text.Trim());
                pricelist.PfID = int.Parse(pfid);
                pricelist.StID = int.Parse(stid);
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
            int plid;
            try
            {
                if(stname == "管理者")
                {
                    if (String.IsNullOrEmpty(textBoxPlID.Text))
                    {
                        MessageBox.Show("価格リストIDが未入力です");
                        return;
                    }
                    plid = int.Parse(textBoxPlID.Text);
                }
                else
                {
                    plid = int.Parse(labelPlID.Text);
                }

                DialogResult result = MessageBox.Show("削除してもよろしいですか？","削除確認",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.Cancel) 
                {
                    return;
                }

                var context = new PriceCompareSystemContext();
                var pricelist = context.M_PriceLists.Single(x => x.PlID == plid);
                context.M_PriceLists.Remove(pricelist);
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

        private void comboBoxMaker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(comboBoxMaker.SelectedIndex != -1)
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
                Product = productDataAccess.GetProductDspData( mgid, sgid, maid);
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
                //商品コンボボックスを設定
                int sgid = int.Parse(comboBoxSmallGenre.SelectedValue.ToString());
                int? mgid = null;
                if(comboBoxMajorGenre.SelectedIndex != -1)
                {
                    mgid = int.Parse(comboBoxMajorGenre.SelectedValue.ToString());
                }

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

                //大ジャンル未選択時大ジャンル設定
                var context = new PriceCompareSystemContext();
                mgid = context.M_SmallGenres.Single(x => x.SgID == sgid).MgID;
                string mgname = context.M_MajorGenres.Single(x => x.MgID == mgid).MgName;
                comboBoxMajorGenre.Text = mgname;
            }
        }

        private void comboBoxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(comboBoxProduct.SelectedIndex != -1)
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

        private void dataGridViewDsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(stname == "管理者")
            {
                textBoxPlID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            }
            else
            {
                labelPlID.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[0].Value.ToString();
            }
            string sgname = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[1].Value.ToString();
            var context = new PriceCompareSystemContext();
            int mgid = context.M_SmallGenres.Single(x => x.SgName == sgname).MgID;
            string mgname = context.M_MajorGenres.Single(x => x.MgID == mgid).MgName;
            comboBoxMajorGenre.Text = mgname;
            comboBoxSmallGenre.Text = sgname;
            comboBoxMaker.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[2].Value.ToString();
            comboBoxProduct.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[3].Value.ToString();
            textBoxPrice.Text = dataGridViewDsp.Rows[dataGridViewDsp.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Opacity = 0;
            F_Menu f_Menu = new F_Menu();
            f_Menu.ShowDialog();
            f_Menu.Dispose();
        }
    }
}

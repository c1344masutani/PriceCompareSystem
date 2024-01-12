using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem
{
    public partial class F_Result : Form
    {
        internal static string product = "";
        internal static string maker = "";
        internal static string genre = "";
        internal static int? price = null;
        internal static string store = "";
        internal static string prefectures = "";
        public F_Result()
        {
            InitializeComponent();
        }

        private void F_Result_Load(object sender, EventArgs e)
        {
            panelReview.Visible = false;

            labelGenre.Text = genre;
            labelMaker.Text = maker;
            labelProduct.Text = product;
            labelPrice.Text = price.ToString();
            labelStore.Text = store;
            labelPrefectures.Text = prefectures;

            var context = new PriceCompareSystemContext();

            //店舗情報
            int stid = context.M_Stores.Single(x => x.StName == store).StID;
            string address = context.M_Stores.Single(x => x.StID == stid).StAddress;
            labelAddress.Text = address;

            int prid = context.M_Products.Single(x => x.PrName == product).PrID;
            int count = context.M_PriceLists.Where(x => x.PrID == prid).Count();
            var ranklist = new List<int>();

            //同じ価格をカウント
            int sameprice = context.M_PriceLists.Where(x => x.PrID == prid && x.Price == price).Count();
            
            if(sameprice >= 2) //同じ価格が2件以上あった場合
            {
                //重複をまとめ、同じ順位にする
                ranklist = context.M_PriceLists.Where(x => x.PrID == prid).OrderBy(x => x.Price).Select(x => x.Price).Distinct().ToList();
            }
            else
            {
                ranklist = context.M_PriceLists.Where(x => x.PrID == prid).OrderBy(x => x.Price).Select(x => x.Price).ToList();
            }

            int rank = ranklist.IndexOf(int.Parse(price.ToString())) + 1;

            labelCount.Text = count.ToString() + "店舗中" + rank.ToString() + "位";


            int reviewcount = context.M_Reviews.Where(x => x.StID == stid).Count();
            if(reviewcount >= 1)
            {
                double score = Math.Round(context.M_Reviews.Where(x => x.StID == stid).Average(x => x.Star),1);
                labelReviewScore.Text = "評価     " + score.ToString() + "/5";
            }
            else
            {
                labelReviewScore.Text = "この店舗にはまだレビューがありません";
            }
            dataGridViewReview.ColumnCount = 2;
            dataGridViewReview.Columns[0].Width = 200;
            dataGridViewReview.Columns[0].HeaderText = "タイトル";
            dataGridViewReview.Columns[1].Width = 200;
            dataGridViewReview.Columns[1].HeaderText = "本文";
            dataGridViewReview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewReview.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //選択モードを行単位
            dataGridViewReview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //読み取り専用
            dataGridViewReview.ReadOnly = true;
            //全データ表示
            fncAllSelect();
        }

        private void fncAllSelect()
        {
            dataGridViewReview.Rows.Clear();
            try
            {
                var context = new PriceCompareSystemContext();
                int stid = context.M_Stores.Single(x => x.StName == store).StID;
                var tb = from t1 in context.M_Reviews
                         where t1.StID == stid
                         select new
                         {
                             t1.Title,
                             t1.Review
                         };
                foreach(var p in tb)
                {
                    dataGridViewReview.Rows.Add(p.Title, p.Review);
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            int star;
            if(radioButtonStar1.Checked == true)
            {
                star = 1;
            }
            else if(radioButtonStar2.Checked == true)
            {
                star = 2;
            }
            else if (radioButtonStar3.Checked == true)
            {
                star = 3;
            }
            else if(radioButtonStar4.Checked == true) 
            {
                star = 4;
            }
            else if(radioButtonStar5.Checked == true)
            {
                star = 5;
            }
            else
            {
                MessageBox.Show("星の数を選択してください");
                return;
            }

            if (String.IsNullOrEmpty(textBoxTitle.Text))
            {
                MessageBox.Show("タイトルを入力してください");
                return;
            }
            else if(textBoxTitle.TextLength > 50)
            {
                MessageBox.Show("タイトルは50文字以内で入力してください");
                return;
            }

            if (String.IsNullOrEmpty(textBoxReview.Text))
            {
                MessageBox.Show("レビューを入力してください");
                return;
            }

            var context = new PriceCompareSystemContext();
            int stid = context.M_Stores.Single(x => x.StName == store).StID;
            var review = new M_Review
            {
                StID = stid,
                Title = textBoxTitle.Text,
                Review = textBoxReview.Text,
                Star = star
            };

            try
            {
                context.M_Reviews.Add(review);
                context.SaveChanges();
                context.Dispose();
                MessageBox.Show("送信完了");
                fncAllSelect();
                dataGridViewReview.Visible = true;
                buttonReview.Visible = true;
                panelReview.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonReview_Click(object sender, EventArgs e)
        {
            dataGridViewReview.Visible = false;
            buttonReview.Visible = false;
            panelReview.Visible = true;
        }
    }
}

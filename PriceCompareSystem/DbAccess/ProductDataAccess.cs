using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem.DbAccess
{
    internal class ProductDataAccess
    {
        public List<M_Products> GetProductDspData(int? mgid, int? sgid, int? maid)
        {
            List<M_Products> product = new List<M_Products>();
            try
            {
                var context = new PriceCompareSystemContext();

                if (mgid == null)   //大ジャンルが未選択の時
                {
                    if(maid == null)    //メーカーも未選択の時
                    {
                        product = context.M_Products.Where(x => x.PrName.Contains(string.Empty)).ToList();
                    }
                    else
                    {
                        product = context.M_Products.Where(x => x.MaID == maid).ToList();
                    }
                }
                else if(sgid == null || maid == null)   //小ジャンルかメーカーが未選択の時
                {
                    
                    if(sgid == null && maid == null)    //どちらも未選択の時
                    {
                        //大ジャンルだけで検索
                        product = context.M_Products.Where(x => x.MgID == mgid).ToList();
                    }
                    else if(sgid == null)
                    {
                        //メーカーが選択されている時
                        product = context.M_Products.Where(x => x.MgID == mgid && x.MaID == maid).ToList();
                    }
                    else if(maid == null)
                    {
                        //小ジャンルが選択されているとき
                        product = context.M_Products.Where(x => x.MgID == mgid && x.SgID == sgid).ToList();
                    }
                }
                else        //すべて選択されているとき
                {
                    product = context.M_Products.Where(x => x.MgID == mgid && x.SgID == sgid && x.MaID == maid).ToList();
                }
                
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return product;
        }


    }
}

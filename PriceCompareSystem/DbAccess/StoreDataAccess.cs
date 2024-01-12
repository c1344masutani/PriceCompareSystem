using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem.DbAccess
{
    internal class StoreDataAccess
    {
        public List<M_Store> GetStoreDspData(int pfid)
        {
            List<M_Store> store = new List<M_Store>();
            try
            {
                var context = new PriceCompareSystemContext();
                store = context.M_Stores.Where(x => x.Prefectures == pfid).ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return store;
        }
    }
}

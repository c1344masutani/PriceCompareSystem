using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem.DbAccess
{
    class PrefectureDataAccess
    {
        public List<M_Prefectures> GetPrefectureDspData(int region)
        {
            List<M_Prefectures> prefecture = new List<M_Prefectures>();
            try
            {
                var context = new PriceCompareSystemContext();
                if (region == 0)
                {
                    prefecture = context.M_Prefectures.Where(x => x.PfID >= 1 && x.PfID <= 7).ToList();
                }
                else if (region == 1)
                {
                    prefecture = context.M_Prefectures.Where(x => x.PfID >= 8 && x.PfID <= 14).ToList();
                }
                else if (region == 2)
                {
                    prefecture = context.M_Prefectures.Where(x => x.PfID >= 15 && x.PfID <= 24).ToList();
                }
                else if (region == 3)
                {
                    prefecture = context.M_Prefectures.Where(x => x.PfID >= 25 && x.PfID <= 30).ToList();
                }
                else if (region == 4)
                {
                    prefecture = context.M_Prefectures.Where(x => x.PfID >= 31 && x.PfID <= 39).ToList();
                }
                else if (region == 5)
                {
                    prefecture = context.M_Prefectures.Where(x => x.PfID >= 40 && x.PfID <= 47).ToList();
                }
                else
                {
                    prefecture = context.M_Prefectures.ToList();
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return prefecture;
        }
    }
}

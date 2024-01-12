using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem.DbAccess
{
    internal class SmallGenreDataAccess
    {
        public List<M_SmallGenre> GetSmallGenreDspData(int? mgid)
        {
            List<M_SmallGenre> SmallGenre = new List<M_SmallGenre>();
            try
            {
                var context = new PriceCompareSystemContext();
                if (mgid == null)
                {
                    SmallGenre = context.M_SmallGenres.Where(x => x.SgName.Contains(string.Empty)).ToList();
                }
                else
                {
                    SmallGenre = context.M_SmallGenres.Where(x => x.MgID == mgid).ToList();
                }
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return SmallGenre;
        }
    }
}

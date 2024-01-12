using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem.DbAccess
{
    internal class MajorGenreDataAccess
    {
        public List<M_MajorGenre> GetMajorGenreDspData()
        {
            List<M_MajorGenre> MajorGenre = new List<M_MajorGenre>();
            try
            {
                var context = new PriceCompareSystemContext();
                MajorGenre = context.M_MajorGenres.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return MajorGenre;
        }
    }
}

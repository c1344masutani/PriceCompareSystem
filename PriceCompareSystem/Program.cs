using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DB作成
            var context = new PriceCompareSystemContext();
            context.M_Stores.Create();
            context.M_Products.Create();
            context.M_Makers.Create();
            context.M_MajorGenres.Create();
            context.M_SmallGenres.Create();
            context.M_PriceLists.Create();
            context.M_Reviews.Create();
            context.M_Prefectures.Create();
            context.M_Users.Create();
            context.SaveChanges();
            context.Dispose();

            TableDataImport tImp = new TableDataImport();
            tImp.DataImport("M_Prefectures");
            tImp.DataImport("M_Stores");
            tImp.DataImport("M_Products");
            tImp.DataImport("M_Makers");
            tImp.DataImport("M_MajorGenres");
            tImp.DataImport("M_SmallGenres");
            tImp.DataImport("M_PriceLists");
            tImp.DataImport("M_Users");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F_Menu());
        }
    }
}

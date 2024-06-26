﻿using PriceCompareSystem.Entity;
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
        public List<M_Stores> GetStoreDspData(int pfid)
        {
            List<M_Stores> store = new List<M_Stores>();
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

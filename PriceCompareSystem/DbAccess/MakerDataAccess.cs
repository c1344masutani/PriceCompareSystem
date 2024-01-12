﻿using PriceCompareSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceCompareSystem.DbAccess
{
    class MakerDataAccess
    {
        public List<M_Maker> GetMakerDspData()
        {
            List<M_Maker> maker = new List<M_Maker>();
            try
            {
                var context = new PriceCompareSystemContext();
                maker = context.M_Makers.ToList();
                context.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return maker;
        }
    }
}

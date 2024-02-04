using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareSystem.Entity
{
    class M_PriceLists
    {
        [Key]
        public int PlID { get; set; }       //価格リストID
        public int MgID { get; set; }       //大ジャンルID
        public int GeID { get; set; }       //ジャンルID
        public int MaID { get; set; }       //メーカーID
        public int PrID { get; set; }       //商品ID
        public int Price { get; set; }      //価格
        public int StID { get; set; }       //店舗ID
        public int PfID { get; set; }       //都道府県ID


    }
}

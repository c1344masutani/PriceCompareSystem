using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareSystem.Entity
{
    internal class M_Products
    {
        [Key]
        public int PrID { get; set; }       //商品ID
        public int MaID { get; set; }       //メーカーID
        [MaxLength(50)]
        [Required]
        public string PrName { get; set; }  //商品名
        public int Price { get; set; }      //価格
        public int MgID { get; set; }       //大ジャンル
        public int SgID { get; set; }       //小ジャンル
    }
}

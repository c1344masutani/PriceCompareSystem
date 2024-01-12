using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareSystem.Entity
{
    internal class M_Review
    {
        [Key]
        public int ReID { get; set; }       //レビューID
        public int StID { get; set; }       //店舗ID
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }   //タイトル
        [Required]
        public string Review { set; get; }  //レビュー
        public int Star { set; get; }       //星
    }
}

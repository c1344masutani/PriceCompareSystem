using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareSystem.Entity
{
    internal class M_Stores
    {
        [Key]
        public int StID { get; set; }           //店舗ID
        [MaxLength(50)]
        [Required]
        public string StName { get; set; }      //店舗名
        public int Prefectures { get; set; }    //都道府県名
        [MaxLength(50)]
        [Required]
        public string StAddress { get; set;}    //店舗住所
        [MaxLength(13)]
        [Required]
        public string StPhone { get; set;}      //店舗電話番号
        [MaxLength(50)]
        [Required]
        public string StPassWord { get; set;}   //パスワード
    }
}

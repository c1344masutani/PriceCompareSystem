using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareSystem.Entity
{
    class M_Makers
    {
        [Key]
        public int MaID { get; set; }           //メーカーID
        [MaxLength(50)]
        [Required]
        public string MaName { get; set; }      //メーカー名
        [MaxLength(50)]
        [Required]
        public string MaAddress { get; set; }   //メーカー住所
        [MaxLength(13)]
        [Required]
        public string MaPhone { get; set; }     //メーカー電話番号 
    }
}

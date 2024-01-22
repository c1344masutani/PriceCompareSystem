using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareSystem.Entity
{
    class M_Prefecture
    {
        [Key]
        public int PfID { get; set; }       //都道府県ID
        [MaxLength(5)]
        [Required]
        public string PfName { get; set; }  //都道府県名
        public int region { get; set; }     //地域
    }
}

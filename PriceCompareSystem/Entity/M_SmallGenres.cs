using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareSystem.Entity
{
    internal class M_SmallGenres
    {
        [Key]
        public int SgID { get; set; }
        public int MgID { get; set; }
        [MaxLength(50)]
        [Required]
        public string SgName { get; set; }
    }
}

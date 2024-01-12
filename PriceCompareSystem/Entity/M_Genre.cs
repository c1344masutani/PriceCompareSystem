using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareSystem.Entity
{
    internal class M_Genre
    {
        [Key]
        public int GeID { get; set; }
        [MaxLength(50)]
        [Required]
        public string GeName { get; set; }
    }
}

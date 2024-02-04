using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareSystem.Entity
{
    internal class M_Users
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(50)]
        [Required]
        public string UserName { get; set; }
        [MaxLength(50)]
        [Required]
        public string PassWord { get; set; }
    }
}

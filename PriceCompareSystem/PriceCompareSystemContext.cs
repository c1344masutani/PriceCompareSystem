using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// EntityFrameworkを利用する
using System.Data.Entity;
using PriceCompareSystem.Entity;

namespace PriceCompareSystem
{
    class PriceCompareSystemContext : DbContext
    {
        public DbSet<M_Makers> M_Makers { get; set; }
        public DbSet<M_Products> M_Products { get; set;}     
        public DbSet<M_Stores> M_Stores { get; set;}
        public DbSet<M_Prefectures> M_Prefectures { get; set; }
        public DbSet<M_PriceLists> M_PriceLists { get; set; }
        public DbSet<M_MajorGenres> M_MajorGenres { get; set; }
        public DbSet<M_SmallGenres> M_SmallGenres { get; set; }
        public DbSet<M_Reviews> M_Reviews { get; set; }
        public DbSet<M_Users> M_Users { get; set; }
    }
}

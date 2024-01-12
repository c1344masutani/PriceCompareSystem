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
        public DbSet<M_Maker> M_Makers { get; set; }
        public DbSet<M_Product> M_Products { get; set;}     
        public DbSet<M_Store> M_Stores { get; set;}
        public DbSet<M_Prefecture> M_Prefectures { get; set; }
        public DbSet<M_PriceList> M_PriceLists { get; set; }
        public DbSet<M_MajorGenre> M_MajorGenres { get; set; }
        public DbSet<M_SmallGenre> M_SmallGenres { get; set; }
        public DbSet<M_Review> M_Reviews { get; set; }
    }
}

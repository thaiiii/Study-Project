using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace demo.Models
{
    public partial class HocSinhDB : DbContext
    {
        public HocSinhDB()
            : base("name=HocSinhDB")
        {
        }

        public virtual DbSet<HocSinh> HocSinh { get; set; }
        public virtual DbSet<LopHoc> LopHoc { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

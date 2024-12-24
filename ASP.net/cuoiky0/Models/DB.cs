using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace cuoiky0.Models
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB1")
        {
        }

        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Phong> Phong { get; set; }
        public virtual DbSet<Taikhoan> Taikhoan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taikhoan>()
                .Property(e => e.tendn)
                .IsFixedLength();
        }
    }
}

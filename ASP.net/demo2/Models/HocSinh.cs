namespace demo2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocSinh")]
    public partial class HocSinh
    {
        [Key]
        [StringLength(10)]
        [DisplayName("So bao danh")]
        public string sbd { get; set; }

        [StringLength(50)]
        [DisplayName("Ho ten")]
        public string hoten { get; set; }

        [StringLength(50)]
        [DisplayName("Anh du thi")]
        public string anhduthi { get; set; }

        [DisplayName("Ma lop")]
        public int? malop { get; set; }

        [DisplayName("Diem thi")]
        public double? diemthi { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}

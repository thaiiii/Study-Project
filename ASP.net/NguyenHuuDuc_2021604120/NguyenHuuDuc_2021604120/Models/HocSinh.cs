namespace NguyenHuuDuc_2021604120.Models
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
        [DisplayName("Số báo danh")]
        public string sbd { get; set; }

        [StringLength(50)]
        [DisplayName("Họ tên")]
        public string hoten { get; set; }

        [StringLength(50)]
        [DisplayName("Ảnh thi")]
        public string anhduthi { get; set; }

        [DisplayName("Mã lớp")]
        public int? malop { get; set; }

        [DisplayName("Điểm thi")]
        public double? diemthi { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}

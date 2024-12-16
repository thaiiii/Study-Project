namespace _2021604440_HoangXuanQuy_OntapTuan13.Models
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
        [Required(ErrorMessage = "Không để trống!")]
        [DisplayName("Số báo danh")]
        [StringLength(10)]
        public string sbd { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Không để trống!")]
        [DisplayName("Họ tên")]
        public string hoten { get; set; }

        [StringLength(50)]
        [DisplayName("Ảnh dự thi")]
        public string anhduthi { get; set; }

        [Required(ErrorMessage = "Không để trống!")]
        [DisplayName("Mã lớp")]
        public int? malop { get; set; }

        [Required(ErrorMessage = "Không để trống!")]
        [DisplayName("Điểm thi")]
        public double? diemthi { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}

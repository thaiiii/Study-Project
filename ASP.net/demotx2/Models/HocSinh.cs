namespace demotx2.Models
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
        [Required(ErrorMessage ="Muc nay la bat buoc")]
        [DisplayName("So bao danh")]
        public string sbd { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Muc nay la bat buoc")]
        [DisplayName("Ho ten")]
        public string hoten { get; set; }

        [StringLength(50)]
        [DisplayName("Anh du thi")]
        [Required(ErrorMessage = "Muc nay la bat buoc")]
        public string anhduthi { get; set; }

        [DisplayName("Ma lop")]
        [Required(ErrorMessage = "Muc nay la bat buoc")]
        public int? malop { get; set; }

        [DisplayName("Diem thi")]
        [Required(ErrorMessage = "Muc nay la bat buoc")]
        public double? diemthi { get; set; }


        [Required(ErrorMessage = "Muc nay la bat buoc")]
        public virtual LopHoc LopHoc { get; set; }
    }
}

namespace cuoiky0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [Required(ErrorMessage = "Ko dc de trong")]
        [DisplayName("Ma nv")]
        public int Manv { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Ko dc de trong")]
        [DisplayName("Ho ten")]
        public string Hoten { get; set; }


        [Required(ErrorMessage = "Ko dc de trong")]
        [DisplayName("Tuoi")]
        public int? Tuoi { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Ko dc de trong")]
        [DisplayName("Dia chi")]
        public string Diachi { get; set; }


        [Required(ErrorMessage = "Ko dc de trong")]
        [DisplayName("Luong")]
        public int? Luong { get; set; }

        public int? Maphong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}

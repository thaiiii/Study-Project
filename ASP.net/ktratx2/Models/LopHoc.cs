namespace ktratx2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHoc()
        {
            HocSinh = new HashSet<HocSinh>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Mã lớp")]
        public int malop { get; set; }

        [StringLength(25)]
        [DisplayName("Tên lớp")]
        public string tenlop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocSinh> HocSinh { get; set; }
    }
}

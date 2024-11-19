namespace baitap_WineStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống")]
        [DisplayName("Mã sản phẩm")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }


        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [DisplayName("Tên sản phẩm")]
        [StringLength(50)]
        public string ProductName { get; set; }


        [DisplayName("Mô tả")]
        [Column(TypeName = "text")]
        public string Description { get; set; }


        [DisplayName("Giá nhập")]
        [Required(ErrorMessage = "Giá nhập không được để trống")]
        [Column(TypeName = "numeric")]
        public decimal PurchasePrice { get; set; }

        [DisplayName("Giá bán")]
        [Required(ErrorMessage = "Giá bán không được để trống")]
        [Column(TypeName = "numeric")]
        public decimal Price { get; set; }

        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống")]
        public int Quantity { get; set; }

        [DisplayName("Năm sản xuất")]
        [StringLength(20)]
        public string Vintage { get; set; }

        [DisplayName("Mã danh mục")]
        [StringLength(10)]
        public string CatalogyID { get; set; }

        [Column(TypeName = "text")]
        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Vùng không được để trống")]
        [DisplayName("Vùng")]
        [StringLength(100)]
        public string Region { get; set; }

        public virtual Catalogy Catalogy { get; set; }
    }
}

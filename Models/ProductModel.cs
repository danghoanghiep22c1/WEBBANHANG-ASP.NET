using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WEBBANHANG.Repository.Validation;

namespace WEBBANHANG.Models
{
	public class ProductModel
	{
		[Key]
		public int Id { get; set; }
		[Required ( ErrorMessage = "Yêu cầu nhập tên sản phẩm ")]
		public string Name { get; set; }
		public string Slug { get; set; }
		[Required( ErrorMessage = "Yêu cầu nhập mô tả sản phẩm")]
		public string Description { get; set; }
		[Required( ErrorMessage = "Yêu cầu nhập giá sản phẩm")]
        [Range(0.01, double.MaxValue)]
		[Column(TypeName ="decimal(8,2)")]
        public decimal Price { get; set; }
        [Required, Range(0.01, double.MaxValue, ErrorMessage = "Chọn một sản phẩm")]
        public int BrandId { get; set; }
        [Required, Range(0.01, double.MaxValue, ErrorMessage = "Chọn một danh mục")]
        public int CategoryId { get; set; }
		public CategoryModel Category { get; set; }
		public BrandModel Brand { get; set; }
		public string Image { get; set; } = "noipage.jpg";
		[NotMapped]
		[FileExtension]
		public IFormFile ImageUpload { get; set; }
	}
}

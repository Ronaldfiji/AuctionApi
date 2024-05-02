using DataModel.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity.AuctionEntity
{
    [Table("Category", Schema = "AuctionDB")]
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Category code is required !"), StringLength(10, ErrorMessage = "Category code should be 10 chars long.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(30, ErrorMessage = "Name should be 30 chars in length")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [StringLength(20, ErrorMessage = "Icon should be 20 chars in length")]
        public string Icon { get; set; } = string.Empty;
    }
}

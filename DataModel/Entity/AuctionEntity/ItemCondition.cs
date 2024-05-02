using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity.AuctionEntity
{
    [Table("ItemCondition", Schema = "AuctionDB")]
    public class ItemCondition : BaseEntity
    {
        [Required(ErrorMessage = "Product condition is required !"), StringLength(50, ErrorMessage = "Product condition should be 50 chars long.")]
        public string State { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required !"), StringLength(1000, ErrorMessage = "Description should be 1000 chars long.")]
        public string Description { get; set; } = string.Empty;
    }
}

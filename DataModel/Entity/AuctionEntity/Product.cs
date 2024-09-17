using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity.AuctionEntity
{
    [Table("Product", Schema = "AuctionDB")]
    public class Product : BaseEntity
    {
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product name is required !"), StringLength(40, ErrorMessage = "Product name should be 40 chars long.")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } // ushort - Unsigned 16 bit integer (-32,768 - 32,768)
        [Precision(9, 2)]
        public decimal UnitPrice { get; set; }
        [Precision(2, 2)]
        public decimal Rating { get; set; }

        public float? Lng { get; set; }
        public float? Lat { get; set; }
        [StringLength(100, ErrorMessage = "City  name should be 100 chars or less")]
        public string? City { get; set; }
        public string? Address { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? InspectionDate { get; set; }
        [StringLength(200, ErrorMessage = "Inspection summary should be 200 characters")]
        public string InspectionSummary { get; set; } = string.Empty;


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime AuctionDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime AuctionEndDate { get; set; }

        [Column("AuctioneerId")]
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int ItemConditionID { get; set; }

        public Category Category { get; set; } = null!;
        public ItemCondition? ItemCondition { get; set; }
        public User? User { get; set; }
        public virtual ICollection<ProductPictures> ProductPictures { get; set; } = Enumerable.Empty<ProductPictures>().ToList();

    }
}

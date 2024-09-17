using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SharedModel.AutionsDto
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product name is required !"), StringLength(40, ErrorMessage = "Product name should be 40 chars long.")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } // ushort - Unsigned 16 bit integer (-32,768 - 32,768)
        [Column(TypeName = "decimal(9, 2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(2, 2)")]
        public decimal Rating { get; set; }

        public float? Lng { get; set; }
        public float? Lat { get; set; }
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

        public CategoryDto? CategoryDto { get; set; } = null!;
        public ItemConditionDto? ItemConditionDtos { get; set; } = null!;       
        public virtual ICollection<ProductPicturesDto> ProductPicturesDtos { get; set; } = Enumerable.Empty<ProductPicturesDto>().ToList();

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }
}


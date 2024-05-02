using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity.AuctionEntity
{
    [Table("Designation", Schema = "AuctionDB")]
    public class Designation : BaseEntity
    {
        [StringLength(50, ErrorMessage = "Job title should be 30 characters.")]
        public string JobTitle { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Job description should be 100 characters.")]
        public string Description { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? DesignationDate { get; set; }
    }
}


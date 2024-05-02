using System.ComponentModel.DataAnnotations;


namespace DataModel.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow.AddHours(12);

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? ModifiedDate { get; set; }

        [StringLength(50, ErrorMessage = "Should be 50 chars or less ")]
        public string? CreatedBy { get; set; } = string.Empty;
        [StringLength(50, ErrorMessage = "Should be 50 chars or less")]
        public string? UpdatedBy { get; set; } = string.Empty;
        [StringLength(15, ErrorMessage = "Should be 15 chars or less")]
        public string? IPAddress { get; set; } = string.Empty;
    }

    public class BaseRelatedEntity
    {

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow.AddHours(12);

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? ModifiedDate { get; set; }

        [StringLength(50, ErrorMessage = "Should be 50 chars or less ")]
        public string? CreatedBy { get; set; } = string.Empty;
        [StringLength(50, ErrorMessage = "Should be 50 chars or less")]
        public string? UpdatedBy { get; set; } = string.Empty;
        [StringLength(15, ErrorMessage = "Should be 15 chars or less")]
        public string? IPAddress { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace SharedModel.AutionsDto
{
    public class ItemConditionDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Product condition is required !"), StringLength(50, ErrorMessage = "Product condition should be 50 chars long.")]
        public string State { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required !"), StringLength(1000, ErrorMessage = "Description should be 1000 chars long.")]
        public string Description { get; set; } = string.Empty;

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }
}


using SharedModel.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedModel.JobsDto
{
    public class JobPostDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Job title is required !"), StringLength(100, ErrorMessage = "Job title should be 100 chars in length")]
        public string JobTitle { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required !"), StringLength(100, ErrorMessage = "Category should be 100 chars in length")]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Job type is required !"), StringLength(50, ErrorMessage = "Job type should be 50 chars in length")]
        public string JobType { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required !"), StringLength(50, ErrorMessage = "City should be 50 chars in length")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required !"), StringLength(50, ErrorMessage = "City should be 50 chars in length")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required !"), StringLength(7000, ErrorMessage = "Description should be 7000 chars in length")]
        public string Description { get; set; } = string.Empty;

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ClosingDate { get; set; }
        public bool IsActive { get; set; }

        public int OrganisationID { get; set; }
        public OrganisationDto? Organisation { get; set; }

        [Required(ErrorMessage = "User id is required!")]
        public int UserID { get; set; }    

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }
}

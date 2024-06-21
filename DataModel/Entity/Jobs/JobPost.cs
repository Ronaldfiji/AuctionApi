using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.Entity.Jobs
{
    public class JobPost : BaseEntity
    {
        [Required(ErrorMessage = "Job title is required !"), StringLength(100, ErrorMessage = "Job title should be 100 chars in length")]
        public string JobTitle { get; set; } = string.Empty;

        public int  OrganisationID {  get; set; }
        public Organisation? Organisation { get; set; }

        [Required(ErrorMessage = "Category is required !"), StringLength(100, ErrorMessage = "Category should be 100 chars in length")]
        public string Category { get; set; }= string.Empty;

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
        public bool IsActived { get; set; }

        [Required(ErrorMessage = "User id is required !")]
        public int UserID { get; set; }
        public User? User { get; set; }

    }
}

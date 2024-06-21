using SharedModel.Dtos;
using System.ComponentModel.DataAnnotations;


namespace SharedModel.JobsDto
{
    public class OrganisationDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Organisation code is required !"),
            StringLength(10, ErrorMessage = "Organisation code should be 10 chars long.")]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "Organisation name is required !"), StringLength(200, ErrorMessage = "Name should be 200 chars in length")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tin number is required !"), StringLength(12, ErrorMessage = "Tin number should be 12 chars in length")]
        public string Tin { get; set; } = string.Empty;

        public string LogoPath { get; set; } = string.Empty;

        public OrganisationLogoDto?  organisationLogoDto { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;        
    }

    public class OrganisationLogoDto
    {
        public string Path { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Base64data { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;

    }
}

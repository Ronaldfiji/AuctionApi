using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity.Jobs
{
    [Table("Organisation", Schema = "JobsDB")]
    public class Organisation : BaseEntity
    {      
        [Required(ErrorMessage = "Organisation code is required !"),
            StringLength(10, ErrorMessage = "Organisation code should be 10 chars long.")]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "Organisation name is required !"), StringLength(200, ErrorMessage = "Name should be 200 chars in length")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tin number is required !"), StringLength(12, ErrorMessage = "Tin number should be 12 chars in length")]
        public string Tin { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Logo path should be 200 characters or less.")]
        public string LogoPath { get; set; } = string.Empty;
    }
}

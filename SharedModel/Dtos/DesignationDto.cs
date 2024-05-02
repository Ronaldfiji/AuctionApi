using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Dtos
{
    public class DesignationDto
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Job title should be 30 characters.")]
        public string JobTitle { get; set; } = string.Empty;
        [StringLength(100, ErrorMessage = "Job description should be 100 characters.")]
        public string Description { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? DesignationDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }

    public class DesignationFilter 
    {

    }
}

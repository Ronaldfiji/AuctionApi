using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.AutionsDto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Category code is required !"), StringLength(10, ErrorMessage = "Category code should be 10 chars long.")]
        public string Code { get; set; } = string.Empty;
        [StringLength(30, ErrorMessage = "Name should be 30 chars in length")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [StringLength(20, ErrorMessage = "Icon should be 20 chars in length")]
        public string Icon { get; set; } = string.Empty;

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }
}

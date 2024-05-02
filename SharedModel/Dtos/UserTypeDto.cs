using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SharedModel.Dtos
{
    public class UserTypeDto
    {
        public int Id { get; set; }
        public string? Code { get; set; } = string.Empty;
        public string? Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
    }
    public class UserTypeToEditDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is required !"), StringLength(1, ErrorMessage = "Code should be 1 characters or less.")]
        public string Code { get; set; } = string.Empty;
        [Required(ErrorMessage = "Type name is required !"), StringLength(100, ErrorMessage = "Name should be 100 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required !"), StringLength(100, ErrorMessage = "Description should be 100 characters or less.")]
        public string Description { get; set; } = string.Empty;
        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        //[JsonIgnore]
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string IPAddress { get; set; } = string.Empty;
    }
}

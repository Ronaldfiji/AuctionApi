using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SharedModel.Dtos
{
    public class RoleDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
        //public virtual ICollection<UserDto> UsersDto { get; set; }  = Enumerable.Empty<UserDto>().ToList();
    }

    public class RoleToAddEditDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Role name is required !"), StringLength(30, ErrorMessage = "Name to be 30 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Role description is required !"), StringLength(100, ErrorMessage = "Decription to be 100 characters or less.")]
        public string Description { get; set; } = string.Empty;
        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        //[JsonIgnore]
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string IPAddress { get; set; } = string.Empty;

    }

    public class UserRoleDto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        [JsonIgnore]
        public string IPAddress { get; set; } = string.Empty;

    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataModel.Entity
{
    [Table("Role", Schema = "UserDM")]
    public class Role : BaseEntity
    {
        public Role()
        {
            UserRoles = new List<UserRole>();
        }

        [Required(ErrorMessage = "Role name is required !"), StringLength(30, ErrorMessage = "Name to be 30 characters or less.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Role description is required !"), StringLength(100, ErrorMessage = "Decription to be 100 characters or less.")]
        public string Description { get; set; } = string.Empty;

        public virtual ICollection<UserRole> UserRoles { get; set; }
      
    }
}


using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity
{
    [Table("UserRole", Schema = "UserDM")]
    public class UserRole : BaseRelatedEntity
    {

        public int RoleId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } = null!;
        [ForeignKey("RoleId")]
        public Role Role { get; set; } = null!;

    }
}

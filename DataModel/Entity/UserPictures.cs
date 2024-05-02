using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity
{

    [Table("UserPictures", Schema = "UserDM")]
    public class UserPictures : BaseEntity
    {
        public string Path { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int AppUserID { get; set; }
        public User AppUser { get; set; } = null!;
    }
}

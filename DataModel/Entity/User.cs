using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DataModel.Entity
{
    [Table("User", Schema = "UserDM")]
    public class User : BaseEntity
    {
        public User() /*  Handle many-to-many relationship  */
        {
            UserRoles = new List<UserRole>();
        }

        [Display(Name = "First Name"), Required(ErrorMessage = "You must provide firstname")]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name"), Required(ErrorMessage = "You must provide  lastname")]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? DOB { get; set; }

        public Genders Gender { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "Email is reqiured !")]
        public string Email { get; set; } = string.Empty;

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]{7,10}$", ErrorMessage = "Invalid phone number")]
        [StringLength(12, ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = string.Empty;

        [/*Required(ErrorMessage = "Address is required !"),*/ 
        StringLength(100, ErrorMessage = "Address should be 100 characters or less.")]
        public string AddressLine1 { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Address should be 100 characters or less.")]
        public string AddressLine2 { get; set; } = string.Empty;

        [/*Required(ErrorMessage = "City is required !"),*/ StringLength(20, ErrorMessage = "City name should be 20 characters or less.")]
        public string City { get; set; } = string.Empty;

        [StringLength(20, ErrorMessage = "State name should be 20 characters or less.")]
        public string State { get; set; } = string.Empty;

        [StringLength(10, ErrorMessage = "PostalCode name should be 10 characters or less.")]
        public string PostalCode { get; set; } = string.Empty;

        [StringLength(20, ErrorMessage = "Country name should be 20 characters or less.")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required !"), DataType(DataType.Password), MaxLength(200)]
        public string Password { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Image path should be 200 characters or less.")]
        public string ImagePath { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public int UserTypeID { get; set; }

        public UserType UserType { get; set; }

        public virtual List<UserPictures> UserPictures { get; set; } = Enumerable.Empty<UserPictures>().ToList();

        public virtual ICollection<UserRole> UserRoles { get; set; }// = Enumerable.Empty<Role>().ToList();
     
    }

    public enum Genders
    {
        Male = 1,
        Female = 2,
        Other = 3,
    }
}

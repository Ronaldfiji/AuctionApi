using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SharedModel.Dtos
{

    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? DOB { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public UserTypeDto? UserType { get; set; }     
        public string ImagePath { get; set; } = string.Empty;
        public bool IsActive { get; set; }    
        public string PasswordResetToken { get; set; } = string.Empty;
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? ModifiedDate { get; set; }
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;
        public string? IPAddress { get; set; } = string.Empty;
        public virtual List<UserPicturesDto> UserPictures { get; set; } = Enumerable.Empty<UserPicturesDto>().ToList();
        public virtual List<RoleDto> Roles { get; set; } = Enumerable.Empty<RoleDto>().ToList();
        //public virtual ICollection<EnrollmentDto> Enrollments { get; set; } = Enumerable.Empty<EnrollmentDto>().ToList();
        //public virtual ICollection<Assessment> Assessments { get; set; } = null!;
    }

    public class UserToAddDto
    {
        public int Id { get; set; }

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
        public string Phone { get; set; } = string.Empty;

        [/*Required(ErrorMessage = "Address is required !"),*/ StringLength(100, ErrorMessage = "Address should be 100 characters or less.")]
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

        [Required(ErrorMessage = "Password is required !"), DataType(DataType.Password), MaxLength(30)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [NotMapped] // Does not effect with your database
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Accept Ts & Cs is required")]
        public bool AcceptTerms { get; set; }

        [StringLength(200, ErrorMessage = "Image path should be 200 characters or less.")]
        public string ImagePath { get; set; } = string.Empty;

        public int UserTypeId { get; set; }
        public bool IsActive { get; set; }
        [JsonIgnore]
        public DateTime? CreatedDate { get; set; }
        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }

        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;

        [JsonIgnore]
        public string IPAddress { get; set; } = string.Empty;

        [Range(0, 10)]
        public int Role { get; set; } = 1;

        public List<RoleToAddEditDto> Roles { get; set; } = null!;
        public List<UserPicturesToAddEditDto> UserPicturesToAddEditDto { get; set; } = Enumerable.Empty<UserPicturesToAddEditDto>().ToList();
    }

    public class UserToEditDto
    {
        public int Id { get; set; }

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

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]{7,10}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = string.Empty;

        [/*Required(ErrorMessage = "Address is required !"),*/ StringLength(100, ErrorMessage = "Address should be 100 characters or less.")]
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

        public int UserTypeId { get; set; }
        public bool IsActive { get; set; }

        [JsonIgnore]
        public DateTime? ModifiedDate { get; set; }

        [JsonIgnore]
        public string? CreatedBy { get; set; } = string.Empty;
        public string? UpdatedBy { get; set; } = string.Empty;

        [JsonIgnore]
        public string IPAddress { get; set; } = string.Empty;

        public List<RoleToAddEditDto> Roles { get; set; } = Enumerable.Empty<RoleToAddEditDto>().ToList();
        public List<UserPicturesDto> UserPicturesDto { get; set; } = Enumerable.Empty<UserPicturesDto>().ToList();
    }


    public enum Genders
    {
        Male = 1,
        Female = 2,
        Other = 3,
    }
}

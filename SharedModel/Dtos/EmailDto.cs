using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModel.Dtos
{
    public class EmailDto
    {

        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "Recipient Email is reqiured !")]
        public string ToEmail { get; set; } = string.Empty;

     
        [StringLength(80, ErrorMessage = "Email subjext should be 80 characters.")]
        public string Subject { get; set; } = string.Empty;

        [StringLength(1000, ErrorMessage = "Email body should be 1000 characters.")]
        public string Body { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Client App url should be 100 characters.")]
        public string ClientAppUrl { get; set; } = string.Empty;

    }
}

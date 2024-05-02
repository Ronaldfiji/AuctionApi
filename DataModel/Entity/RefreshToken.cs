using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity
{   
        [Table("RefreshToken", Schema = "UserDM")]
        public class RefreshToken
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Token { get; set; } = string.Empty;
            public string JwtId { get; set; } = string.Empty;
            public bool IsUsed { get; set; }
            public bool IsRevorked { get; set; }
            public DateTime AddedDate { get; set; }
            public DateTime ExpiryDate { get; set; }
            public string CreatedByIp { get; set; } = string.Empty.ToString();
            //[ForeignKey(nameof(UserId))]
            public User User { get; set; }
        }
    
}

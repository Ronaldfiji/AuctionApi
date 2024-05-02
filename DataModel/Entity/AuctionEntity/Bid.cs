using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity.AuctionEntity
{
    [Table("Bid", Schema = "AuctionDB")]
    public class Bid : BaseEntity
    {
        [Column("BidderId")]
        public int UserID { get; set; }
        public User? User { get; set; }
        public int ProductID { get; set; }
        public Product? Product { get; set; }
        [Precision(9, 2)]
        public decimal Amount { get; set; }
    }
}

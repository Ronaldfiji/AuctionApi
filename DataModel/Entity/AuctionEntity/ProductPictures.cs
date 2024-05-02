using System.ComponentModel.DataAnnotations.Schema;


namespace DataModel.Entity.AuctionEntity
{
    [Table("ProductPictures", Schema = "AuctionDB")]
    public class ProductPictures : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}

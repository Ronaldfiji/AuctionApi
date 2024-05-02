using DataModel.Entity.AuctionEntity;
using Microsoft.EntityFrameworkCore;

namespace DataModel.DB.SeedData
{
    public static class ModelBuilderExtAuction
    {
        // Seed Category
        public static void SeedCategory(this ModelBuilder modelBuilder)        
        {
          
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    ID = 1,//new Random().Next(),
                    Code ="CAT0001",
                    Name = "Automotive and Spare parts",
                    Description ="Automotive and Spare parts category",
                    Icon= "LocalShipping",
                    CreatedBy = "Ron_cr",UpdatedBy = "Ron_up",IPAddress = "10.56.89.255",
                },
                 new Category()
                 {
                     ID = 2,//new Random().Next(),
                     Code = "CAT0002",
                     Name = "Cell Phones & Accessories",
                     Description = "Cell Phones & Accessories category",
                     Icon = "LocalShipping", CreatedBy = "Ron_cr", UpdatedBy = "Ron_up",
                     IPAddress = "10.56.89.255",                     
                 }, 
                     new Category()
                     {
                         ID = 3,//new Random().Next(),
                         Code = "CAT0003",Name = "Consumer Electronics",
                         Description = "Cell Phones & Accessories category",
                         Icon = "LocalShipping",CreatedBy = "Ron_cr",UpdatedBy = "Ron_up",IPAddress = "10.56.89.255",                      
                     },
                      new Category()
                      {
                          ID = 4,//new Random().Next(),
                          Code = "CAT0004", Name = "Jewelry & Watches",
                          Description = "Jewelry & Watches category",
                          Icon = "LocalShipping", CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                      },
                       new Category()
                       {
                           ID = 5,//new Random().Next(),
                           Code = "CAT0005",
                           Name = "Consumer Electronics", Description = "Consumer Electronics category",
                           Icon = "LocalShipping",CreatedBy = "Ron_cr", UpdatedBy = "Ron_up",IPAddress = "10.56.89.255",
                       },
                        new Category()
                        {
                            ID = 6,//new Random().Next(),
                            Code = "CAT0006",
                            Name = "Real Estate",Description = "Real Estate category",
                            Icon = "LocalShipping", CreatedBy = "Ron_cr",UpdatedBy = "Ron_up",IPAddress = "10.56.89.255",
                        }
               );
        }

        // Seed ItemCondition
        public static void SeedItemCondition(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ItemCondition>().HasData(
                new ItemCondition()
                {
                    ID = 1,//new Random().Next(),
                    State = "New", Description = "A brand-new, unused, unopened, unworn, undamaged item. Most categories support this condition (as long as condition is an applicable concept.",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                },
                new ItemCondition()
                {
                    ID = 2,//new Random().Next(),
                    State = "New other", Description = "A brand-new new, unused item with no signs of wear. Packaging may be missing or opened. The item may be a factory second or have defects",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                },
                new ItemCondition()
                {
                    ID = 3,//new Random().Next(),
                    State = "New with defects", Description = "A brand-new, unused, and unworn item. The item may have cosmetic defects, and/or may contain mismarked tags (e.g., incorrect size tags from the manufacturer). Packaging may be missing or opened. The item may be a new factory second or irregular.",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                },
                new ItemCondition()
                {
                    ID = 4,//new Random().Next(),
                    State = "Refurbished", Description = "The item is in a pristine, like-new condition. It has been professionally inspected, cleaned, and refurbished by the manufacturer or a manufacturer-approved vendor to meet manufacturer specifications. The item will be in new packaging with original or new accessories.",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                },
                new ItemCondition()
                {
                    ID = 5,//new Random().Next(),
                    State = "Excellent - Refurbished", Description = "The item is in like-new condition, backed by a one year warranty. It has been professionally refurbished, inspected, and cleaned to excellent condition by qualified sellers. The item includes original or new accessories and will come in new generic packaging. See the seller's listing for full details.",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                },
                new ItemCondition()
                {
                    ID = 6,//new Random().Next(),
                    State = "Like New", Description = "An item that looks as if it was just taken out of shrink wrap. No visible wear, and all facets of the item are flawless and intact. See the seller's listing for full details and description of any imperfections.",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                },
                new ItemCondition()
                {
                    ID = 7,//new Random().Next(),
                    State = "Used", Description = "An item that has been used previously. The item may have some signs of cosmetic wear, but is fully operational and functions as intended. This item may be a floor model or store return that has been used. Most categories support this condition (as long as condition is an applicable concept).",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                },
                new ItemCondition()
                {
                    ID = 8,//new Random().Next(),
                    State = "Very Good", Description = "An item that is used but still in very good condition. No obvious damage to the cover or jewel case. No missing or damaged pages or liner notes. The instructions (if applicable) are included in the box. May have very minimal identifying marks on the inside cover. Very minimal wear and tear.",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                },
                 new ItemCondition()
                {
                    ID = 9,//new Random().Next(),
                    State = "Acceptable", Description = "An item with obvious or significant wear, but still operational. For books, liner notes, or instructions, the item may have some damage to the cover but the integrity is still intact. Instructions and/or box may be missing. For books, possible writing in margins, etc., but no missing pages or anything that would compromise the legibility or understanding of the text.",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                },
                new ItemCondition()
                {
                    ID = 10,//new Random().Next(),
                    State = "For parts or not working", Description = "An item that does not function as intended and is not fully operational. This includes items that are defective in ways that render them difficult to use, items that require service or repair, or items missing essential components. Supported in categories where parts or non-working items are of interest to people who repair or collect related items.",
                    CreatedBy = "Ron_cr", UpdatedBy = "Ron_up", IPAddress = "10.56.89.255",
                });
        }

        // Seed Designation
        public static void SeedDesignation(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Designation>().HasData(
                new Designation()
                {
                    ID = 1,
                    JobTitle = "Senior Software Engineer",
                    Description = "Senior full-stack software engineer",
                    CreatedBy = "Ron_cr",
                    UpdatedBy = "Ron_up",
                    IPAddress = "10.56.89.255",
                });
        }
    }
}

using DataModel.Entity.AuctionEntity;
using SharedModel.AutionsDto;


namespace Repository.Extention.AuctionDtoConversion
{
    public static class DtoConversions
    {
        // eAuction DTO Conversion

        public static CategoryDto ConvertToDto(this Category category)
        {
            return new CategoryDto
            {
                Id = category.ID,
                Name = category.Name,
                Code = category.Code,
                Description = category.Description,
                Icon = category.Icon,
                CreatedDate = category.CreatedDate,
                ModifiedDate = category.ModifiedDate,
                CreatedBy = category.CreatedBy,
                UpdatedBy = category.UpdatedBy,
                IPAddress = category.IPAddress,

            };
        }

        public static IEnumerable<CategoryDto> ConvertToDto(this IEnumerable<Category> categorys)
        {
            return (from category in categorys
                    select new CategoryDto
                    {
                        Id = category.ID,
                        Code = category.Code,
                        Name = category.Name,
                        Description = category.Description,
                        Icon = category.Icon,
                        CreatedDate = category.CreatedDate,
                        ModifiedDate = category.ModifiedDate,
                        CreatedBy = category.CreatedBy,
                        UpdatedBy = category.UpdatedBy,
                        IPAddress = category.IPAddress,
                    }).ToList();
        }

        // product object conversion

        public static ProductDto ConvertToDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.ID,
                Name = product.Name,            
                Description = product.Description,
                Quantity = product.Quantity,
                UnitPrice = product.UnitPrice,
                Rating = product.Rating,
                Lat = product.Lat,
                Lng = product.Lng,
                Address = product.Address,
                InspectionDate = product.InspectionDate,
                InspectionSummary = product.InspectionSummary,
                AuctionDate = product.AuctionDate,
                AuctionEndDate = product.AuctionEndDate,
                UserID = product.UserID,
                CategoryID = product.CategoryID,
                ItemConditionID = product.ItemConditionID,
                CategoryDto = product?.Category != null ? new CategoryDto
                {
                    Id = product.Category.ID,
                    Code = product.Category.Code,
                    Name = product.Category.Name,
                    Description = product.Category.Description,
                    CreatedBy = product.Category.CreatedBy,
                    UpdatedBy = product.Category.UpdatedBy,
                    CreatedDate = product.Category.CreatedDate,
                    ModifiedDate = product.Category.ModifiedDate,
                    IPAddress = product.Category.IPAddress,
                } : new CategoryDto(),  
                ItemConditionDtos = product?.ItemCondition != null ? new ItemConditionDto
                {
                    Id = product.ID,
                    State = product.ItemCondition.State,
                    Description = product.ItemCondition.Description,
                }: new ItemConditionDto(),
                ProductPicturesDtos = (from prodImg in product?.ProductPictures
                                    select new ProductPicturesDto
                                    {
                                        Id = prodImg.ID,
                                        Name = prodImg.Name,
                                        Path = prodImg.Path,
                                        Description = prodImg.Description,
                                    }).ToList(),
                CreatedDate = product?.CreatedDate,
                ModifiedDate = product?.ModifiedDate,
                CreatedBy = product?.CreatedBy,
                UpdatedBy = product?.UpdatedBy,
                IPAddress = product?.IPAddress,
            };
        }


        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products)
        {

            return (from product in products
                    select new ProductDto
                    {
                        Id = product.ID,
                        Name = product.Name,
                        Description = product.Description,
                        Quantity = product.Quantity,
                        UnitPrice = product.UnitPrice,
                        Rating = product.Rating,
                        Lat = product.Lat,
                        Lng = product.Lng,
                        Address = product.Address,
                        InspectionDate = product.InspectionDate,
                        InspectionSummary = product.InspectionSummary,
                        AuctionDate = product.AuctionDate,
                        AuctionEndDate = product.AuctionEndDate,
                        UserID = product.UserID,
                        CategoryID = product.CategoryID,
                        ItemConditionID = product.ItemConditionID,
                        CategoryDto = product?.Category != null ? new CategoryDto
                        {
                            Id = product.Category.ID,
                            Code = product.Category.Code,
                            Name = product.Category.Name,
                            Description = product.Category.Description,
                            CreatedBy = product.Category.CreatedBy,
                            UpdatedBy = product.Category.UpdatedBy,
                            CreatedDate = product.Category.CreatedDate,
                            ModifiedDate = product.Category.ModifiedDate,
                            IPAddress = product.Category.IPAddress,
                        } : new CategoryDto(),
                        ItemConditionDtos = product?.ItemCondition != null ? new ItemConditionDto
                        {
                            Id = product.ID,
                            State = product.ItemCondition.State,
                            Description = product.ItemCondition.Description,
                        } : new ItemConditionDto(),

                        ProductPicturesDtos = (from prodImg in product?.ProductPictures
                                               select new ProductPicturesDto
                                               {
                                                   Id = prodImg.ID,
                                                   Name = prodImg.Name,
                                                   Path = prodImg.Path,
                                                   Description = prodImg.Description,
                                               }).ToList(),

                        CreatedDate = product?.CreatedDate,
                        ModifiedDate = product?.ModifiedDate,
                        CreatedBy = product?.CreatedBy,
                        UpdatedBy = product?.UpdatedBy,
                        IPAddress = product?.IPAddress,                        
                    }).ToList();

        }


    }
}

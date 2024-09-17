using DataModel.DB;
using DataModel.Entity.AuctionEntity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Repository.Extention;
using Repository.Extention.AuctionDtoConversion;
using Repository.Repository.Auction.Contracts;
using SharedModel.AutionsDto;
using SharedModel.Dtos;
using System.Linq.Expressions;

namespace Repository.Repository.Auction
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
       
        private readonly IWebHostEnvironment env;
        public ProductRepository(AuctionDBContext context, ILogger<ProductRepository> logger,
            IWebHostEnvironment _env) : base(context, logger)
        {            
            env = _env;
        }

        public async Task<ProductDto> GetById(int id)
        {
            try
            {             
                var product = await _context.Product
                                         .Include(p => p.Category)
                                         .Include(p => p.ItemCondition)
                                         .Include(p => p.ProductPictures)                  
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync(s => s.ID == id);

                if(product == null) return null!;
              
                var productDto = product.ConvertToDto(); 

                return productDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Get by id method error", typeof(ProductRepository));
                throw new Exception($"Failed to find item with {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<ProductDto>> GetProducts(PagingRequestDto pagingRequestDto)
        {
            try
            {  
                var products = await _context.Product
                                    .SearchProduct(pagingRequestDto)
                                    .Include(p => p.ProductPictures)
                                    .Include(p => p.Category)
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .AsNoTracking()
                                    .ToListAsync();

                int ItemCount = await _context.Product.CountAsync();

                var productDtos = products.ConvertToDto();
                   
                return PagedList<ProductDto>.ToPagedList(productDtos, ItemCount, pagingRequestDto.PageNumber, pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetProducts() method error", typeof(ProductRepository));
                throw new Exception($"GetProducts method() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }

        public async Task<PagedList<ProductDto>> GetProductsFiltered(PagingRequestDto pagingRequestDto)
        {
            try
            {
                IQueryable<Product> productsQuery = from d in _context.Product.Include(p => p.ProductPictures) select d;
                int ItemCount = await productsQuery.CountAsync();

                productsQuery = productsQuery.SearchProduct(pagingRequestDto);

                if (string.Equals(pagingRequestDto.SortOrder?.Trim(), "desc", StringComparison.OrdinalIgnoreCase))
                {
                    productsQuery = productsQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderByDescending(GetSortProperty(pagingRequestDto));

                }
                else
                {
                    productsQuery = productsQuery
                                    .Skip((pagingRequestDto.PageNumber - 1) * pagingRequestDto.PageSize)
                                    .Take(pagingRequestDto.PageSize)
                                    .OrderBy(GetSortProperty(pagingRequestDto));
                }

                //var designationDtos = (from d in designationsQuery select new DesignationDto() {}).ToListAsync();

                var productsDtos =  productsQuery.ConvertToDto();  

                return PagedList<ProductDto>.ToPagedList(productsDtos, ItemCount, pagingRequestDto.PageNumber,
                    pagingRequestDto.PageSize);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} GetProducts Filtered() method error", typeof(ProductRepository));
                throw new Exception($"GetProducts Filtered() method() => Failed to fetch items from database " + $": {ex.Message}");
            }
        }

        private static Expression<Func<Product, object>>
            GetSortProperty(PagingRequestDto request) => request.SortColumn?.ToLower() switch
            {
                "name" => desig => desig.Name,
                "unitprice" => desig => desig.UnitPrice,
                "address" => desig => desig.Address,
                "description" => desig => desig.Description,
                "createddate" => desig => desig.CreatedDate,
                "IPAddress" => desig => desig.IPAddress,
                _ => desig => desig.ID

            };

        public async Task<VirtualizeResponse<ProductDto>> GetAllProducts(ItemRequestDto itemRequestDto)
        {
            var totalSize = await _context.Product.CountAsync();

            var items = await _context.Product
               .OrderBy(p => p.ID)
               .Skip(itemRequestDto.StartIndex)
               .Take(itemRequestDto.PageSize)
               .ToListAsync();

            var itemsDto = Mapping.Mapper.Map<List<ProductDto>>(items);

            return new VirtualizeResponse<ProductDto> { Items = itemsDto, TotalSize = totalSize };
        }

        public async Task<ProductDto> CreateProduct(ProductDto productDto)
        {
            try
            {
                var savedImages = await SaveImagesToLocalDirectory(productDto.ProductPicturesDtos,
                productDto.UserID, "Products");

                var product = new Product()
                {
                    Name = productDto.Name,
                    Description = productDto.Description,
                    Quantity = productDto.Quantity,
                    UnitPrice = productDto.UnitPrice,
                    Rating = productDto.Rating,
                    City = productDto.City,
                    Lng = productDto.Lng,
                    Lat = productDto.Lat,
                    Address = productDto.Address,
                    InspectionDate = productDto.InspectionDate,
                    InspectionSummary = productDto.InspectionSummary,
                    AuctionDate = productDto.AuctionDate,
                    AuctionEndDate = productDto.AuctionEndDate,
                    UserID = productDto.UserID,
                    CategoryID = productDto.CategoryID,
                    ItemConditionID = productDto.ItemConditionID,                    
                    CreatedBy = productDto.CreatedBy,
                    IPAddress = productDto.IPAddress,
                };

                if (savedImages != null)
                {
                    product.ProductPictures = (from img in savedImages
                                             select new ProductPictures
                                             {
                                                 Name = img.Name,
                                                 Description = img.Description,
                                                 Path = img.Path
                                             }).ToList();
                }
             
                var newItem = await Add(product);
                var newProduct = Mapping.Mapper.Map<ProductDto>(newItem);
                return newProduct;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} CreateProduct() method error", typeof(ProductRepository));
                throw new Exception($"Failed to create item {nameof(productDto)} in database " + $": {ex}");
            }
        }


        public async Task<ProductDto> UpdateProduct(ProductDto productDto)
        {
            try
            {
                var item = await Get(productDto.Id);

                if (item == null)
                {
                    return null!;
                }

                var savedImages = await SaveImagesToLocalDirectory(productDto.ProductPicturesDtos,
                                       productDto.UserID, "Products");

                item.Name = productDto.Name;
                item.Description = productDto.Description;
                item.UnitPrice = productDto.UnitPrice;
                item.Rating = productDto.Rating;
                item.Quantity = productDto.Quantity;
                item.Lat = productDto.Lat;
                item.Lng = productDto.Lng;
                item.City = productDto.City;
                item.InspectionDate = productDto.InspectionDate;
                item.InspectionSummary = productDto.InspectionSummary;
                item.Address = productDto.Address;
                item.AuctionDate = productDto.AuctionDate;
                item.AuctionEndDate = productDto.AuctionEndDate;
                item.CategoryID = productDto.CategoryID;
                item.ItemConditionID = productDto.ItemConditionID;
                item.IPAddress = productDto.IPAddress;
                item.ModifiedDate = productDto.ModifiedDate;
                item.ProductPictures = savedImages == null ?
                   Enumerable.Empty<ProductPictures>().ToList() :
                                      (from img in savedImages
                                      select new ProductPictures
                                      {
                                          Name = img.Name,
                                          Description = img.Description,
                                          Path = img.Path
                                      }).ToList();
                
                var updatedItem = await UpdateAsync(item);
                var updatedItemDto = Mapping.Mapper.Map<ProductDto>(updatedItem);
                return updatedItemDto;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} UpdateProduct() method error", typeof(ProductRepository));
                throw new Exception($"Failed to update {nameof(productDto)} in database " + $": {ex.Message}");
            }
        }

        public async Task<ProductDto?> DeleteProduct(int id)
        {
            try
            {
                var item = await _context.Product
                                         .Include(p => p.ProductPictures)
                                         .AsNoTracking()
                                         .FirstOrDefaultAsync(s => s.ID == id);

                if (item == null) return null!;

                var deletedItem = await DeleteAsync(item);

                if (deletedItem == null) throw new Exception("Failed to delete item  " + nameof(id));

                var deletedItemDto = Mapping.Mapper.Map<ProductDto>(deletedItem);

                if (item.ProductPictures.Any())
                    {
                        var status = await DeleteImageFolder("Products", deletedItem.UserID,
                            item?.ProductPictures?.FirstOrDefault()?.Description ?? throw new Exception("Failed to find file path to delete."));
                        if(status== false)
                        {
                            throw new Exception("Failed to delete image directory of product !");
                        }
                        
                        return deletedItemDto;
                    }
                return deletedItemDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteProduct() method error", typeof(ProductRepository));
                throw new Exception($"Failed to delete {nameof(id)} in database " + $": {ex.Message}");
            }
        }

        public async Task<bool> DeleteProducts(List<ProductDto> productDtos)
        {
            try
            {               
                var products = Mapping.Mapper.Map<List<Product>>(productDtos);             
                var deletedItemsStatus = await DeleteRangeAsync(products);
                if (deletedItemsStatus)
                {
                    productDtos.ForEach(async prod => await DeleteImageFolder("Products", prod.UserID,
                        prod?.ProductPicturesDtos?.FirstOrDefault()?.Description ?? throw new Exception("Failed to find file path to delete.")));
                }
                return deletedItemsStatus;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteProducts() method error", typeof(ProductRepository));
                throw new Exception($"Failed to delete {nameof(productDtos)} in database " + $": {ex.Message}");
            }
        }

        private async Task<List<ProductPicturesDto>> SaveImagesToLocalDirectory(ICollection<ProductPicturesDto> prodImgToAddDto,
           int userId, string primaryFolderName)
        {
            if (!prodImgToAddDto.Any() || string.IsNullOrEmpty(prodImgToAddDto?.FirstOrDefault()?.Base64data?.ToString()))
            {
                return null!;
            }
            try
            {   /*Create subfolder only if new producted is created. Do not create subfolder if product is updated */             
                var itemSubFolder = prodImgToAddDto.First().Description;
                if (prodImgToAddDto.First().Description.IsNullOrEmpty())
                {
                    itemSubFolder = "Prod" + "ID" + userId + new Random().Next(1, 200).ToString();
                    
                }
               
                var prodImagesSaved = new List<ProductPicturesDto>();
                foreach (var file in prodImgToAddDto)
                {
                    var buf = Convert.FromBase64String(file.Base64data);
                    var folderPath = Path.Combine($"Resource\\Static\\{primaryFolderName}\\ID{userId}",itemSubFolder);
                    var pathToSave = Path.Combine(env.ContentRootPath, folderPath); //or Directory.GetCurrentDirectory()
                    System.IO.Directory.CreateDirectory(pathToSave);
                    await System.IO.File.WriteAllBytesAsync(pathToSave + Path.DirectorySeparatorChar
                        + file.FileName, buf);

                    prodImagesSaved.Add(new ProductPicturesDto
                    {
                        Name = file.FileName,
                        Path = "Static/" + primaryFolderName + "/" +"ID"+ userId + "/" + itemSubFolder + "/"+ file.FileName,
                        Description = itemSubFolder,
                    });
                }
                return prodImagesSaved;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<bool> DeleteImageFolder(string primaryFolderName, int userId, string itemSubFolder)
        {
            try
            {
                var folderPath = Path.Combine($"Resource\\Static\\{primaryFolderName}\\ID{userId}", itemSubFolder);

                var fullPathToDelete = Path.Combine(env.ContentRootPath, folderPath); //or Directory.GetCurrentDirectory() 
                if (Directory.Exists(fullPathToDelete))
                {
                    DirectoryInfo directory = new DirectoryInfo(fullPathToDelete);
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        file.Delete();
                    }
                    Directory.Delete(fullPathToDelete);
                    return true;
                }
                return await Task.FromResult(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.Message);
                _logger.LogError(ex, "{Repo} DeleteImageFolder() method error, failed to delete image folder!!", typeof(ProductRepository));
                throw new Exception($"Failed to delete images folder on server. " + $": {ex.Message}");
            }


        }

        public async Task<ServiceResponse<ProductPicturesDto>> DeleteProductPicture(int id)
        {
            try
            {
                var res = new ServiceResponse<ProductPicturesDto>();
                var productImg = await _context.ProductPictures.FindAsync(id);
                if (productImg == null)
                {
                    res.StatusCode = 404;
                }
                else
                {
                    _context.ProductPictures.Remove(productImg);
                    var delStatus = await _context.SaveChangesAsync();
                    if (delStatus > 0)
                    {
                        var result = await DeleteImageFileOnServer(productImg);
                        if (result == true)
                        {
                            res.StatusCode = 200;
                            res.Data = Mapping.Mapper.Map<ProductPicturesDto>(productImg);
                        }
                        else
                        {
                            res.StatusCode = 500;
                        }
                    }
                    else
                    {
                        res.StatusCode = 500;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} DeleteProductImage() method error, failed to delete image !!", typeof(ProductRepository));
                throw new Exception($"Failed to delete images from DB. " + $": {ex.Message}");
            }

        }


        private async Task<bool> DeleteImageFileOnServer(ProductPictures productImage)
        {
            try
            {
                /*Returns file info, fileName attribute has full path name */
                //FileInfo file = new FileInfo(Path.Combine( env.ContentRootPath ,productImage.Path));

                //This method returns full path of file /
                string baseFolder = "Resource";
                var basePath = Path.GetFullPath(Path.Combine(env.ContentRootPath, baseFolder));
                var absolutePath = Path.Combine(basePath, productImage.Path);

                if (File.Exists(absolutePath))
                {
                    File.Delete(absolutePath);
                    return true;
                }
                return await Task.FromResult(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting file on server : " + ex);
                throw;
            }


        }

        /* This is temporary function created in Dev mode to seed test data, remove this functoin from prod. Controller function needs
         to be added to call this function.*/
        public async Task SeedingProductPicturesDataTable()
        {
            try
            {
                /*var customersToDelete = await SearchCustomer("will", null);
                bool deleteStatus = await DeleteRangeAsync(customersToDelete);
                if (deleteStatus) Console.WriteLine("Is Customer deleted : " + deleteStatus);*/

                var nproductPics = new List<ProductPictures>();

                for (int i = 25; i < 869; i++)
                {
                    var pp1 = new ProductPictures
                    {
                        Name = "abu-dhabi-x1.jpg",
                        Path = "Static/Products/ID25/ProdID25900/abu-dhabi-x1.jpg",
                        Description = "ProdID25900",
                        ProductID = i,
                        CreatedDate = DateTime.UtcNow.AddHours(12),                    
                        IPAddress = "180.23.36.89",
                        CreatedBy = "Ron_cr",

                    };
                    nproductPics.Add(pp1);
                    var pp2 = new ProductPictures
                    {
                        Name = "abu-dhabi-x2.jpg",
                        Path = "Static/Products/ID25/ProdID25900/abu-dhabi-x2.jpg",
                        Description = "ProdID25900",
                        ProductID = i,
                        CreatedDate = DateTime.UtcNow.AddHours(12),
                        IPAddress = "180.23.36.89",
                        CreatedBy = "Ron_cr",

                    };
                    nproductPics.Add(pp2);
                }

                await _context.ProductPictures.AddRangeAsync(nproductPics);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Product pictures Seeding method error", typeof(ProductRepository));
                throw new Exception($"Failed to seed Product pictures  in database " +
                    $": {ex.Message}");
            }
        }




    }
}

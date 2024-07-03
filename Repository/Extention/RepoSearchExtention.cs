using DataModel.Entity;
using SharedModel.Dtos;
using Microsoft.IdentityModel.Tokens;
using DataModel.Entity.AuctionEntity;
using DataModel.Entity.Jobs;


namespace Repository.Extention
{
    public static class RepoSearchExtention
    {
        public static IQueryable<User> SearchUser(this IQueryable<User> users, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return users;

            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();
            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();

            if (columnName == "firstname")
            {
                return users.Where(c => c.FirstName.ToLower().Contains(searchText));
            }
            if (columnName == "lastname")
            {
                return users.Where(c => c.LastName.ToLower().Contains(searchText));
            }
            if (columnName == "email")
            {
                return users.Where(c => c.Email.ToLower().Contains(searchText));
            }
            return users;
        }

        public static IQueryable<Role> SearchRole(this IQueryable<Role> roles, PagingRequestDto pagedRequestDto)
        {
            if (string.IsNullOrWhiteSpace(pagedRequestDto.ColumnName) || string.IsNullOrWhiteSpace(pagedRequestDto.SearchTerm))
                return roles;

            var searchText = pagedRequestDto.SearchTerm.Trim().ToLower();
            var columnName = pagedRequestDto.ColumnName.Trim().ToLower();

            if (columnName == "name")
            {
                return roles.Where(c => c.Name.Contains(searchText));
            }
            if (columnName == "description")
            {
                return roles.Where(c => c.Description.Contains(searchText));
            }
            return roles;
        }

        public static IQueryable<Designation> SearchDesignation(this IQueryable<Designation> designations, PagingRequestDto pagedRequestDto)
        {
            
            if(pagedRequestDto.FilterList.Count == 0)
            {
                return designations;
            }

            foreach (var keyValue in pagedRequestDto.FilterList)
            {
                try
                {
                    var columnName = keyValue.Key;
                    var columnValue = keyValue.Value;                

                    if (columnName.ToLower() == "jobtitle")
                    {
                        designations = designations.Where(d => d.JobTitle.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "description")
                    {
                        designations = designations.Where(d => d.Description.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "createddate")
                    {
                        DateTime createdDate = DateTime.Parse(columnValue); // This format adds flexibility to search.
                        designations = designations.Where(d => d.CreatedDate >= createdDate.Date &&
                        d.CreatedDate <= createdDate.AddDays(1).Date);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Failed to extract table filter data from api ." + e);
                }
            }    
            return designations;
            
        }

        // Auction repository search functionality ext
    
        public static IQueryable<Category> SearchCategory(this IQueryable<Category> categories, PagingRequestDto pagedRequestDto)
        {            
            if (pagedRequestDto.FilterList.Count == 0)
            {
                return categories;
            }
          

            foreach (var keyValue in pagedRequestDto.FilterList)
            {
                try
                {
                    var columnName = keyValue.Key;
                    var columnValue = keyValue.Value;

                    if (columnName.ToLower() == "code")
                    {
                        categories = categories.Where(d => d.Code.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "name")
                    {
                        categories = categories.Where(d => d.Name.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "createddate")
                    {
                        DateTime createdDate = DateTime.Parse(columnValue); // This format adds flexibility to search.
                        categories= categories.Where(d => d.CreatedDate >= createdDate.Date &&
                        d.CreatedDate <= createdDate.AddDays(1).Date);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Failed to extract table filter data from api ." + e);
                }
            }

            return categories;

        }

        public static IQueryable<Product> SearchProduct(this IQueryable<Product> products, PagingRequestDto pagedRequestDto)
        {
            if (pagedRequestDto.FilterList.Count == 0)
            {
                return products;
            }

            foreach (var keyValue in pagedRequestDto.FilterList)
            {
                try
                {
                    var columnName = keyValue.Key;
                    var columnValue = keyValue.Value;
                    if(columnName.IsNullOrEmpty() || columnValue.IsNullOrEmpty()) return products;

                    if (columnName.ToLower() == "userid")
                    {
                        products = products.Where(d => d.UserID == int.Parse(columnValue));
                    }
                    if (columnName.ToLower() == "name")
                    {
                        products = products.Where(d => d.Name.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "description")
                    {
                        products = products.Where(d => d.Description.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "unitprice")
                    {
                        products = products.Where(d => d.UnitPrice <= decimal.Parse(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "address")
                    {
                        products = products.Where(d => d.Address.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "category")
                    {
                        products = products.Where(d => d.CategoryID == int.Parse(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "createddate")
                    {
                        DateTime createdDate = DateTime.Parse(columnValue); // This format adds flexibility to search.
                        products = products.Where(d => d.CreatedDate >= createdDate.Date &&
                        d.CreatedDate <= createdDate.AddDays(1).Date);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Failed to extract table filter data from api ." + e);
                }
            }
            return products;
        }

        public static IQueryable<JobPost> SearchJobPost(this IQueryable<JobPost> jobPosts, PagingRequestDto pagedRequestDto)
        {
            if (pagedRequestDto.FilterList.Count == 0)
            {
                return jobPosts;
            }

            foreach (var keyValue in pagedRequestDto.FilterList)
            {
                try
                {
                    var columnName = keyValue.Key;
                    var columnValue = keyValue.Value;
                    if (columnName.IsNullOrEmpty() || columnValue.IsNullOrEmpty()) return jobPosts;

                    if (columnName.ToLower() == "jobtitle")
                    {
                        jobPosts= jobPosts.Where(d => d.JobTitle.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "jobtype")
                    {
                        jobPosts = jobPosts.Where(d => d.JobType.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "category")
                    {
                        jobPosts = jobPosts.Where(d => d.Category.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "country")
                    {
                        jobPosts = jobPosts.Where(d => d.Country.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "isactive")
                    {
                        jobPosts = jobPosts.Where(d => d.IsActived);
                    }
                    if (columnName.ToLower() == "description")
                    {
                        jobPosts = jobPosts.Where(d => d.Description.ToLower().Contains(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "organisation")
                    {
                        jobPosts = jobPosts.Where(d => d.OrganisationID == int.Parse(columnValue.ToLower()));
                    }
                    if (columnName.ToLower() == "createddate")
                    {
                        DateTime createdDate = DateTime.Parse(columnValue); // This format adds flexibility to search.
                        jobPosts = jobPosts.Where(d => d.CreatedDate >= createdDate.Date &&
                        d.CreatedDate <= createdDate.AddDays(1).Date);
                    }
                    if (columnName.ToLower() == "closingdate")
                    {
                        DateTime closingDate = DateTime.Parse(columnValue); // This format adds flexibility to search.
                        jobPosts = jobPosts.Where(d => d.ClosingDate >= closingDate.Date &&
                        d.ClosingDate <= closingDate.AddDays(1).Date);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Failed to extract table filter data from api ." + e);
                }
            }
            return jobPosts;
        }

    }


}

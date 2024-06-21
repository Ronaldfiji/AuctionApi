using AutoMapper;
using DataModel.Entity;
using DataModel.Entity.AuctionEntity;
using DataModel.Entity.Jobs;
using SharedModel.AutionsDto;
using SharedModel.Dtos;
using SharedModel.JobsDto;


namespace Repository.Extention
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Designation, DesignationDto>().ReverseMap();
            CreateMap<UserType, UserTypeDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductPictures,ProductPicturesDto>().ReverseMap();
            CreateMap<ItemCondition, ItemConditionDto>().ReverseMap();
            CreateMap<Organisation, OrganisationDto>().ReverseMap();
            CreateMap<JobPost, JobPostDto>().ReverseMap();
            //CreateMap<CustomerDTO, Customer>()
            //  .ForMember(dest => dest.Id, opt => opt.Ignore());

        }
    }

    public static class Mapping
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg => {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<ProfileMapper>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }

}


/* CreateMap<Product, ProductCategoryDto>().ReverseMap()
    .ForMember(dest => dest.Category.Name, opt => opt.MapFrom(src => src.CategoryName));

CreateMap<ProductCategoryDto, Product>().ReverseMap()
    .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

CreateMap<Product, ProductCategoryDto>()
.ForMember(dst => dst.CategoryName, opt => opt.MapFrom(src => src.Category.Name));*/



/*CreateMap<GetUserProfileDTO, ApplicationUser>().ReverseMap();
CreateMap<ApplicationUser, ServiceResponse<ApplicationUser>>().ReverseMap();
CreateMap<GetUserProfileDTO, ServiceResponse<ApplicationUser>>().ReverseMap();
CreateMap<Projects, ProjectsMapper.CreateProjectsDTO>().ReverseMap();
CreateMap<Projects, ProjectsMapper.EditProjectsDTO>().ReverseMap();
CreateMap<CreateUserProfileDTO, ApplicationUser>()
        .ForMember(dest =>
                dest.PasswordHash,
                opt => opt.MapFrom(src => src.Password))                    
        .ForMember(dest => dest.DOB, opt => opt.MapFrom(src => !string.IsNullOrEmpty(src.DOB)
        ? DateTime.Parse(src.DOB): nullDate));

*/


//.ForMember(dest => dest.DOB, opt => opt.MapFrom(src => ToDateTime(src.DOB)));
// .ForMember(dest => dest.DOB, opt => opt.MapFrom(src => Convert.ToDateTime(src.DOB))) //s => Convert.ToDateTime(s.EndDate))
// .ForMember(dest => dest.DOB, opt => opt.MapFrom(src => DateTime.Parse(src.DOB.ToString())))
//.ForMember(dest => dest.DOB, opt => opt.MapFrom(src => DateTime.ParseExact(src.DOB, "", CultureInfo.InvariantCulture)));
//.ForMember(dest => dest.DOB, opt => opt.Ignore());             
//.ReverseMap();

/*CreateMap<ApplicationUser, CreateUserProfileDTO>()
    .ForMember(dest =>
            dest.Password,
            opt => opt.MapFrom(src => src.PasswordHash))        
    .ReverseMap();
*/
namespace Handler.Mapping.Categories
{
    public class AddCtegoryMapping : Profile
    {
        public AddCtegoryMapping()
        {
            CreateMap<AddCategoryCommand, Category>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId));
        }
    }
}

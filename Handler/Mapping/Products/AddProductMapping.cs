namespace Handler.Mapping.Products
{
    public class AddProductMapping : Profile
    {
        public AddProductMapping() {
            
            CreateMap<AddProductCommand, Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Brand, opt => opt.MapFrom(src => src.Brand))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.Color))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.CartId, opt => opt.MapFrom(src => src.CartId))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(s1 => s1.Image1, p1 => p1.Ignore())
                .ForMember(s2 => s2.Image2, p2 => p2.Ignore())
                .ForMember(s3 => s3.Image3, p3 => p3.Ignore());
        }
    }
}

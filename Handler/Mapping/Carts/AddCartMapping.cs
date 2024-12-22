namespace Handler.Mapping.Carts
{
    public class AddCartMapping : Profile
    {
        public AddCartMapping() {

            CreateMap<AddCartCommand, Cart>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Custom, opt => opt.MapFrom(src => src.Custom))
                .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Size)) 
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.OrderId)); 
        }
    }
}

namespace Handler.Mapping.Orders
{
    public class UpdateOrderMapping : Profile
    {
        public UpdateOrderMapping()
        {

            CreateMap<UpdateOrderCommand, Order>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State))
                .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(src => src.ZipCode))
                .ForMember(dest => dest.Contact, opt => opt.MapFrom(src => src.Contact))
                .ForMember(dest => dest.CartId, opt => opt.MapFrom(src => src.CartId));
        }
    }
}

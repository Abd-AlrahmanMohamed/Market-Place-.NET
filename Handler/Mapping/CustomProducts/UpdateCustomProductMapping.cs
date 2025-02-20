namespace Handler.Mapping.CustomProducts
{
    public class UpdateCustomProductMapping : Profile
    {
        public UpdateCustomProductMapping() {

            CreateMap<UpdateCustomProductCommand, CustomProduct>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.Cost, opt => opt.MapFrom(src => src.Cost))
                .ForMember(dest => dest.UserUploadId, opt => opt.MapFrom(src => src.UserUploadId))
                .ForMember(dest => dest.Image, opt => opt.Ignore());

        }
    }
}

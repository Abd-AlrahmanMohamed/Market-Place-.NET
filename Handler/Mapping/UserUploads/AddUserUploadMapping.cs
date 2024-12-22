namespace Handler.Mapping.UserUploads
{
    public class AddUserUploadMapping : Profile
    {
        public AddUserUploadMapping()
        {

            CreateMap<AddUserUploadCommand, UserUpload>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CustomProductId, opt => opt.MapFrom(src => src.CustomProductId))
                .ForMember(dest => dest.Image, opt => opt.Ignore());

        }
    }
}

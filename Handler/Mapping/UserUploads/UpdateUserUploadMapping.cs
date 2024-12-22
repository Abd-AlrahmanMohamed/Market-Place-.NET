namespace Handler.Mapping.UserUploads
{
    public class UpdateUserUploadMapping : Profile
    {
        public UpdateUserUploadMapping()
        {

            CreateMap<UpdateUserUploadCommand, UserUpload>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CustomProductId, opt => opt.MapFrom(src => src.CustomProductId))
                .ForMember(dest => dest.Image, opt => opt.Ignore());

        }
    }
}

namespace Handler.MediatorHandler.MediatorCommand.UserUploads
{
    public class UpdateUserUploadCommand : IRequest<UserUpload>
    {
        public int Id { get; set; }

        public IFormFile Image { get; set; }

        public int CustomProductId { get; set; }


        public UpdateUserUploadCommand(UserUploadDto userUploadDto)
        {
            Id = userUploadDto.Id;
            Image = userUploadDto.Image;
            CustomProductId = userUploadDto.CustomProductId;
        }
    }

}

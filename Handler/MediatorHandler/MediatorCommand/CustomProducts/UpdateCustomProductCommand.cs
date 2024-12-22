namespace Handler.MediatorHandler.MediatorCommand.CustomProducts
{
    public class UpdateCustomProductCommand : IRequest<CustomProduct>
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public IFormFile Image { get; set; }
        public double Cost { get; set; }
        public int UserUploadId { get; set; }

        public UpdateCustomProductCommand(CustomProductDto customProductDto)
    {
        Id = customProductDto.Id;
        Title = customProductDto.Title;
        Cost = customProductDto.Cost;
        Image = customProductDto.Image;
        UserUploadId = customProductDto.UserUploadId;
    }
    }
}

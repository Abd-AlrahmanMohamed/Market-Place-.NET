namespace Handler.Dto
{
    public class UserUploadDto
    {
        public int Id { get; set; }
        public IFormFile Image { get; set; }
        public int CustomProductId { get; set; }
        
    }
}

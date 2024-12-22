namespace Handler.Dto
{
    public class CustomProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IFormFile Image { get; set; }
        public double Cost { get; set; }
        public int UserUploadId { get; set; }
    }
}

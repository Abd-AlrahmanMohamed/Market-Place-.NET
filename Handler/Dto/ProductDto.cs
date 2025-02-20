namespace Handler.Dto
{
    public class ProductDto
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<IFormFile> Images { get; set; } = new List<IFormFile>();
        public string Brand { get; set; } = string.Empty;
        public List<string> Colors { get; set; } = new List<string>();
        public double Price { get; set; }
        public int CartId { get; set; }
        public int CategoryId { get; set; }
    }
}

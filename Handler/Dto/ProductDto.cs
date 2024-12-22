namespace Handler.Dto
{
    public class ProductDto
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile Image1 { get; set; }
        public IFormFile Image2 { get; set; }
        public IFormFile Image3 { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public double Price { get; set; }
        public int CartId { get; set; }
        public int CategoryId { get; set; }
    }
}

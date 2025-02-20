namespace Handler.MediatorHandler.MediatorCommand.Products
{
    public class AddProductCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<IFormFile> Images { get; set; } = new List<IFormFile>();
        public string Brand { get; set; } = string.Empty;
        public List<string> Colors { get; set; } = new List<string>();
        public double Price { get; set; }
        public int CartId { get; set; }
        public int CategoryId { get; set; }

        public AddProductCommand(ProductDto productDto)
        {
            Id = productDto.Id;
            Name = productDto.Name;
            Description = productDto.Description;
            Images = productDto.Images;
            Brand = productDto.Brand;
            Colors = productDto.Colors;
            Price = productDto.Price;
            CartId = productDto.CartId;
            CategoryId = productDto.CategoryId;
        }
    }
}

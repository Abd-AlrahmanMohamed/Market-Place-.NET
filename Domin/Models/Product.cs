namespace Domin.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; } =string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new List<string>();
        public string Brand { get; set; } = string.Empty;
        public List<string> Colors { get; set; } = new List<string>();
        public double Price { get; set; }

        public int CartId { get; set; }
        public IList<Cart> Carts { get; set; } = new List<Cart>();
        public int CategoryId { get; set; }
        public IList<Category> Categories { get; set; } = new List<Category>();
        public IList<CartProduct> CartProducts { get; set; } = new List<CartProduct>();

    }
}

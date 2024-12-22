using System.Text.Json.Serialization;

namespace Domin.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string Custom { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
        public int OrderId { get; set; }
        public IList<Order> Orders { get; set; } = new List<Order>();
        public IList<CartProduct> CartProducts { get; set; } = new List<CartProduct>();

    }
}

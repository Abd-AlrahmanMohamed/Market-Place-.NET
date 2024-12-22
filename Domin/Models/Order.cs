using System.Text.Json.Serialization;

namespace Domin.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public int ZipCode { get; set; }
        public int Contact { get; set; }
        public int CartId { get; set; }
        public Cart Carts { get; set; } = new Cart();
        
    }
}

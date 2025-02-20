using System.Text.Json.Serialization;

namespace Domin.Models
{
    public class UserUpload
    {
        public int Id { get; set; }
        public string Image { get; set; } = string.Empty;
        public int CustomProductId { get; set; }
        public CustomProduct CustomProducts { get; set; } = new CustomProduct();
    }
}

using System.Text.Json.Serialization;

namespace Domin.Models
{
    public class UserUpload
    {
        public int Id { get; set; }
        public byte[] Image { get; set; } = new byte[0];
        public int CustomProductId { get; set; }
        //[JsonIgnore]
        public CustomProduct CustomProducts { get; set; } = new CustomProduct();
    }
}

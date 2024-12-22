using System.Text.Json.Serialization;

namespace Domin.Models
{
    public class CustomProduct
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public  byte[] Image { get; set; } = new byte[0];
        public double Cost { get; set; }
        public int UserUploadId { get; set; }
        public IList<UserUpload> UserUploads { get; set; } = new List<UserUpload>();
    }
}

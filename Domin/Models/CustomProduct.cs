using System.Text.Json.Serialization;

namespace Domin.Models
{
    public class CustomProduct
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public  string Image { get; set; } = string.Empty;
        public double Cost { get; set; }
        public int UserUploadId { get; set; }
        public IList<UserUpload> UserUploads { get; set; } = new List<UserUpload>();
    }
}

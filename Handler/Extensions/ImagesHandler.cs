using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler.Extensions
{
  public static class ImagesHandler
{
    public static async Task<List<string>> ImagesConverterAsync(List<IFormFile> images)
    {
        var imageBase64List = new List<string>();

        if (images == null || images.Count == 0)
            return imageBase64List;

        foreach (var image in images)
        {
            if (image != null)
            {
                using var dataStream = new MemoryStream();
                await image.CopyToAsync(dataStream);

                // Convert byte array to base64 string
                string base64Image = Convert.ToBase64String(dataStream.ToArray());

                // Add base64 string to the list
                imageBase64List.Add(base64Image);
            }
        }

        return imageBase64List;
    }
}

}

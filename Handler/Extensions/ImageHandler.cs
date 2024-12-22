namespace Handler.Extensions
{
    public static class ImageHandler
    {
        public static async Task<byte[]> ImageConverterAsync(IFormFile image)
        {
            if (image == null)
                return null;

            using var dataStream = new MemoryStream();
            await image.CopyToAsync(dataStream);
            return dataStream.ToArray();
        }
    }
}

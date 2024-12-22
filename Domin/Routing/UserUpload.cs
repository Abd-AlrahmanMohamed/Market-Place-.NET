namespace Domin.Routing.BaseRouter
{
    public partial class Router
    {
        public static class UserUpload
        {
            private const string Prefix = Rule + "UserUpload";
            public const string Get = Prefix;
            public const string GetUserUploadById = Prefix + "/get-product-by-id";
            public const string GetAllUserUploads = Prefix + "/get-all-products";
            public const string AddUserUpload = Prefix + "/add-product";
            public const string UpdateUserUpload = Prefix + "/update-product";
            public const string DeleteUserUpload = Prefix + "/delete-product";
        }
    }
}
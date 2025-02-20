namespace Domin.Routing.BaseRouter
{
    public partial class Router
    {
        public static class CustomProduct
        {
            private const string Prefix = Rule + "CustomProduct";
            public const string Get = Prefix;
            public const string GetCustomProductById = Prefix + "/get-customproduct-by-id";
            public const string GetAllCustomProducts = Prefix + "/get-all-customproducts";
            public const string AddCustomProduct = Prefix + "/add-customproduct";
            public const string UpdateCustomProduct = Prefix + "/update-customproduct";
            public const string DeleteCustomProduct = Prefix + "/delete-customproduct";
        }
    }
}

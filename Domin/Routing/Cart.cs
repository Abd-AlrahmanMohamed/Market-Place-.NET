namespace Domin.Routing.BaseRouter
{
    public partial class Router
    {
        public static class Cart
        {
            private const string Prefix = Rule + "Cart";
            public const string Get = Prefix;
            public const string GetCartById = Prefix + "/get-cart-by-id";
            public const string GetAllCarts = Prefix + "/get-all-carts";
            public const string AddCart = Prefix + "/add-cart";
            public const string UpdateCart = Prefix + "/update-cart";
            public const string DeleteCart = Prefix + "/delete-cart";
        }
    }
}

namespace Domin.Routing.BaseRouter
{
    public partial class Router
    {
        public static class Order
        {
            private const string Prefix = Rule + "Order";
            public const string Get = Prefix;
            public const string GetOrderById = Prefix + "/get-order-by-id";
            public const string GetAllOrders = Prefix + "/get-all-orders";
            public const string AddOrder = Prefix + "/add-order";
            public const string UpdateOrder = Prefix + "/update-order";
            public const string DeleteOrder = Prefix + "/delete-order";
        }
    }
}

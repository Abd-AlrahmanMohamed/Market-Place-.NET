namespace Domin.Routing.BaseRouter
{
    public partial class Router
    {
        public static class Category
        {
            private const string Prefix = Rule + "Category";
            public const string Get = Prefix;
            public const string GetCategorytById = Prefix + "/get-category-by-id";
            public const string GetAllCategories = Prefix + "/get-all-categories";
            public const string AddCategory = Prefix + "/add-category";
            public const string UpdateCategory = Prefix + "/update-category";
            public const string DeleteCategory = Prefix + "/delete-category";
        }
    }
}

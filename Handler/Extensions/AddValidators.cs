namespace Handler.Extensions
{
    public static class AddValidators
    {
        public static void Validators(this IServiceCollection services)
        {
            //Cart
            services.AddValidatorsFromAssembly(typeof(AddCartCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(UpdateCartCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(DeleteCartCommand).Assembly);

            //Category
            services.AddValidatorsFromAssembly(typeof(AddCategoryCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(UpdateCategoryCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(DeleteCategoryCommand).Assembly);

            //CustomProduct
            services.AddValidatorsFromAssembly(typeof(AddCustomProductCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(UpdateCustomProductCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(DeleteCustomProductCommand).Assembly);

            //Order
            services.AddValidatorsFromAssembly(typeof(AddOrderCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(UpdateOrderCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(DeleteOrderCommand).Assembly);

            //Product
            services.AddValidatorsFromAssembly(typeof(AddProductCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(UpdateProductCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(DeleteProductrCommand).Assembly);

            //UserUpload
            services.AddValidatorsFromAssembly(typeof(AddUserUploadCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(UpdateUserUploadCommand).Assembly);
            services.AddValidatorsFromAssembly(typeof(DeleteUserUploadCommand).Assembly);

        }

    }
}

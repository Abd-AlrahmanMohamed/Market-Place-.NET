namespace Infrastructure.Configurations
{
    public class CartProductConfigurations : IEntityTypeConfiguration<CartProduct>
    {
        public void Configure(EntityTypeBuilder<CartProduct> builder)
        {
            builder
                .HasKey(cp => new { cp.CartId, cp.ProductId });

		}
    }
}


namespace Infrastructure.Configurations
{
    public class AddProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.Description)
                .HasMaxLength(500);
            builder
                .Property(p => p.Images)
                .IsRequired();
            builder
                .Property(p => p.Price)
                .IsRequired();
        }
    }
}

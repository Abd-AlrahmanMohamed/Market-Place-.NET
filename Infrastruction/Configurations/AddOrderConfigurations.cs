
namespace Infrastructure.Configurations
{
    public class AddOrderConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .Property(o => o.Contact)
                .IsRequired();
            builder
                .HasOne(o => o.Carts)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.CartId);
        }
    }
}

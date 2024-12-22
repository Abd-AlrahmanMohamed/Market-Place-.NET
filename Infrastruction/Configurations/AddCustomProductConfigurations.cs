
namespace Infrastructure.Configurations
{
    public class AddCustomProductConfigurations : IEntityTypeConfiguration<CustomProduct>
    {
        public void Configure(EntityTypeBuilder<CustomProduct> builder)
        {
            builder
                .Property(cp => cp.Cost)
                .IsRequired();
            builder
               .Ignore(o => o.UserUploads);
        }
    }
}

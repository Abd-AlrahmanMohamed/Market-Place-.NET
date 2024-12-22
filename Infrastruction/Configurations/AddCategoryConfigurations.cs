
namespace Infrastructure.Configurations
{
    public class AddCategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(x => x.Description)
                .HasMaxLength(500);
            builder
                .HasOne(x => x.Product)
                .WithMany(c => c.Categories)
                .HasForeignKey(c => c.ProductId);
        }
    }
}

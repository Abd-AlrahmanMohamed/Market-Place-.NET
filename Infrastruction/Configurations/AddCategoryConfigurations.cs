
namespace Infrastructure.Configurations
{
    public class AddCategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(x => x.Description)
                .HasMaxLength(500);

        }
    }
}

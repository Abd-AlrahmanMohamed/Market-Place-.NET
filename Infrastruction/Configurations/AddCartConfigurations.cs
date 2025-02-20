using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infrastructure.Configurations
{
    public class AddCartConfigurations : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {

            builder
                .Property(c => c.Quantity)
                .IsRequired();
            
            builder
                .Property(c => c.Size)
                .IsRequired();
            builder
                .HasMany(c => c.Orders)
                .WithOne(o => o.Carts)
                .HasForeignKey(o => o.CartId)
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}

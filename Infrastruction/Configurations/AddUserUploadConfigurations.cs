namespace Infrastructure.Configurations
{
    public class AddUserUploadConfigurations : IEntityTypeConfiguration<UserUpload>
    {
        public void Configure(EntityTypeBuilder<UserUpload> builder)
        {
            builder
                .HasOne(u => u.CustomProducts)
                .WithMany(o => o.UserUploads)
                .HasForeignKey(o => o.CustomProductId);
           
        }
    }
}

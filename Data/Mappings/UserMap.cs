using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

            builder.Property(x => x.Bio)
            .IsRequired();
            builder.Property(x => x.Email)
            .IsRequired();
            builder.Property(x => x.Image)
            .IsRequired();
            builder.Property(x => x.Slug)
            .IsRequired();
            builder.Property(x => x.PasswordHash)
            .IsRequired();

            builder.HasIndex(x => x.Slug, "IX_User_Slug").IsUnique();
        }
    }
}
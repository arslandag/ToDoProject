using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetProject.Core.Models;

namespace PetProject.Persistence.Configuration;
public class TargetConfiguration : IEntityTypeConfiguration<Target>
{
    public void Configure(EntityTypeBuilder<Target> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(Target.MAX_LENGTH_NAME);

        builder.Property(t => t.Description)
            .IsRequired()
            .HasMaxLength(Target.MAX_LENGTH_DESCRIPTION);
    }
}

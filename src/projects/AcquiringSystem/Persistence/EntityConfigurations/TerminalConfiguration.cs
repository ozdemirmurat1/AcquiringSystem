using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class TerminalConfiguration : IEntityTypeConfiguration<Terminal>
    {
        public void Configure(EntityTypeBuilder<Terminal> builder)
        {
            builder.ToTable("Terminals").HasKey(u => u.Id);

            builder.Property(u => u.Id).HasColumnName("Id").IsRequired();
            builder.Property(u => u.TerminalIdentification).HasColumnName("TerminalIdentification").IsRequired();
            builder.Property(u => u.InformationMessage).HasColumnName("InformationMessage").IsRequired();
            builder.Property(u => u.DeviceBrand).HasColumnName("DeviceBrand").IsRequired();
            builder.Property(u => u.DeviceModel).HasColumnName("DeviceModel").IsRequired();
        }
    }
}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class MerchantConfiguration : IEntityTypeConfiguration<Merchant>
    {
        public void Configure(EntityTypeBuilder<Merchant> builder)
        {
            builder.ToTable("Merchants").HasKey(u => u.Id);

            builder.Property(u => u.MerchantNumber).HasColumnName("MerchantNumber").IsRequired();
            builder.Property(u => u.MerchantName).HasColumnName("MerchantName").IsRequired();
            builder.Property(u => u.Province).HasColumnName("Province").IsRequired();
            builder.Property(u => u.District).HasColumnName("District").IsRequired();
            builder.Property(u => u.Address).HasColumnName("Address").IsRequired();
            builder.Property(u => u.Email).HasColumnName("Email").IsRequired();
            builder.Property(u => u.TelephoneNumber).HasColumnName("TelephoneNumber").IsRequired();

            builder.HasOne(m => m.Chain)
            .WithMany(c => c.Merchants)
            .HasForeignKey(m => m.ChainId)
            .IsRequired();


            builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);
        }
    }
}

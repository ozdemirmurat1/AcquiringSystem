using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class ChainConfiguration : IEntityTypeConfiguration<Chain>
    {
        public void Configure(EntityTypeBuilder<Chain> builder)
        {
            builder.ToTable("Chains").HasKey(u => u.Id);

            builder.Property(u => u.Id).HasColumnName("Id").IsRequired();
            builder.Property(u => u.ChainCode).HasColumnName("ChainCode").IsRequired();
            builder.Property(u => u.TaxAdministration).HasColumnName("TaxAdministration").IsRequired();
            builder.Property(u => u.IdType).HasColumnName("IdType").IsRequired();

            builder.HasMany(c => c.Merchants)
           .WithOne(m => m.Chain)
           .HasForeignKey(m => m.ChainId);

            // .OnDelete(DeleteBehavior.Cascade);  Eğer bir Chain silinirse, bağlı tüm Merchants'lar da silinir.

            builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);
        }
    }
}

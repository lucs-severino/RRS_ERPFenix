using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Data.Configurations
{
    public class BancoConfiguration : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Codigo).HasMaxLength(10);
            builder.Property(b => b.Nome).HasMaxLength(100);
            builder.Property(b => b.Url).HasMaxLength(250);

            builder.HasMany(b => b.BancoAgencias)
                   .WithOne(ba => ba.Banco)
                   .HasForeignKey(ba => ba.BancoId);
        }
    }
}

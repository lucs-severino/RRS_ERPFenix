using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Data.Configurations
{
    public class BancoAgenciaConfiguration : IEntityTypeConfiguration<BancoAgencia>
    {
        public void Configure(EntityTypeBuilder<BancoAgencia> builder)
        {
            builder.HasKey(ba => ba.Id);

            builder.Property(ba => ba.Numero)
                   .HasMaxLength(20);

            builder.Property(ba => ba.Digito)
                   .HasMaxLength(1);

            builder.Property(ba => ba.Nome)
                   .HasMaxLength(100);

            builder.Property(ba => ba.Telefone)
                   .HasMaxLength(15);

            builder.Property(ba => ba.Contato)
                   .HasMaxLength(100);

            builder.Property(ba => ba.Observacao)
                   .HasMaxLength(250);

            builder.Property(ba => ba.Gerente)
                   .HasMaxLength(100);

    
            builder.HasOne(ba => ba.Banco)       
                   .WithMany(b => b.BancoAgencias) 
                   .HasForeignKey(ba => ba.BancoId) 
                   .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}

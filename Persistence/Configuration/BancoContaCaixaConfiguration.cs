using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Infrastructure.Data.Configurations
{
    public class BancoContaCaixaConfiguration : IEntityTypeConfiguration<BancoContaCaixa>
    {
        public void Configure(EntityTypeBuilder<BancoContaCaixa> builder)
        {
            builder.HasKey(bcc => bcc.Id);

            builder.Property(bcc => bcc.Numero)
                   .HasMaxLength(20);

            builder.Property(bcc => bcc.Digito)
                   .IsRequired()
                   .HasMaxLength(1);

            builder.Property(bcc => bcc.Nome)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(bcc => bcc.Tipo)
                   .HasMaxLength(1);

            builder.Property(bcc => bcc.Descricao)
                   .HasMaxLength(250);

            builder.HasOne(bcc => bcc.BancoAgencia)          
                   .WithMany(ba => ba.BancoContaCaixas) 
                   .HasForeignKey(bcc => bcc.BancoAgenciaId) 
                   .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoDeLicitacoes.Models.Model;

namespace ProjetoDeLicitacoes.Models.Mapping
{
    public class LicitacaoMap: IEntityTypeConfiguration<Licitacao>
    {
        public void Configure(EntityTypeBuilder<Licitacao> builder)
        {
            // Configurações de mapeamento aqui
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(l => l.Numero)
                .HasColumnName("Numero")
                .HasColumnType("nvarchar(255)")
                .IsRequired();

            builder.Property(l => l.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            builder.Property(l => l.DataAbertura)
                .HasColumnName("DataAbertura")
                .HasColumnType("datetime2")
                .IsRequired();

            builder.Property(l => l.Status)
                .HasColumnName("Status")
                .HasColumnType("nvarchar(255)")
                .IsRequired();

        }
    }
}

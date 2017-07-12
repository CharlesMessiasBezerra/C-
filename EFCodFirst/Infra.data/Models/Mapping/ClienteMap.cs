using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infra.data.Models.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.pk_intCod);

            // Properties
            this.Property(t => t.strNOME)
                .HasMaxLength(40);

            this.Property(t => t.strSexo)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Cliente");
            this.Property(t => t.pk_intCod).HasColumnName("pk_intCod");
            this.Property(t => t.fk_intBairro).HasColumnName("fk_intBairro");
            this.Property(t => t.strNOME).HasColumnName("strNOME");
            this.Property(t => t.intIdade).HasColumnName("intIdade");
            this.Property(t => t.strSexo).HasColumnName("strSexo");
            this.Property(t => t.strTeste).HasColumnName("strTeste");
            this.Property(t => t.strApelido).HasColumnName("StrApelido");

            // Relationships
            this.HasOptional(t => t.Bairro)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.fk_intBairro);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CrudEF.Models.Mapping
{
    public class BairroMap : EntityTypeConfiguration<Bairro>
    {
        public BairroMap()
        {
            // Primary Key
            this.HasKey(t => t.pk_intCod);

            // Properties
            this.Property(t => t.strNOME)
                .HasMaxLength(40);

            this.Property(t => t.strcep)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Bairro");
            this.Property(t => t.pk_intCod).HasColumnName("pk_intCod");
            this.Property(t => t.strNOME).HasColumnName("strNOME");
            this.Property(t => t.strcep).HasColumnName("strcep");
        }
    }
}

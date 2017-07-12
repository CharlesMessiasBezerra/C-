using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEF.Models.Mapping
{
    public class vw_ClienteMap : EntityTypeConfiguration<vw_Cliente>
    {
        public vw_ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.pk_intCod);

            // Properties
            this.Property(t => t.strNOME)
                .HasMaxLength(40);

            this.Property(t => t.strSexo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.strNOMEB)
                .HasMaxLength(40);

            this.Property(t => t.strcep)
                .IsFixedLength()
                .HasMaxLength(20);
            

            // Table & Column Mappings
            this.ToTable("vw_DadosCliente");
            this.Property(t => t.pk_intCod).HasColumnType("int").HasColumnName("pk_intCod");
            this.Property(t => t.strNOME).HasColumnName("strNOME");
            this.Property(t => t.strNOMEB).HasColumnName("strNOMEB");
            this.Property(t => t.intIdade).HasColumnName("intIdade");
            this.Property(t => t.strSexo).HasColumnName("strSexo");
            this.Property(t => t.strcep).HasColumnName("strcep");

           
           
        }
    }
    
}

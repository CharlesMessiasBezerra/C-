using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Infra.data.Models.Mapping;

namespace Infra.data.Models
{
    public partial class BDEstudoContext : DbContext
    {
        static BDEstudoContext()
        {
            Database.SetInitializer<BDEstudoContext>(null);
        }

        public BDEstudoContext()
            : base("Name=BDEstudoContext")
        {
        }

        public DbSet<Bairro> Bairroes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BairroMap());
            modelBuilder.Configurations.Add(new ClienteMap());

            modelBuilder.Properties<string>()
            .Configure(p=> p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
            .Configure(p => p.HasMaxLength(100));
            
        }
    }
}

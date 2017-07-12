using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using CrudEF.Models.Mapping;

namespace CrudEF.Models
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
        public DbSet<vw_Cliente> ClientesVwClientes { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BairroMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new vw_ClienteMap());


            //cria varchar no lugar de nvarchar padrao string de 100
            modelBuilder.Properties<string>()
            .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
            .Configure(p => p.HasMaxLength(100));
        }
    }
}

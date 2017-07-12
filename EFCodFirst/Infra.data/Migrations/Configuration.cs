namespace Infra.data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Infra.data.Models.BDEstudoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Infra.data.Models.BDEstudoContext context)
        {
            
        }
    }
}

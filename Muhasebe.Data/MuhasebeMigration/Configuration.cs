using Muhasebe.Data.Contexts;
using System.Data.Entity.Migrations;

namespace Muhasebe.Data.MuhasebeMigration
{
    public class Configuration : DbMigrationsConfiguration<MuhasebeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
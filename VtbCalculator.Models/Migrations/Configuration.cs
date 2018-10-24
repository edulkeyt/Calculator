using System.Data.Entity.Migrations;

namespace VtbCalculator.Models.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<VtbCalculatorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}
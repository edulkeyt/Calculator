using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using VtbCalculator.Common;
using VtbCalculator.Domain.Models;
using VtbCalculator.Models.Mapping;

namespace VtbCalculator.Models
{
    public class VtbCalculatorContext : DbContext
    {
        public VtbCalculatorContext() : base(Config.ConnectionString)
        {
        }

        public VtbCalculatorContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<CalculationRequest> CalculationQueue { get; set; }
        public DbSet<LogEntry> ServiceActionsLog { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new CalculationQueueConfiguration());
            modelBuilder.Configurations.Add(new ServiceActionsLogConfiguration());
        }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.Models.Mapping
{
    public class CalculationQueueConfiguration : EntityTypeConfiguration<CalculationRequest>
    {
        public CalculationQueueConfiguration() : this("dbo")
        {
        }

        public CalculationQueueConfiguration(string scheme)
        {
            ToTable(nameof(VtbCalculatorContext.CalculationQueue), scheme);
            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.OperationType).IsRequired();
            Property(x => x.OperandLeft).IsRequired();
            Property(x => x.OperandRight).IsRequired();
        }
    }
}
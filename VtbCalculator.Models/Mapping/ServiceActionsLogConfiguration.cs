using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtbCalculator.Domain.Models;

namespace VtbCalculator.Models.Mapping
{
    public class ServiceActionsLogConfiguration : EntityTypeConfiguration<LogEntry>
    {
        public ServiceActionsLogConfiguration() : this("dbo")
        {
            
        }

        public ServiceActionsLogConfiguration(string scheme)
        {
            ToTable(nameof(VtbCalculatorContext.ServiceActionsLog), scheme);
            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Time).IsRequired();
            Property(x => x.Source).IsRequired();
            Property(x => x.Action).IsRequired();
            Property(x => x.Message).IsRequired();
        }
    }
}

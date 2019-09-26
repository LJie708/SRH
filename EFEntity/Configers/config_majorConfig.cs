using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFEntity.Configers
{
    public class config_majorConfig:EntityTypeConfiguration<config_major>
    {
        public config_majorConfig()
        {
            this.ToTable(nameof(config_major));
        }
    }
}

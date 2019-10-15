using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFEntity.Configers
{
    public class config_file_third_kindConfig:EntityTypeConfiguration<config_file_third_kind>
    {
        public config_file_third_kindConfig()
        {
            this.ToTable(nameof(config_file_third_kind));
        }
    }
}

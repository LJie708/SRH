using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace EFEntity.Configers
{
   public class salary_grant_typeConfig:EntityTypeConfiguration<salary_grant_type>
    {
        public salary_grant_typeConfig()
        {
            this.ToTable(nameof(salary_grant_type));
        }
    }
}

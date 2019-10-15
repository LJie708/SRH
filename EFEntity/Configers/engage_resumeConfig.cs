
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace EFEntity.Config
{
   public class engage_resumeConfig:EntityTypeConfiguration<engage_resume>
    {
        public engage_resumeConfig()
        {
            this.ToTable(nameof(engage_resume));
        }
    }
}

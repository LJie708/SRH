using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_majorModel
    {
        public int Id { get; set; }
        public System.String major_kind_id { get; set; }
        public System.String major_kind_name { get; set; }
        public System.String major_id { get; set; }
        [Required(ErrorMessage ="ÇëÌîÐ´Ö°Î»Ãû³Æ")]
        public System.String major_name { get; set; }
        public System.Int16 test_amount { get; set; }

    }
}

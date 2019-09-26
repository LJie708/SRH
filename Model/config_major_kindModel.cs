using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_major_kindModel
    {
        public System.Int16 Id { get; set; }
        public System.String major_kind_id { get; set; }
        [Required(ErrorMessage ="请填写职位分类")]
        public System.String major_kind_name { get; set; }
    }
}

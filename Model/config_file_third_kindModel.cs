using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_file_third_kindModel
    {
        public System.Int16 Id { get; set; }
        public System.String first_kind_id { get; set; }
        public System.String first_kind_name { get; set; }
        public System.String second_kind_id { get; set; }
        public System.String second_kind_name { get; set; }
        public System.String third_kind_id { get; set; }
        [Required(ErrorMessage ="III级机构名称不能为空")]
        public System.String third_kind_name { get; set; }
        public System.String third_kind_sale_id { get; set; }
        public System.String third_kind_is_retail { get; set; }

    }
}

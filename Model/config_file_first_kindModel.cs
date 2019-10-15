using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_file_first_kindModel
    {
        public System.Int16 Id { get; set; }
        public string first_kind_id { get; set; }
        [Required(ErrorMessage = "请填写I级机构名称")]
        public string first_kind_name { get; set; }
        [Required(ErrorMessage = "请填写薪酬发放责任人编号")]
        public string first_kind_salary_id { get; set; }
        [Required(ErrorMessage = "请填写销售责任人编号")]
        public string first_kind_sale_id { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class engage_major_releaseModel
    {
        public System.Int16 Id { get; set; }
        public System.String first_kind_id { get; set; }
        public System.String first_kind_name { get; set; }
        public System.String second_kind_id { get; set; }
        public System.String second_kind_name { get; set; }
        public System.String third_kind_id { get; set; }
        public System.String third_kind_name { get; set; }
        public System.String major_kind_id { get; set; }
        public System.String major_kind_name { get; set; }
        public System.String major_id { get; set; }
        public System.String major_name { get; set; }
        [Required(ErrorMessage ="招聘人数不能为空")]
        [RegularExpression(@"^[1-9]\d*$",ErrorMessage ="招聘人数须为正整数")]
        public System.Int16 human_amount { get; set; }
        public System.String engage_type { get; set; }
        [Required(ErrorMessage ="截止日期不能为空")]
        //[Compare("regist_time", ErrorMessage ="截止日期不能小于登记时间")]
        public System.DateTime deadline { get; set; }
        [Required(ErrorMessage ="登记人不能为空")]
        public System.String register { get; set; }
        public System.String changer { get; set; }
        public System.DateTime regist_time { get; set; }
        public System.DateTime change_time { get; set; }
        [Required(ErrorMessage ="职位描述不能为空")]
        public System.String major_describe { get; set; }
        [Required(ErrorMessage ="招聘要求不能为空")]
        public System.String engage_required { get; set; }
    }
}

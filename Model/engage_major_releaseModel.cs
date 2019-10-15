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
        [Required(ErrorMessage ="��Ƹ��������Ϊ��")]
        [RegularExpression(@"^[1-9]\d*$",ErrorMessage ="��Ƹ������Ϊ������")]
        public System.Int16 human_amount { get; set; }
        public System.String engage_type { get; set; }
        [Required(ErrorMessage ="��ֹ���ڲ���Ϊ��")]
        //[Compare("regist_time", ErrorMessage ="��ֹ���ڲ���С�ڵǼ�ʱ��")]
        public System.DateTime deadline { get; set; }
        [Required(ErrorMessage ="�Ǽ��˲���Ϊ��")]
        public System.String register { get; set; }
        public System.String changer { get; set; }
        public System.DateTime regist_time { get; set; }
        public System.DateTime change_time { get; set; }
        [Required(ErrorMessage ="ְλ��������Ϊ��")]
        public System.String major_describe { get; set; }
        [Required(ErrorMessage ="��ƸҪ����Ϊ��")]
        public System.String engage_required { get; set; }
    }
}

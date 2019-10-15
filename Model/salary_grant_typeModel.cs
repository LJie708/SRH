using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class salary_grant_typeModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="薪酬项目名称不能为空")]
        public string grant_type_name { get; set; }

    }
}

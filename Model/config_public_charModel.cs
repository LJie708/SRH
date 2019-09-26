using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_public_charModel
    {
        public System.Int16 Id { get; set; }
        [Required(ErrorMessage ="请填写属性种类")]
        public System.String attribute_kind { get; set; }
        [Required(ErrorMessage = "请填写属性名称")]
        public System.String attribute_name { get; set; }
    }
}

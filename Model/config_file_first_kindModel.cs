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
        [Required(ErrorMessage = "����дI����������")]
        public string first_kind_name { get; set; }
        [Required(ErrorMessage = "����дн�귢�������˱��")]
        public string first_kind_salary_id { get; set; }
        [Required(ErrorMessage = "����д���������˱��")]
        public string first_kind_sale_id { get; set; }

    }
}

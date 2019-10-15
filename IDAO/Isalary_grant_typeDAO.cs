using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
   public interface Isalary_grant_typeDAO
    {
        int salary_grant_typeAdd(salary_grant_typeModel s);

        int salary_grant_typeDelete(salary_grant_typeModel s);

        List<salary_grant_typeModel> salary_grant_typeSelect();

        List<salary_grant_typeModel> salary_grant_typeSelectBy();

        int salary_grant_typeUpdate(salary_grant_typeModel s);

    }
}

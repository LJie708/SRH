using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
   public interface Isalary_grant_typeBLL
    {
        int Add(salary_grant_typeModel s);

        int Delete(salary_grant_typeModel s);

        List<salary_grant_typeModel> Select();

        int Update(salary_grant_typeModel s);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using Ioc;
using IDAO;

namespace BLL
{
    public class salary_grant_typeBLL : Isalary_grant_typeBLL
    {
        Isalary_grant_typeDAO isb = IocCreat.Createsalary_grant_typeDAO();
        public int Add(salary_grant_typeModel s)
        {
            return isb.salary_grant_typeAdd(s);
        }

        public int Delete(salary_grant_typeModel s)
        {
            return isb.salary_grant_typeDelete(s);
        }

        public List<salary_grant_typeModel> Select()
        {
            return isb.salary_grant_typeSelect();
        }

        public int Update(salary_grant_typeModel s)
        {
            throw new NotImplementedException();
        }
    }
}

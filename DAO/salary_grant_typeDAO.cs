using EFEntity;
using IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class salary_grant_typeDAO : DaoBase<salary_grant_type>, Isalary_grant_typeDAO
    {
        public int salary_grant_typeAdd(salary_grant_typeModel s)
        {
            salary_grant_type st = new salary_grant_type()
            {
                Id=s.Id,
                grant_type_name=s.grant_type_name
            };
            return Add(st);
        }

        public int salary_grant_typeDelete(salary_grant_typeModel s)
        {
            salary_grant_type se = new salary_grant_type()
            {
                Id = s.Id,
                grant_type_name = s.grant_type_name
            };
            return Delete(se);
        }

        public List<salary_grant_typeModel> salary_grant_typeSelect()
        {
            List<salary_grant_type> list = Select();
            List<salary_grant_typeModel> list2 = new List<salary_grant_typeModel>();
            foreach (salary_grant_type item in list)
            {
                salary_grant_typeModel s = new salary_grant_typeModel()
                {
                    Id=item.Id,
                    grant_type_name=item.grant_type_name
                };
                list2.Add(s);
            }
            return list2;
        }

        public List<salary_grant_typeModel> salary_grant_typeSelectBy()
        {
            throw new NotImplementedException();
        }

        public int salary_grant_typeUpdate(salary_grant_typeModel s)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EFEntity;
using System.Data;

namespace DAO
{
    public class config_file_first_kindDAO : DaoBase<config_file_first_kind>, Iconfig_file_first_kindDAO
    {
        public int config_file_first_kindAdd(config_file_first_kindModel cfm)
        {
            config_file_first_kind cfk = new config_file_first_kind()
            {
                Id = cfm.Id,
                first_kind_id = cfm.first_kind_id,
                first_kind_name = cfm.first_kind_name,
                first_kind_salary_id = cfm.first_kind_salary_id,
                first_kind_sale_id = cfm.first_kind_sale_id
            };
            return Add(cfk);
        }

        public int config_file_first_kindDelete(config_file_first_kindModel cfm)
        {
            config_file_first_kind cfk = new config_file_first_kind()
            {
                Id = cfm.Id,
                first_kind_id = cfm.first_kind_id,
                first_kind_name = cfm.first_kind_name,
                first_kind_salary_id = cfm.first_kind_salary_id,
                first_kind_sale_id = cfm.first_kind_sale_id
            };
            return Delete(cfk);
        }

        public int config_file_first_kindMaxId()
        {
            MyDbContext db = new MyDbContext();
            return Convert.ToInt32(db.config_file_first_kind.Select(e => e.first_kind_id).Max()) + 1;
        }

        public List<config_file_first_kindModel> config_file_first_kindSelect()
        {
            List<config_file_first_kind> listk = Select();
            List<config_file_first_kindModel> list = new List<config_file_first_kindModel>();
            foreach (config_file_first_kind cfk in listk)
            {
                config_file_first_kindModel cfm = new config_file_first_kindModel()
                {
                    Id = cfk.Id,
                    first_kind_id = cfk.first_kind_id,
                    first_kind_name = cfk.first_kind_name,
                    first_kind_salary_id = cfk.first_kind_salary_id,
                    first_kind_sale_id = cfk.first_kind_sale_id
                };
                list.Add(cfm);
            }
            return list;
        }

        public config_file_first_kindModel config_file_first_kindSelectById(int id)
        {
            MyDbContext mc = new MyDbContext();
            List<config_file_first_kind> cfk = mc.config_file_first_kind.Where(
                e => e.Id == id).Select(e => e).ToList();
            config_file_first_kindModel cfm = new config_file_first_kindModel()
            {
                Id = cfk[0].Id,
                first_kind_id = cfk[0].first_kind_id,
                first_kind_name = cfk[0].first_kind_name,
                first_kind_salary_id = cfk[0].first_kind_salary_id,
                first_kind_sale_id = cfk[0].first_kind_sale_id
            };
            return cfm;
        }

        public string config_file_first_kindSelectByName(string fid)
        {
            string sql = $"select first_kind_name from config_file_first_kind where first_kind_id='{fid}'";
            DataTable dt = DBHelper.MyDataTable(sql);
            return dt.Rows[0]["first_kind_name"].ToString();
        }

        public int config_file_first_kindUpdate(config_file_first_kindModel cfm)
        {
            config_file_first_kind cfk = new config_file_first_kind()
            {
                Id = cfm.Id,
                first_kind_id = cfm.first_kind_id,
                first_kind_name = cfm.first_kind_name,
                first_kind_salary_id = cfm.first_kind_salary_id,
                first_kind_sale_id = cfm.first_kind_sale_id
            };
            return Update(cfk);
        }
    }
}

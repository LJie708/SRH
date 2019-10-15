using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using EFEntity;
using System.Data;

namespace DAO
{
    public class config_file_second_kindDAO : DaoBase<config_file_second_kind>, Iconfig_file_second_kindDAO
    {
        public int config_file_second_kindAdd(config_file_second_kindModel csm)
        {
            config_file_second_kind csk = new config_file_second_kind()
            {
                Id = csm.Id,
                first_kind_id = csm.first_kind_id,
                first_kind_name = csm.first_kind_name,
                second_kind_id = csm.second_kind_id,
                second_kind_name = csm.second_kind_name,
                second_salary_id = csm.second_salary_id,
                second_sale_id = csm.second_sale_id
            };
            return Add(csk);
        }

        public int config_file_second_kindDelete(config_file_second_kindModel csm)
        {
            config_file_second_kind csk = new config_file_second_kind()
            {
                Id = csm.Id,
                first_kind_id = csm.first_kind_id,
                first_kind_name = csm.first_kind_name,
                second_kind_id = csm.second_kind_id,
                second_kind_name = csm.second_kind_name,
                second_salary_id = csm.second_salary_id,
                second_sale_id = csm.second_sale_id
            };
            return Delete(csk);
        }

        public int config_file_second_kindMaxId()
        {
            MyDbContext db = new MyDbContext();
            return Convert.ToInt32(db.config_file_second_kind.Select(e => e.second_kind_id).Max()) + 1;
        }

        public List<config_file_second_kindModel> config_file_second_kindSelect()
        {
            List<config_file_second_kind> lists = Select();
            List<config_file_second_kindModel> list = new List<config_file_second_kindModel>();
            foreach (config_file_second_kind csk in lists)
            {
                config_file_second_kindModel csm = new config_file_second_kindModel()
                {
                    Id = csk.Id,
                    first_kind_id = csk.first_kind_id,
                    first_kind_name = csk.first_kind_name,
                    second_kind_id = csk.second_kind_id,
                    second_kind_name = csk.second_kind_name,
                    second_salary_id = csk.second_salary_id,
                    second_sale_id = csk.second_sale_id
                };
                list.Add(csm);
            }
            return list;
        }

        public config_file_second_kindModel config_file_second_kindSelectById(int id)
        {
            MyDbContext mc = new MyDbContext();
            List<config_file_second_kind> cfk = mc.config_file_second_kind.Where(
                e => e.Id == id).Select(e => e).ToList();
            config_file_second_kindModel cfm = new config_file_second_kindModel()
            {
                Id = cfk[0].Id,
                first_kind_id=cfk[0].first_kind_id,
                first_kind_name=cfk[0].first_kind_name,
                second_kind_id=cfk[0].second_kind_id,
                second_kind_name=cfk[0].second_kind_name,
                second_salary_id=cfk[0].second_salary_id,
                second_sale_id=cfk[0].second_sale_id
            };
            return cfm;
        }

        public string config_file_second_kindSelectByName(string fid)
        {
            string sql = $" select [second_kind_name] from [dbo].[config_file_second_kind] where [second_kind_id]='{fid}'";
            DataTable dt = DBHelper.MyDataTable(sql);
            return dt.Rows[0]["second_kind_name"].ToString();
        }

        public int config_file_second_kindUpdate(config_file_second_kindModel csm)
        {
            config_file_second_kind csk = new config_file_second_kind()
            {
                Id = csm.Id,
                first_kind_id = csm.first_kind_id,
                first_kind_name = csm.first_kind_name,
                second_kind_id = csm.second_kind_id,
                second_kind_name = csm.second_kind_name,
                second_salary_id = csm.second_salary_id,
                second_sale_id = csm.second_sale_id
            };
            return Update(csk);
        }

        public List<config_file_second_kindModel> OnChanges(int fid)
        {
            string sql = @"select second_kind_id,[second_kind_name]
            from[dbo].[config_file_second_kind] where[first_kind_id] = " + fid;
            DataTable dt = DBHelper.MyDataTable(sql);
            List<config_file_second_kindModel> list = new List<config_file_second_kindModel>();
            foreach (DataRow dr in dt.Rows)
            {
                config_file_second_kindModel cm = new config_file_second_kindModel()
                {
                    second_kind_id = dr["second_kind_id"].ToString(),
                    second_kind_name = dr["second_kind_name"].ToString()
                };
                list.Add(cm);
            }
            return list;
        }

        public int SelectByFid(string fid)
        {
            string sql = $"select count(1) from [dbo].[config_file_second_kind] where [first_kind_id]='{fid}'";
            return Convert.ToInt32(DBHelper.MyScalar(sql));
        }
    }
}

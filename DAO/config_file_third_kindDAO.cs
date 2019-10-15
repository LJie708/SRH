using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFEntity;
using IDAO;
using Model;
using System.Data;

namespace DAO
{
    public class config_file_third_kindDAO : DaoBase<config_file_third_kind>, Iconfig_file_third_kindDAO
    {
        public int config_file_third_kindAdd(config_file_third_kindModel ctm)
        {
            config_file_third_kind ctk = new config_file_third_kind()
            {
                Id = ctm.Id,
                first_kind_id = ctm.first_kind_id,
                first_kind_name = ctm.first_kind_name,
                second_kind_id = ctm.second_kind_id,
                second_kind_name = ctm.second_kind_name,
                third_kind_id = ctm.third_kind_id,
                third_kind_is_retail = ctm.third_kind_is_retail,
                third_kind_name = ctm.third_kind_name,
                third_kind_sale_id = ctm.third_kind_sale_id
            };
            return Add(ctk);
        }

        public int config_file_third_kindDelete(config_file_third_kindModel ctm)
        {
            config_file_third_kind ctk = new config_file_third_kind()
            {
                Id = ctm.Id,
                first_kind_id = ctm.first_kind_id,
                first_kind_name = ctm.first_kind_name,
                second_kind_id = ctm.second_kind_id,
                second_kind_name = ctm.second_kind_name,
                third_kind_id = ctm.third_kind_id,
                third_kind_is_retail = ctm.third_kind_is_retail,
                third_kind_name = ctm.third_kind_name,
                third_kind_sale_id = ctm.third_kind_sale_id
            };
            return Delete(ctk);
        }

        public List<config_file_third_kindModel> config_file_third_kindSelect()
        {
            List<config_file_third_kind> listt = Select();
            List<config_file_third_kindModel> list = new List<config_file_third_kindModel>();
            foreach (config_file_third_kind cfk in listt)
            {
                config_file_third_kindModel ctk = new config_file_third_kindModel()
                {
                    Id = cfk.Id,
                    first_kind_id = cfk.first_kind_id,
                    first_kind_name = cfk.first_kind_name,
                    second_kind_id = cfk.second_kind_id,
                    second_kind_name = cfk.second_kind_name,
                    third_kind_id = cfk.third_kind_id,
                    third_kind_is_retail = cfk.third_kind_is_retail,
                    third_kind_name = cfk.third_kind_name,
                    third_kind_sale_id = cfk.third_kind_sale_id
                };
                list.Add(ctk);
            }
            return list;
        }

        public config_file_third_kindModel config_file_third_kindSelectById(int id)
        {
            MyDbContext mc = new MyDbContext();
            List<config_file_third_kind> ctk = mc.config_file_third_kind.Where(
                e => e.Id == id).Select(e => e).ToList();
            config_file_third_kindModel ctm = new config_file_third_kindModel()
            {
                Id = ctk[0].Id,
                third_kind_id = ctk[0].third_kind_id,
                third_kind_name = ctk[0].third_kind_name,
                first_kind_id = ctk[0].first_kind_id,
                first_kind_name = ctk[0].first_kind_name,
                second_kind_id = ctk[0].second_kind_id,
                second_kind_name = ctk[0].second_kind_name,
                third_kind_sale_id = ctk[0].third_kind_sale_id,
                third_kind_is_retail = ctk[0].third_kind_is_retail
            };
            return ctm;
        }

        public int config_file_third_kindUpdate(config_file_third_kindModel ctm)
        {
            config_file_third_kind ctk = new config_file_third_kind()
            {
                Id = ctm.Id,
                first_kind_id = ctm.first_kind_id,
                first_kind_name = ctm.first_kind_name,
                second_kind_id = ctm.second_kind_id,
                second_kind_name = ctm.second_kind_name,
                third_kind_id = ctm.third_kind_id,
                third_kind_is_retail = ctm.third_kind_is_retail,
                third_kind_name = ctm.third_kind_name,
                third_kind_sale_id = ctm.third_kind_sale_id
            };
            return Update(ctk);
        }

        public int Iconfig_file_third_kindMaxId()
        {
            MyDbContext db = new MyDbContext();
            return Convert.ToInt32(db.config_file_third_kind.Select(e => e.third_kind_id).Max()) + 1;
        }

        public List<config_file_third_kindModel> OnChanges(int sid)
        {
            string sql = @"select [third_kind_id],[third_kind_name]
            from [dbo].[config_file_third_kind] where [second_kind_id] =" + sid;
            DataTable dt = DBHelper.MyDataTable(sql);
            List<config_file_third_kindModel> list = new List<config_file_third_kindModel>();
            foreach (DataRow dr in dt.Rows)
            {
                config_file_third_kindModel cm = new config_file_third_kindModel()
                {
                    third_kind_id = dr["third_kind_id"].ToString(),
                    third_kind_name = dr["third_kind_name"].ToString()
                };
                list.Add(cm);
            }
            return list;
        }

        public string SelectByName(string tid)
        {
            string sql = @"select [third_kind_name] from [dbo].[config_file_third_kind]
            where [third_kind_id]=" + tid;
            DataTable dt = DBHelper.MyDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["third_kind_name"].ToString();
            }else
            {
                return "";
            }
        }

        public int SelectByTid(string tid)
        {
            string sql = $"select count(1) from [dbo].[config_file_third_kind] where [second_kind_id]='{tid}'";
            return Convert.ToInt32(DBHelper.MyScalar(sql));
        }
    }
}

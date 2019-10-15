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
   public class config_major_kindDAO : DaoBase<config_major_kind>, Iconfig_major_kindDAO
    {

        public int config_major_kindAdd(config_major_kindModel t)
        {
            config_major_kind st = new config_major_kind()
            {
                Id = t.Id,
                major_kind_id = t.major_kind_id,
                major_kind_name = t.major_kind_name
            };

            return Add(st);
        }

        public int config_major_kindDelete(config_major_kindModel t)
        {
            config_major_kind st = new config_major_kind()
            {
                Id = t.Id,
                major_kind_id = t.major_kind_id,
                major_kind_name = t.major_kind_name
            };
            return Delete(st);
        }

        public int config_major_kindUpdate(config_major_kindModel t)
        {
            config_major_kind st = new config_major_kind()
            {
                Id = t.Id,
                major_kind_id = t.major_kind_id,
                major_kind_name = t.major_kind_name
            };
            return Update(st);
        }

        public List<config_major_kindModel> config_major_kindSelect()
        {
            List<config_major_kind> list = Select();
            List<config_major_kindModel> list2 = new List<config_major_kindModel>();
            foreach (config_major_kind item in list)
            {
                config_major_kindModel sm = new config_major_kindModel()
                {
                    Id = item.Id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int idjia1()
        {
            MyDbContext db = new MyDbContext();
            return Convert.ToInt32(db.config_major_kind.Select(e => e.major_kind_id).Max()) + 1;
        }

        public string Selmajor_kind_name(string id)
        {
            string sql = $"select * from dbo.config_major_kind where major_kind_id = {id}";
            DataTable dt = DBHelper.MyDataTable(sql);
            return dt.Rows[0]["major_kind_name"].ToString();
        }
    }
}

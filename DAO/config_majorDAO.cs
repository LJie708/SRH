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
   public class config_majorDAO : DaoBase<config_major>, Iconfig_majorDAO
    {
        public int config_majorAdd(config_majorModel t)
        {
            config_major st = new config_major()
            {
                Id = t.Id,
                major_id = t.major_id,
                major_kind_id= t.major_kind_id,
                major_kind_name= t.major_kind_name,
                major_name= t.major_name,
                test_amount = t.test_amount
            };

            return Add(st);
        }

        public int config_majorDelete(config_majorModel t)
        {
            config_major st = new config_major()
            {
                Id = t.Id
            };
            return Delete(st);
        }

        public List<config_majorModel> config_majorSelect()
        {
            List<config_major> list = Select();
            List<config_majorModel> list2 = new List<config_majorModel>();
            foreach (config_major item in list)
            {
                config_majorModel sm = new config_majorModel()
                {
                    Id = item.Id,
                    major_id = item.major_id,
                    major_kind_id = item.major_kind_id,
                    major_kind_name = item.major_kind_name,
                    major_name = item.major_name,
                    test_amount = item.test_amount
                };
                list2.Add(sm);
            }
            return list2; ;
        }
        public int config_majorUpdate(config_majorModel t)
        {
            config_major st = new config_major()
            {
                Id = t.Id,
                major_id = t.major_id,
                major_kind_id = t.major_kind_id,
                major_kind_name = t.major_kind_name,
                major_name = t.major_name,
                test_amount = t.test_amount
            };
            return Update(st);
        }

        public int major_kind_idMaxId()
        {
            MyDbContext db = new MyDbContext();
            return Convert.ToInt32(db.config_major.Select(e => e.major_id).Max()) + 1;
        }

        public string SelectByName(string kind, string cm)
        {
            string sql = $@"select [major_name] from [dbo].[config_major]
            where [major_kind_id]={kind} and [major_id]={cm}";
            DataTable dt = DBHelper.MyDataTable(sql);
            return dt.Rows[0]["major_name"].ToString();
        }

        public List<config_majorModel> SelectByType(int type)
        {
            string sql = @"select [major_id],[major_name]
            from [dbo].[config_major] where [major_kind_id]=" + type;
            DataTable dt = DBHelper.MyDataTable(sql);
            List<config_majorModel> list = new List<config_majorModel>();
            foreach (DataRow dr in dt.Rows)
            {
                config_majorModel cm = new config_majorModel()
                {
                    major_id=dr["major_id"].ToString(),
                    major_name=dr["major_name"].ToString()
                };
                list.Add(cm);
            }
            return list;
        }

        public int Selectmajor_kind_id(int id)
        {
            string sql = $"select COUNT(*) from dbo.config_major where major_kind_id ='{id}'";
            int a =   Convert.ToInt32(DBHelper.MyScalar(sql));
            return a;
        }
    }
}

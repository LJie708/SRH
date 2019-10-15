using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
using EFEntity;

namespace DAO
{
   public class config_public_charDAO:DaoBase<config_public_char>, Iconfig_public_charDAO
    {

        public int config_public_charAdd(config_public_charModel t)
        {
            config_public_char st = new config_public_char()
            {
                 Id=t.Id,
                 attribute_kind= t.attribute_kind,  
                 attribute_name= t.attribute_name
            };

            return Add(st);
        }

        public int config_public_charDelete(config_public_charModel t)
        {
            config_public_char st = new config_public_char()
            {
                Id = t.Id,
                attribute_kind = t.attribute_kind,
                attribute_name = t.attribute_name
            };
            return Delete(st);
        }

        public List<config_public_charModel> config_public_charSeleBYKind(string kind)
        {
            MyDbContext db = new MyDbContext();
            List<config_public_char> list = db.config_public_char.AsNoTracking()
                .Where(e => e.attribute_kind == kind)
                .Select(e => e)
                .ToList();
          
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel sm = new config_public_charModel()
                {
                    Id = item.Id,
                    attribute_kind= item.attribute_kind,
                    attribute_name= item.attribute_name
                };
                list2.Add(sm);
            }
            return list2;
        }

        public List<config_public_charModel> config_public_charSelect()
        {
            List<config_public_char> list = Select();
            List<config_public_charModel> list2 = new List<config_public_charModel>();
            foreach (config_public_char item in list)
            {
                config_public_charModel sm = new config_public_charModel()
                {
                    Id = item.Id,
                    attribute_kind = item.attribute_kind,
                    attribute_name = item.attribute_name
                };
                list2.Add(sm);
            }
            return list2; ;
        }
        public int config_public_charUpdate(config_public_charModel t)
        {
            config_public_char st = new config_public_char()
            {
                Id = t.Id,
                attribute_kind = t.attribute_kind,
                attribute_name = t.attribute_name
            };
            return Update(st);
        }

    }
}

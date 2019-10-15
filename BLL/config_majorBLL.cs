using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;
using IDAO;
using DAO;
using Ioc;
namespace BLL
{
    class config_majorBLL : Iconfig_majorBLL
    {
        Iconfig_majorDAO cmd = IocCreat.Createconfig_majorDAO();
        
        public int config_majorAdd(config_majorModel t)
        {
            return cmd.config_majorAdd(t);
        }

        public int config_majorDelete(config_majorModel t)
        {
            return cmd.config_majorDelete(t);
        }

        public List<config_majorModel> config_majorSelect()
        {
            return cmd.config_majorSelect();
        }

        public int config_majorUpdate(config_majorModel t)
        {
            return cmd.config_majorUpdate(t);
        }

        public int major_kind_idMaxId()
        {
            return cmd.major_kind_idMaxId();
        }

        public string SelectByName(string kind, string cm)
        {
            return cmd.SelectByName(kind, cm);
        }

        public List<config_majorModel> SelectByType(int type)
        {
            return cmd.SelectByType(type);
        }

        public int Selectmajor_kind_id(int id)
        {
            return cmd.Selectmajor_kind_id(id);
        }
    }
}

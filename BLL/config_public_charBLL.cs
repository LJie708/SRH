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
    public class config_public_charBLL : Iconfig_public_charBLL
    {
        Iconfig_public_charDAO cpd = IocCreat.Createconfig_public_charDAO();
        
        public int config_public_charAdd(config_public_charModel t)
        {
            return cpd.config_public_charAdd(t);
        }

        public int config_public_charDelete(config_public_charModel t)
        {
            return cpd.config_public_charDelete(t);
        }

        public List<config_public_charModel> config_public_charSeleBYKind(string kind)
        {
            return cpd.config_public_charSeleBYKind(kind);
        }

        public List<config_public_charModel> config_public_charSelect()
        {
            return cpd.config_public_charSelect();
        }

        public int config_public_charUpdate(config_public_charModel t)
        {
            return cpd.config_public_charUpdate(t);
        }

      
    }
}

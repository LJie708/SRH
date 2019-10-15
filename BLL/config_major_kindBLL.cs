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
    class config_major_kindBLL : Iconfig_major_kindBLL
    {                                      //Createconfig_major_kindDAO
        Iconfig_major_kindDAO cmk = IocCreat.Createconfig_major_kindDAO();
       
        public int config_major_kindAdd(config_major_kindModel t)
        {
            return cmk.config_major_kindAdd(t);
        }

        public int config_major_kindDelete(config_major_kindModel t)
        {
            return cmk.config_major_kindDelete(t);
        }

        public List<config_major_kindModel> config_major_kindSelect()
        {
            return cmk.config_major_kindSelect();
        }

        public int config_major_kindUpdate(config_major_kindModel t)
        {
            return cmk.config_major_kindUpdate(t); 
        }

        public int idjia1()
        {
            return cmk.idjia1();
        }

        public string Selmajor_kind_name(string id)
        {
            return cmk.Selmajor_kind_name(id);
        }
    }
}

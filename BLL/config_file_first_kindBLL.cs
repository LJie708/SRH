using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Ioc;
using Model;
using IDAO;

namespace BLL
{
    public class config_file_first_kindBLL : Iconfig_file_first_kindBLL
    {
        Iconfig_file_first_kindDAO icfd = IocCreat.Createconfig_file_first_kindDAO();
        public int config_file_first_kindAdd(config_file_first_kindModel cfm)
        {
            return icfd.config_file_first_kindAdd(cfm);
        }

        public int config_file_first_kindDelete(config_file_first_kindModel cfm)
        {
            return icfd.config_file_first_kindDelete(cfm);
        }

        public int config_file_first_kindMaxId()
        {
            return icfd.config_file_first_kindMaxId();
        }

        public List<config_file_first_kindModel> config_file_first_kindSelect()
        {
            return icfd.config_file_first_kindSelect();
        }

        public config_file_first_kindModel config_file_first_kindSelectById(int id)
        {
            return icfd.config_file_first_kindSelectById(id);
        }

        public string config_file_first_kindSelectByName(string fid)
        {
            return icfd.config_file_first_kindSelectByName(fid);
        }

        public int config_file_first_kindUpdate(config_file_first_kindModel cfm)
        {
            return icfd.config_file_first_kindUpdate(cfm);
        }
    }
}

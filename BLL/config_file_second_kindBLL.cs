using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Ioc;
using Model;
using IDAO;
using System.Data;

namespace BLL
{
    public class config_file_second_kindBLL : Iconfig_file_second_kindBLL
    {
        Iconfig_file_second_kindDAO icsd = IocCreat.Createconfig_file_second_kindDAO();
        public int config_file_second_kindAdd(config_file_second_kindModel csm)
        {
            return icsd.config_file_second_kindAdd(csm);
        }

        public int config_file_second_kindDelete(config_file_second_kindModel csm)
        {
            return icsd.config_file_second_kindDelete(csm);
        }

        public int config_file_second_kindMaxId()
        {
            return icsd.config_file_second_kindMaxId();
        }

        public List<config_file_second_kindModel> config_file_second_kindSelect()
        {
            return icsd.config_file_second_kindSelect();
        }

        public config_file_second_kindModel config_file_second_kindSelectById(int id)
        {
            return icsd.config_file_second_kindSelectById(id);
        }

        public string config_file_second_kindSelectByName(string fid)
        {
            return icsd.config_file_second_kindSelectByName(fid);

        }

        public int config_file_second_kindUpdate(config_file_second_kindModel csm)
        {
            return icsd.config_file_second_kindUpdate(csm);
        }

        public List<config_file_second_kindModel> OnChanges(int fid)
        {
            return icsd.OnChanges(fid);
        }

        public int SelectByFid(string fid)
        {
            return icsd.SelectByFid(fid);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc;
using IBLL;
using Model;
using IDAO;

namespace BLL
{
    public class config_file_third_kindBLL : Iconfig_file_third_kindBLL
    {
        Iconfig_file_third_kindDAO ictb = IocCreat.Createconfig_file_third_kindDAO();
        public int config_file_third_kindAdd(config_file_third_kindModel ctm)
        {
            return ictb.config_file_third_kindAdd(ctm);
        }

        public int config_file_third_kindDelete(config_file_third_kindModel ctm)
        {
            return ictb.config_file_third_kindDelete(ctm);
        }

        public List<config_file_third_kindModel> config_file_third_kindSelect()
        {
            return ictb.config_file_third_kindSelect();
        }

        public config_file_third_kindModel config_file_third_kindSelectById(int id)
        {
            return ictb.config_file_third_kindSelectById(id);
        }

        public int config_file_third_kindUpdate(config_file_third_kindModel ctm)
        {
            return ictb.config_file_third_kindUpdate(ctm);
        }

        public int Iconfig_file_third_kindMaxId()
        {
            return ictb.Iconfig_file_third_kindMaxId();
        }

        public List<config_file_third_kindModel> OnChanges(int sid)
        {
            return ictb.OnChanges(sid);
        }

        public string SelectByName(string tid)
        {
            return ictb.SelectByName(tid);
        }

        public int SelectByTid(string tid)
        {
            return ictb.SelectByTid(tid);
        }
    }
}

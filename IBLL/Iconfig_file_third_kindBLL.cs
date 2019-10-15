using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
    public interface Iconfig_file_third_kindBLL
    {
        int config_file_third_kindAdd(config_file_third_kindModel ctm);
        int config_file_third_kindUpdate(config_file_third_kindModel ctm);
        int config_file_third_kindDelete(config_file_third_kindModel ctm);
        List<config_file_third_kindModel> config_file_third_kindSelect();
        int Iconfig_file_third_kindMaxId();
        config_file_third_kindModel config_file_third_kindSelectById(int id);
        int SelectByTid(string tid);
        List<config_file_third_kindModel> OnChanges(int sid);
        string SelectByName(string tid);
    }
}

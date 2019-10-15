using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace IDAO
{
    public interface Iconfig_file_second_kindDAO
    {
        int config_file_second_kindAdd(config_file_second_kindModel csm);
        int config_file_second_kindUpdate(config_file_second_kindModel csm);
        int config_file_second_kindDelete(config_file_second_kindModel csm);
        List<config_file_second_kindModel> config_file_second_kindSelect();
        int config_file_second_kindMaxId();
        config_file_second_kindModel config_file_second_kindSelectById(int id);
        List<config_file_second_kindModel> OnChanges(int fid);
        string config_file_second_kindSelectByName(string fid);
        int SelectByFid(string fid);
    }
}

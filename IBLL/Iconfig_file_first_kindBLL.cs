using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
    public interface Iconfig_file_first_kindBLL
    {
        int config_file_first_kindAdd(config_file_first_kindModel cfm);
        int config_file_first_kindUpdate(config_file_first_kindModel cfm);
        int config_file_first_kindDelete(config_file_first_kindModel cfm);
        List<config_file_first_kindModel> config_file_first_kindSelect();
        int config_file_first_kindMaxId();
        config_file_first_kindModel config_file_first_kindSelectById(int id);
        string config_file_first_kindSelectByName(string fid);
    }
}

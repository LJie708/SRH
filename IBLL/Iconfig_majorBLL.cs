using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
   public interface Iconfig_majorBLL
    {
        int config_majorAdd(config_majorModel t);
        int config_majorUpdate(config_majorModel t);
        int config_majorDelete(config_majorModel t);
        List<config_majorModel> config_majorSelect();
        int Selectmajor_kind_id(int id);
        List<config_majorModel> SelectByType(int type);
        int major_kind_idMaxId();
        string SelectByName(string kind, string cm);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
namespace IDAO
{
   public interface Iconfig_major_kindDAO 
    {
        int config_major_kindAdd(config_major_kindModel t);
        int config_major_kindUpdate(config_major_kindModel t);
        int config_major_kindDelete(config_major_kindModel t);
        List<config_major_kindModel> config_major_kindSelect();
        int idjia1();
        string Selmajor_kind_name(string id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;
using Model;
namespace IDAO
{
   public interface Iconfig_public_charDAO
    {
        int config_public_charAdd(config_public_charModel t);
        int config_public_charUpdate(config_public_charModel t);
        int config_public_charDelete(config_public_charModel t);
        List<config_public_charModel> config_public_charSelect();
        List<config_public_charModel> config_public_charSeleBYKind(string kind);

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
   public interface Iengage_resumeBLL
    {
        int engage_resumeAdd(engage_resumeModel erm);
        int engage_resumeDel(engage_resumeModel erm);
        int engage_resumeUpdate(engage_resumeModel erm);
        List<engage_resumeModel> engage_resumeSelect();
        engage_resumeModel engage_resumeSelectById(int id);
    }
}
                           

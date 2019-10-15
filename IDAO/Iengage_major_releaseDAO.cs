
                              using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAO
{
   public interface Iengage_major_releaseDAO
    {
        int engage_major_releaseAdd(engage_major_releaseModel emm);
        int engage_major_releaseDel(engage_major_releaseModel emm);
        int engage_major_releaseUpdate(engage_major_releaseModel emm);
        List<engage_major_releaseModel> engage_major_releaseSelect();
        engage_major_releaseModel engage_major_releaseSelectById(int id);
        List<engage_major_releaseModel> FenYe(int currentPage, int pageSize, out int rows);
    }
}
                           

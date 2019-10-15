using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAO;
using Ioc;
using Model;

namespace BLL
{
    public class engage_major_releaseBLL : Iengage_major_releaseBLL
    {
        Iengage_major_releaseDAO iemd = IocCreat.Createengage_major_releaseDAO();
        public int engage_major_releaseAdd(engage_major_releaseModel emm)
        {
            return iemd.engage_major_releaseAdd(emm);
        }

        public int engage_major_releaseDel(engage_major_releaseModel emm)
        {
            return iemd.engage_major_releaseDel(emm);
        }

        public List<engage_major_releaseModel> engage_major_releaseSelect()
        {
            return iemd.engage_major_releaseSelect();
        }

        public engage_major_releaseModel engage_major_releaseSelectById(int id)
        {
            return iemd.engage_major_releaseSelectById(id);
        }

        public int engage_major_releaseUpdate(engage_major_releaseModel emm)
        {
            return iemd.engage_major_releaseUpdate(emm);
        }

        public List<engage_major_releaseModel> FenYe(int currentPage, int pageSize, out int rows)
        {
            return iemd.FenYe(currentPage, pageSize, out rows);
        }
    }
}

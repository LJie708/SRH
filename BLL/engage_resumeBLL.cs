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
    public class engage_resumeBLL : Iengage_resumeBLL
    {
        Iengage_resumeDAO ierd = IocCreat.Createengage_resumeDAO();
        public int engage_resumeAdd(engage_resumeModel erm)
        {
            return ierd.engage_resumeAdd(erm);
        }

        public int engage_resumeDel(engage_resumeModel erm)
        {
            return ierd.engage_resumeDel(erm);
        }

        public List<engage_resumeModel> engage_resumeSelect()
        {
            return ierd.engage_resumeSelect();
        }

        public engage_resumeModel engage_resumeSelectById(int id)
        {
            return ierd.engage_resumeSelectById(id);
        }

        public int engage_resumeUpdate(engage_resumeModel erm)
        {
            return ierd.engage_resumeUpdate(erm);
        }
    }
}

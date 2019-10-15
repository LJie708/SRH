using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Ioc;
using IDAO;

namespace BLL
{
    public class AccessUrlBLL : IAccessUrlBLL
    {
        IAccessUrlDAO iaub = IocCreat.CreateAccessUrlDAO();
        public DataTable TreeL(object pid)
        {
            return iaub.TreeL(pid);
        }
    }
}

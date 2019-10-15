using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface IAccessUrlDAO
    {
        DataTable TreeL(object pid);
    }
}

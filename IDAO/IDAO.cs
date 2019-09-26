using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface IDAO<T> where T:class
    {
        int Add(T t);
        int Update(T t);
        int Delete(T t);
        List<T> Select();
    }
}

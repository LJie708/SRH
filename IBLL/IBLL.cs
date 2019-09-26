using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IBLL<T> where T:class
    {
        int Add(T t);
        int Update(T t);
        int Delete(T t);
        List<T> Select();
    }
}

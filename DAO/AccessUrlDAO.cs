using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAO;

namespace DAO
{
    public class AccessUrlDAO : IAccessUrlDAO
    {
        public DataTable TreeL(object pid)
        {
            string sql = "";
            if (pid != null)
            {
                sql = @"select [id],[text],[HRurl],[state] from [dbo].[AccessUrl] 
where [HRPid]=" + pid;
            }else
            {
                sql = @"select [id],[text],[HRurl],[state] from [dbo].[AccessUrl]
where [HRPid]=0";
            }
            return DBHelper.MyDataTable(sql);
        }
    }
}

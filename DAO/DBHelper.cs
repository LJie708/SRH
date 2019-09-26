using Log;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DBHelper
    {

        //连接字符串
        static string str = "Data Source=.;Initial Catalog=HR_DB;Integrated Security=True";

        //编写错误日志
        private static void GetException(Exception ex)
        {
            //using (StreamWriter sw = new StreamWriter("错误日志.txt", true))
            //{
            //    sw.WriteLine("错误内容:" + ex.Message);
            //    sw.WriteLine("错误时间:" + DateTime.Now);
            //}
            LogHelper.WriteLog(typeof(DBHelper), ex.Message);
        }

        //返回收影响的行数
        public static int MyNonQuery(string sql, params SqlParameter[] ps)
        {
            int result = 0;
            using (SqlConnection con=new SqlConnection(str))
            {
                SqlCommand com = new SqlCommand(sql, con);
                if (ps!=null)
                {
                    com.Parameters.AddRange(ps);
                }
                try
                {
                    con.Open();
                    result = com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    GetException(ex);
                }
            }
            return result;
        }

        //返回一行一列
        public static object MyScalar(string sql, params SqlParameter[] ps)
        {
            object result = null;
            using (SqlConnection con=new SqlConnection(str))
            {
                SqlCommand com=new SqlCommand(sql,con);
                if (ps != null)
                {
                    com.Parameters.AddRange(ps);
                }
                try
                {
                    con.Open();
                    result = com.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    GetException(ex);
                }
            }
            return result;
        }

        //读取器
        public static SqlDataReader MyDataReader(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataReader result = null;
            SqlCommand com = new SqlCommand(sql, con);
            if (ps != null)
            {
                com.Parameters.AddRange(ps);
            }
            try
            {
                con.Open();
                result = com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                GetException(ex);
            }
            return result;
        }

        //适配器
        public static DataTable MyDataTable(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            if (ps != null)
            {
                adp.SelectCommand.Parameters.AddRange(ps);
            }
            try
            {
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                GetException(ex);
            }
            return dt;
        }

        //分页---数据库存储过程
        public static DataTable FenYe(string sql, params SqlParameter[] ps)
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddRange(ps);
            try
            {
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                GetException(ex);
            }
            return dt;
        }
    }
}

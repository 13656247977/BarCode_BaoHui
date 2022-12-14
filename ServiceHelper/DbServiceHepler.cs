using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHelper
{
    public static class DbServiceHepler
    {
        public static void SqlConnettion()
        {

        }
        //webconfig
        //<connectionStrings>   
        //<add name = "ConnectionName" connectionString="Server=.\SQLEXPRESS;Database=DatabaseName;
        //User ID = sa; Password=abc123"   
        //providerName="System.Data.SqlClient" />   
        //</connectionStrings> 

        //static string ConnStr = ConfigurationManager.ConnectionStrings["ConnectionName"].ToString();
        //appConfig
        //<appSettings>  
        //<add key = "ConnectionName"
        //value="Server=.\SQLEXPRESS;Database=DatabaseName;User ID=sa;Password=abc123" />  
        //</appSettings> 
         static string ConnStr = ConfigurationManager.AppSettings["ConnectionName"].ToString();
        //连接数据库
         static SqlConnection conn = new SqlConnection(ConnStr);
         static SqlDataReader sdr;
        /// <summary>
        /// 获取数据流  查询、显示、绑定下拉
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql)
        {
            try
            {
                //打开
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                sdr = cmd.ExecuteReader();
                return sdr;
            }
            catch (Exception)
            {
                if (!sdr.IsClosed)//数据流关闭
                {
                    sdr.Close();
                }
                throw;
            }
        }

        /// <summary>
        /// 获取数据流  查询、显示、绑定下拉
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql)
        {
            try
            {
                //打开
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //命令对象
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                if (sdr!=null &&!sdr.IsClosed)//数据流关闭
                {
                    sdr.Close();
                }
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 返回受影响行数 
        /// 添加、删除、修改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            try
            {
                //打开
                //判断状态
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                int n = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return n;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 数据流转List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sdr"></param>
        /// <returns></returns>
        public static List<T> DataReaderToList<T>(SqlDataReader sdr)
        {
            Type t = typeof(T);//获取类型
            //获取所有属性
            PropertyInfo[] p = t.GetProperties();
            //定义集合
            List<T> list = new List<T>();
            //遍历数据流
            while (sdr.Read())
            {
                //创建对象
                T obj = (T)Activator.CreateInstance(t);
                //数据流列数
                string[] sdrFileName = new string[sdr.FieldCount];
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    sdrFileName[i] = sdr.GetName(i).Trim();
                }
                foreach (PropertyInfo item in p)
                {
                    //判断Model中的属性是否在流的列名中
                    if (sdrFileName.ToList().IndexOf(item.Name) > -1)
                    {
                        if (sdr[item.Name] != null && sdr[item.Name] != DBNull.Value)
                        {
                            item.SetValue(obj, sdr[item.Name]);//对象属性赋值
                        }
                        else
                        {
                            item.SetValue(obj, null);//对象属性赋值
                        }
                    }
                    else
                    {
                        item.SetValue(obj, null);//对象属性赋值
                    }

                }
                list.Add(obj);
            }
            return list;
        }
        /// <summary>
        /// 获取list集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetToList<T>(string sql)
        {
            //获取流数据
            SqlDataReader sdr = GetDataReader(sql);
            List<T> list = DataReaderToList<T>(sdr);
            if (!sdr.IsClosed)//数据流关闭
            {
                sdr.Close();
            }
            return list;
        }
        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            try
            {
                //打开
                //判断状态
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                object n = cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return n;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

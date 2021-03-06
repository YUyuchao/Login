﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CLDataBase
{
    public class CDataBase
    {
        //public static string connStr = @"Data Source=.;Initial Catalog=demo;Integrated Security=true";
        public static string connStr = @"Data Source=OMEN\SQLEXPRESS;Initial Catalog=demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public static SqlConnection conn = new SqlConnection(connStr);
        
         //“读”数据的静态方法
        public static DataSet GetDataFromDB(string sqlStr)
        {
            conn.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter(sqlStr, conn);
            DataSet myDataSet = new DataSet();
            myDataSet.Clear();
            myAdapter.Fill(myDataSet);
            conn.Close();
            if (myDataSet.Tables[0].Rows.Count != 0)
            {
                return myDataSet;
            }
            else
            {
                return null;
            }
        }

        //“写”数据的静态方法
        public static bool UpdateDB(string sqlStr)
        {
            bool boo=true;
            conn.Open();
            // 定义数据命令对象
            SqlCommand myCmd = new SqlCommand(sqlStr, conn);
            // 设置Command对象的CommandType属性
            myCmd.CommandType = CommandType.Text;
            // 执行SQL语句
            try
            {
                myCmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                // 数据更新成功,返回true
            }
            return boo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Sstorage
{
    namespace DAL
    {
        public class SqlObject
        {
            public string ConnectionStr { get; set; }
            public static SqlConnection conn { get; set; }
            public static SqlCommand cmd { get; set; }

            public SqlObject()
            {
                ConnectionStr = ConfigurationManager.ConnectionStrings["strDB"].ConnectionString;
                conn = new SqlConnection();
                conn.ConnectionString = ConnectionStr;
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;

            }

            public SqlDataReader ExecuteReader(string Sql)
            {
                cmd.CommandText = Sql;
                return cmd.ExecuteReader();
            }


            public void Close()
            {
                conn.Close();
            }
            public void ExecuteNonQuery(string str) 
            {
                cmd.CommandText = str;
                cmd.ExecuteNonQuery();

            }
            public int ExecuteScalarInt(string str)
            {
                cmd.CommandText = str;
                int a =(int)cmd.ExecuteScalar();
                return a;
            }
            public string ExecuteScalarString(string str)
            {
                cmd.CommandText = str;
                string a = (string)cmd.ExecuteScalar();
                return a;
            }
            public DataTable Execute(string Sql)
            {
                cmd.CommandText = Sql;
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                return Dt;

            }
            public DataTable ExecuteKeyValue(string TextField, string ValueField, string TableName)
            {
                string Sql = "Select " + TextField + " AS TextField," + ValueField + " AS ValueField From " + TableName;
                return Execute(Sql);
            }
            public DataTable ExecuteKeyValue1(string TextField, string ValueField, string TableName)
            {
                string Sql = "Select " + TextField + " AS TextField," + ValueField + " AS ValueField From " + TableName;
                Sql += " where StorageId > 2";
                return Execute(Sql);
            }
            public DataTable ExecuteKeyValueSorting(string TextField, string ValueField, string TableName , string BySorting)
            {
                string Sql = "Select " + TextField + " AS TextField," + ValueField + " AS ValueField From " + TableName + " order by " + BySorting;
                return Execute(Sql);
            }
            public DataTable FillTable(string Name) 
            {
                DataTable Dt = new DataTable();
                string sql = "select * from "+Name;
                Dt = Execute(sql);
                return Dt;
            }
            public DataTable FillPartOfTable(string Name,int SumColumn, string[] Columns)
            {
                DataTable Dt = new DataTable();                
                string sql = "";
                string sqlTemp = "select";
                for(int i = 0; i < SumColumn; i++)
                {
                    sqlTemp += " " + Columns[i] + ",";
                }
                for(int j = 0; j < (sqlTemp.Length - 1); j++)
                {
                    sql += sqlTemp[j];
                }
                sql += "  FROM " + Name;
                Dt = Execute(sql);
                return Dt;
            }
        }      
    }
    
}
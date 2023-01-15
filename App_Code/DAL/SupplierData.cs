using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Sstorage.BLL;

namespace Sstorage
{
    namespace DAL
    {
        public class SupplierData
        {
            public static void AddSupplier(Supplier Sup)
            {                               
                    string str = "insert into  Tsuppliers (supplierName, supplierPhone, supplierEmail, CatId)";
                    str += "values(N'" + Sup.SupName + "',N'" + Sup.SupPhone + "',N'" + Sup.SupEmail + "'," + Sup.CatId + ")";
                    SqlObject sql = new SqlObject();
                    sql.ExecuteNonQuery(str);
                    sql.Close();                
            }
            public static void UpSupplier(Supplier Sup)
            {                  
                string str = "update Tsuppliers set supplierName =N'" + Sup.SupName + "' , supplierPhone =N'" + Sup.SupPhone + "' , supplierEmail =N'" + Sup.SupEmail + "' , CatId=" + Sup.CatId ;
                str += " where SupplierId=" + Sup.SupId;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static int isExist(Supplier Sup)
            {
                int Exist = 0;
                string str = " select * from Tsuppliers where supplierName=N'";
                str += "" + Sup.SupName + "'";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                if (dr.Read())
                {
                    Exist = 1;

                }
                sql.Close();
                return Exist;
            }
            public static List<Supplier> GetAllSuppliers()
            {
                List<Supplier> LstSUP = new List<Supplier>();
                string str = " select * from Tsuppliers ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    Supplier SUP = new Supplier();
                    SUP.SupId = (int)dr["SupplierId"];
                    SUP.SupName = (string)dr["SupplierName"];
                    SUP.SupPhone = (string)dr["SupplierPhone"];
                    SUP.SupEmail = (string)dr["SupplierEmail"];
                    SUP.CatId = (int)dr["CatId"];                    
                    LstSUP.Add(SUP);
                }
                sql.Close();
                return LstSUP;
            }
        }
    }    
}
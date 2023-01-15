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
        public class CategoryData
        {

            public static int isExist(Category Cat)
            {
                int cid = 0;
                string str = " select CatId from Tcategorys where CatName=";
                str += "'" + Cat.CatName + "'";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                if (dr.Read())
                {
                    cid = (int)dr["RatingId"];

                }
                sql.Close();
                return cid;
            }
            public static void AddCategory(Category Cat)
            {
                string str = "insert into  Tcategorys (CatName)";
                str += "values(N'" + Cat.CatName + "')";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static void UpCategory(Category Cat)
            {
                string str = "update  Tcategorys set CatName =N'" + Cat.CatName + "'";
                str += " where CatId=" + Cat.CatId;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
        }
    }    
}
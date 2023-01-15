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
        public class UserData
        {
            public static int isExist(User user)
            {
                int uid = 0;
                string str = " select RatingId from Tusers where UserName=";
                str += "'" + user.Name + "'" + " and UserPassword=" + "'" + user.Password + "'";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                if (dr.Read())
                {
                    uid = (int)dr["RatingId"];

                }
                sql.Close();
                return uid;
            }
            public static int ValidAdd(User user)
            {
                int flag = 0;
                string str = " select RatingId from Tusers where UserName=";
                str += "'" + user.Name + "'";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                if (dr.Read())                
                    flag = 1;
                
                sql.Close();
                return flag;
            }
            public static User getUser(User USER)
            {

                SqlObject sql = new SqlObject();
                string str = "select UserId, UserName, UserPassword, RatingId from Tusers where UserName='" + USER.Name+ "' and UserPassword = '"+ USER.Password +"'";
                string userName = "";
                string userPassword = "";
                int userId = 0;
                int ratingId = 0;
                SqlDataReader dr = sql.ExecuteReader(str);
                if (dr.Read())
                {
                    userId = (int)dr["UserId"];
                    userName = (string)dr["UserName"];
                    userPassword = (string)dr["UserPassword"];
                    ratingId = (int)dr["RatingId"];
                }
                sql.Close();
                User user = new User(userId, userName, userPassword, ratingId);
                return user;
            }
            public static void AddUser(User USER)
            {                                
                string str = "insert into  Tusers (UserName, UserPassword, RatingId)";
                str += "values('" + USER.Name + "'" + ",'" + USER.Password + "'" + "," + USER.Rid + ")";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static void UpUser(User USER)
            {
                string str = "update  Tusers set UserName =N'" + USER.Name + "' , UserPassword =N'" + USER.Password + "' , RatingId =" + USER.Rid ;
                str += " where UserId=" + USER.Uid;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static List<User> GetAllUsers()
            {
                List<User> LstUsers = new List<User>();
                string str = " select * from Tusers ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    User user = new User();
                    user.Uid = (int)dr["UserId"];
                    user.Name = (string)dr["UserName"];
                    user.Password = (string)dr["UserPassword"];
                    user.Rid = (int)dr["RatingId"];
                    LstUsers.Add(user);
                }
                sql.Close();
                return LstUsers;
            }
        }
    }

}
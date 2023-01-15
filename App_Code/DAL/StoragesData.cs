using Sstorage.BLL;
using Sstorage.admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Sstorage
{
    namespace DAL
    {
        public class StoragesData
        {
            public static int isExist(Storages storage)
            {
                int strid = 0;
                string str = " select StorageId from Tstorages where StorageName=";
                str += "'" + storage.StorageName + "'";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                if (dr.Read())
                {
                    strid = (int)dr["RatingId"];

                }
                sql.Close();
                return strid;
            }            
            public static void AddStorage(Storages storage)
            {
                string str = "insert into  Tstorages (StorageName, CityId, Street, HomeNumber, Phone, Email )";
                str += "values(N'" + storage.StorageName + "'" + ",'" + storage.CityId + "',N'" + storage.Street + "','" + storage.HomeNumber + "','" + storage.Phone + "','" + storage.Email + "')";
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                str = "select max(StorageId) from Tstorages";
                int id = sql.ExecuteScalarInt(str);
                str = "insert into TstoragesLocators (StorageId , LocatorName ) values ( " + id + " ,' A ')";
                sql.ExecuteNonQuery(str);
                str = "select max(StoragesLocatorId) from TstoragesLocators";
                id = sql.ExecuteScalarInt(str);
                string str2 = "";
                str = "select ProdId from Tproducts ";              
                SqlDataReader dr1 = sql.ExecuteReader(str);
                while (dr1.Read())
                {
                    str2 += "insert into TInventorys (ProdId,StoragesLocatorId,quantity) values ( " ;
                    str2 += "" + (int)dr1["ProdId"] + " , " + id + " , 0  ); ";

                }
                if(storage.StorageId == 1)
                {
                    str2 += "insert into TInventorys (ProdId,StoragesLocatorId,quantity) values ( ";
                    str2 += "" + (int)dr1["ProdId"] + " , " + 400 + " , 0  ); ";
                }
                
                sql.Close();
                SqlObject sql2 = new SqlObject();
                sql2.ExecuteNonQuery(str2);
                sql2.Close();
            }
            public static void UpStorage(Storages storage)
            {
                string str = "update  Tstorages set StorageName =N'" + storage.StorageName + "' , CityId ='" + storage.CityId + "' , Street =N'" + storage.Street + "' , HomeNumber ='" + storage.HomeNumber + "' , Phone ='" + storage.Phone + "' , Email ='" + storage.Email + "'";
                str += " where StorageId=" + storage.StorageId;
                SqlObject sql = new SqlObject();
                sql.ExecuteNonQuery(str);
                sql.Close();
            }
            public static List<Storages> GetAllStorages()
            {
                List<Storages> LstStorages = new List<Storages>();
                string str = " select * from Tstorages ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr = sql.ExecuteReader(str);
                while (dr.Read())
                {
                    Storages storages = new Storages();
                    storages.StorageId = (int)dr["StorageId"];
                    storages.StorageName = (string)dr["StorageName"];
                    storages.CityId = (int)dr["CityId"];
                    storages.Street = (string)dr["Street"];
                    storages.HomeNumber = (string)dr["HomeNumber"];
                  //  storages.DirectorName = (string)dr["DirectorName"];
                    storages.Phone = (string)dr["Phone"];
                    storages.Email = (string)dr["Email"];
                    LstStorages.Add(storages);
                }
                sql.Close();
                return LstStorages;
            }
        }
    }    
}
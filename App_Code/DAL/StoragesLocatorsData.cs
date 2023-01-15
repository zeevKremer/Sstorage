using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.BLL;
using Sstorage.admin;
using System.Data.SqlClient;

namespace Sstorage
{
    namespace DAL
    {
        public class StoragesLocatorsData
        {

            public static List<StoragesLocators> GetAllLocators()
            {
                List<StoragesLocators> LstStoragesLocators = new List<StoragesLocators>();
                string str = " select* from TstoragesLocators ";               
                SqlObject sql = new SqlObject();
                SqlDataReader dr1 = sql.ExecuteReader(str);
                while (dr1.Read())
                {
                    StoragesLocators SL = new StoragesLocators();
                    SL.StoragesLocatorId = (int)dr1["StoragesLocatorId"];
                    SL.StorageId = (int)dr1["StorageId"];
                    SL.LocatorName = (string)dr1["LocatorName"];
                    LstStoragesLocators.Add(SL);                    
                }
                sql.Close();
                return LstStoragesLocators;
            }
        }
    }    
}
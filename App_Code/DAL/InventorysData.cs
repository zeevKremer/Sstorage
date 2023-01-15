using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sstorage.admin;
using Sstorage.BLL;

namespace Sstorage
{ 
    namespace DAL
    {
        public class InventorysData
        {

            public static List<Inventorys> GetAllInventorys()
            {
                List<Inventorys> LstInventorys = new List<Inventorys>();
                string str = " select * from TInventorys ";
                SqlObject sql = new SqlObject();
                SqlDataReader dr1 = sql.ExecuteReader(str);
                while (dr1.Read())
                {
                    Inventorys Inventory = new Inventorys();
                    Inventory.InventoryId = (int)dr1["InventoryId"];
                    Inventory.ProdId = (int)dr1["ProdId"];
                    Inventory.StoragesLocatorId = (int)dr1["StoragesLocatorId"];
                    Inventory.Quantity = (int)dr1["Quantity"];
                    LstInventorys.Add(Inventory);
                }
                sql.Close();
                return LstInventorys;
            }
            public static List<Inventorys> GetInventorysByPid(Product Prod)
            {
                List<Inventorys> LstInvt = new List<Inventorys>();
                string str1 = " select * from TInventorys where ProdId=" + Prod.ProdId + "  order by StoragesLocatorId";
                SqlObject sql1 = new SqlObject();
                SqlDataReader dr1 = sql1.ExecuteReader(str1);
                while (dr1.Read())
                {
                    Inventorys Inventory = new Inventorys();                    
                    Inventory.ProdId = (int)dr1["ProdId"];
                    Inventory.StoragesLocatorId = (int)dr1["StoragesLocatorId"];
                    Inventory.Quantity = (int)dr1["Quantity"];
                    LstInvt.Add(Inventory);
                }
                sql1.Close();
                List<StoragesLocators> LstSL = new List<StoragesLocators>();
                string str2 = " select * from TstoragesLocators  order by StorageId";
                SqlObject sql2 = new SqlObject();
                SqlDataReader dr2 = sql2.ExecuteReader(str2);
                while (dr2.Read())
                {
                    StoragesLocators SL = new StoragesLocators();
                    SL.StoragesLocatorId = (int)dr2["StoragesLocatorId"];
                    SL.StorageId = (int)dr2["StorageId"];
                    SL.LocatorName = (string)dr2["LocatorName"];
                    LstSL.Add(SL);
                }
                sql2.Close();
                for(int i=0;i< LstInvt.Count;i++)
                {
                    for(int j =0; j<LstSL.Count;j++)
                    {
                        if (LstInvt[i].StoragesLocatorId == LstSL[j].StoragesLocatorId)
                        {
                            LstInvt[i].StoragesLocatorId = LstSL[j].StorageId;
                            LstInvt[i].LocatorName = LstSL[j].LocatorName;
                        }
                    }
                }
                List<Inventorys> LstInvt2 = new List<Inventorys>();
                for (int i = 0; i < LstInvt.Count; i++)
                {
                    Inventorys invt = new Inventorys();
                    LstInvt2.Add(invt);
                }
                int flag = 0;
                int index = 1;
                int remov = 0;
                int flag2 = 0;
                string html = "$*";
                LstInvt2[0] = LstInvt[0];
                for (int i = 1; i < LstInvt.Count; i++)
                {
                    for (int j = 0; j < i ; j++)
                    {
                       if(LstInvt2[j].StoragesLocatorId == LstInvt[i].StoragesLocatorId)
                        { if(flag2 == 0)
                            {
                                html += LstInvt2[j].StoragesLocatorId + "*" + LstInvt2[j].LocatorName + "*" + LstInvt2[j].Quantity + "#*";
                                flag2++;
                            }
                            flag = 1;
                            LstInvt2[j].Quantity += LstInvt[i].Quantity;
                            LstInvt2[j].LocatorName = "הצג מיקומים";
                            remov++;
                            html += LstInvt[i].StoragesLocatorId + "*" + LstInvt[i].LocatorName + "*" + LstInvt[i].Quantity + "#*";                               
                        }
                    }
                    if(flag == 0)
                    {
                        LstInvt2[index] = LstInvt[i];
                        index ++;

                    }
                    flag = 0;

                }
                List<Surface> LstSurfaces = new List<Surface>();
                Surface surfac = new Surface();
                LstSurfaces = surfac.GetAllSurfaces();
                List<Inventorys> LstInvt3 = new List<Inventorys>();
                html += "$*";
                for (int i = 0; i < (LstInvt2.Count - remov); i++)
                {
                    Inventorys invt = new Inventorys();
                    invt = LstInvt2[i];
                    LstInvt3.Add(invt);
                }
                for (int i = 0; i < LstInvt3.Count ; i++)
                {
                    if(LstInvt3[i].StoragesLocatorId == 4)
                    {
                        for (int j = 0; j < LstSurfaces.Count; j++)
                        {
                            if(LstSurfaces[j].ProdId == Prod.ProdId)
                            {
                                html += "4*" + LstSurfaces[j].SurfaceId + "*" + LstSurfaces[j].LocatorName + "*" + LstSurfaces[j].Quantity + "#*";
                            }
                        }
                    }                    
                }
                Inventorys invt4 = new Inventorys();
                invt4.LocatorName = html;                
                LstInvt3.Add(invt4);
                return LstInvt3;
            }
        }
    }    
}
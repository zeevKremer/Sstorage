using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public class Orders
        {

            public int OrderId { get; set; }
            public int UserId { get; set; }
            public string UserName { get; set; }
            public int StorageSenderId { get; set; }            
            public int StorageGeterId { get; set; }
            public string StorageGeterName { get; set; }
            public int SumProd { get; set; }
            public string Status { get; set; }
            public DateTime Date { get; set; }

            public Orders(int OrderId, int UserId, string UserName, int StorageSenderId, int StorageGeterId, string StorageGeterName, int SumProd, string Status, DateTime Date)
            {
                this.OrderId = OrderId;
                this.UserId = UserId;
                this.UserName = UserName;
                this.StorageSenderId = StorageSenderId;                
                this.StorageSenderId = StorageSenderId;
                this.StorageGeterName = StorageGeterName;
                this.SumProd = SumProd;
                this.Status = Status;
                this.Date = Date;
            }
            
            public Orders()
            {

            }

            public static int isExist(int StorageSenderId, int StorageGeterId)
            {
                int isExist = OrdersData.isExist(StorageSenderId, StorageGeterId);
                return isExist;
            }

            public int OpenOrder(Orders order)
            {
                int id;
                id = OrdersData.OpenOrder(order);
                return id;
            }

            public List<Orders> GetAllOrders()
            {
                List<Orders> LstORD = new List<Orders>();
                LstORD = OrdersData.GetAllOrders();
                return LstORD;
            }
            public List<Orders> GetTenOrders()
            {
                List<Orders> LstORD = new List<Orders>();
                LstORD = OrdersData.GetTenOrders();
                return LstORD;
            }
            public static Orders GetOrderById(int id)
            {
                Orders ORD = new Orders();
                ORD = OrdersData.GetOrderById(id);
                return ORD;
            }

            public static void CloseOrderById(int id)
            {
                OrdersData.CloseOrderById(id);
            }

            public List<Orders> GetOrderByColumnName(string ColumnName, int value)
            {
                List<Orders> LstORD = new List<Orders>();
                LstORD = OrdersData.GetOrderByColumnName(ColumnName, value);
                return LstORD;
            }
            public List<Orders> GetOrderByColumnName(string ColumnName, string value)
            {
                List<Orders> LstORD = new List<Orders>();
                LstORD = OrdersData.GetOrderByColumnName(ColumnName, value);
                return LstORD;
            }

        }
    }
    
}
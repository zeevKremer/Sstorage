using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{ namespace BLL
    {
        public class Supplier
        {
            public int SupId { get; set; }
            public string SupName { get; set; }
            public string SupPhone { get; set; }
            public string SupEmail { get; set; }
            public int CatId { get; set; }
            public Supplier()
            {                
            }
            public Supplier(int SupId, string SupName, string SupPhone, string SupEmail, int CatId)
            {
                this.SupId = SupId;
                this.SupName = SupName;
                this.SupPhone = SupPhone;
                this.SupEmail = SupEmail;
                this.CatId = CatId;
            }
            public Supplier(string SupName, string SupPhone, string SupEmail, int CatId)
            {                
                this.SupName = SupName;
                this.SupPhone = SupPhone;
                this.SupEmail = SupEmail;
                this.CatId = CatId;
            }
            public void AddSupplier(Supplier Sup)
            {
                SupplierData.AddSupplier(Sup);
            }
            public void UpSupplier(Supplier Sup)
            {
                SupplierData.UpSupplier(Sup);
            }
            public int isExist(Supplier Sup)
            {
                int Exist = 0;
                Exist = SupplierData.isExist(Sup);
                return Exist;
            }

            public List<Supplier> GetAllSuppliers()
            {
                List<Supplier> LstSUP = new List<Supplier>();
                LstSUP = SupplierData.GetAllSuppliers();
                return LstSUP;
            }
        }
    }   
}
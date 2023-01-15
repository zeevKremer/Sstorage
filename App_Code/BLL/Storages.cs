using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;
using Sstorage.admin;

namespace Sstorage
{
    namespace BLL
    {
        public class Storages
        {
            public int StorageId { get; set; }
            public string StorageName { get; set; }
            public int CityId { get; set; }
            public string Street { get; set; }
            public string HomeNumber { get; set; }
            public string DirectorName { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public Storages()
            {

            }
            public Storages(int StorageId , string StorageName, int CityId, string Street, string HomeNumber, string DirectorName, string Phone, string Email)
            {
                this.StorageId = StorageId;
                this.StorageName = StorageName;
                this.CityId = CityId;
                this.Street = Street;
                this.HomeNumber = HomeNumber;
                this.DirectorName = DirectorName;
                this.Phone = Phone;
                this.Email = Email;
            }
            public Storages(string StorageName, int CityId, string Street, string HomeNumber, string DirectorName, string Phone, string Email)
            {
                this.StorageName = StorageName;
                this.CityId = CityId;
                this.Street = Street;
                this.HomeNumber = HomeNumber;
                this.DirectorName = DirectorName;
                this.Phone = Phone;
                this.Email = Email;
            }
            public List<Storages> GetAllStorages()
            {
                List<Storages> LstStorages = new List<Storages>();
                LstStorages = StoragesData.GetAllStorages();
                return LstStorages;
            }
            public int isExist(Storages storage)
            {
                int strid;
                strid = StoragesData.isExist(storage);
                return strid;
            }
            public void AddStorage(Storages storage)
            {
                StoragesData.AddStorage(storage);
            }
            public void UpStorage(Storages storage)
            {
                StoragesData.UpStorage(storage);
            }
        }
    }    
}
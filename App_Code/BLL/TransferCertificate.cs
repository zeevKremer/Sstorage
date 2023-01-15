using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.BLL;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public class TransferCertificate
        {

            public int CertificateId { get; set; }
            public int UserId { get; set; }
            public string UserName { get; set; }
            public int StorageSenderId { get; set; }
            public string StorageSenderName { get; set; }
            public int StorageGeterId { get; set; }
            public string StorageGeterName { get; set; }
            public int SumProd { get; set; }
            public string Status { get; set; }
            public DateTime Date { get; set; }


            public TransferCertificate(int CertificateId, int UserId, string UserName, int StorageSenderId, string StorageSenderName, int StorageGeterId, string StorageGeterName, int SumProd, string Status, DateTime Date)
            {
                this.CertificateId = CertificateId;
                this.UserId = UserId;
                this.UserName = UserName;
                this.StorageSenderId = StorageSenderId;
                this.StorageSenderName = StorageSenderName;
                this.StorageSenderId = StorageSenderId;
                this.StorageGeterName = StorageGeterName;
                this.SumProd = SumProd;
                this.Status = Status;
                this.Date = Date;
            }
            public TransferCertificate(int CertificateId, int UserId, int StorageSenderId, int StorageGeterId, string Status, DateTime Date)
            {
                this.CertificateId = CertificateId;
                this.UserId = UserId;
                this.StorageSenderId = StorageSenderId;
                this.StorageGeterId = StorageGeterId;
                this.Status = Status;
                this.Date = Date;
            }
            public TransferCertificate(int UserId, int StorageSenderId, int StorageGeterId, DateTime Date)
            {
                this.UserId = UserId;
                this.StorageSenderId = StorageSenderId;
                this.StorageGeterId = StorageGeterId;
                this.Date = Date;
            }
            public TransferCertificate(int UserId, int StorageSenderId, int StorageGeterId)
            {
                this.UserId = UserId;
                this.StorageSenderId = StorageSenderId;
                this.StorageGeterId = StorageGeterId;
            }
            public TransferCertificate()
            {

            }
            public static int isExist(int StorageSenderId, int StorageGeterId)
            {
                int isExist = TransferCertificateData.isExist(StorageSenderId,StorageGeterId);
                return isExist;
            }

            public int OpenTransferCertificate(TransferCertificate transferCertificate)
            {
                int id ;
                id = TransferCertificateData.OpenTransferCertificate( transferCertificate);
                return id;
            }            
            public int Pull()
            {
                int Pid = TransferCertificateData.Pull();
                return Pid;
            }
            public List<TransferCertificate> GetAllCertificats()
            {
                List<TransferCertificate> LstTC = new List<TransferCertificate>();
                LstTC = TransferCertificateData.GetAllCertificats();
                return LstTC;
            }
            public List<TransferCertificate> GetTenCertificats()
            {
                List<TransferCertificate> LstTC = new List<TransferCertificate>();
                LstTC = TransferCertificateData.GetTenCertificats();
                return LstTC;
            }
            public static TransferCertificate GetCertificatById(int id)
            {
                TransferCertificate TC = new TransferCertificate();
                TC = TransferCertificateData.GetCertificatById(id);
                return TC;
            }    
            
                public static void CloseCertificatById(int id)
            {                
                TransferCertificateData.CloseCertificatById(id);               
            }

            public List<TransferCertificate> GetCertificatsByColumnName(string ColumnName , int value)
            {
                List<TransferCertificate> LstTC = new List<TransferCertificate>();
                LstTC = TransferCertificateData.GetCertificatsByColumnName( ColumnName,  value);
                return LstTC;
            }
            public List<TransferCertificate> GetCertificatsByColumnName(string ColumnName, string value)
            {
                List<TransferCertificate> LstTC = new List<TransferCertificate>();
                LstTC = TransferCertificateData.GetCertificatsByColumnName( ColumnName,  value);
                return LstTC;
            }

        }
    }


}
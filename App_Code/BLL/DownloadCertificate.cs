using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.admin;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public class DownloadCertificate
        {
            public int CertificateId { get; set; }
            public int UserId { get; set; }
            public int StorageSenderId { get; set; }
            public int StorageGeterId { get; set; }
            public DateTime Date { get; set; }

            public DownloadCertificate(int CertificateId, int UserId, int StorageSenderId, int StorageGeterId, DateTime Date)
            {
                this.CertificateId = CertificateId;
                this.UserId = UserId;
                this.StorageSenderId = StorageSenderId;
                this.StorageGeterId = StorageGeterId;
                this.Date = Date;
            }
            public DownloadCertificate(int UserId, int StorageSenderId, int StorageGeterId, DateTime Date)
            {
                this.UserId = UserId;
                this.StorageSenderId = StorageSenderId;
                this.StorageGeterId = StorageGeterId;
                this.Date = Date;
            }
            public DownloadCertificate(int UserId, int StorageSenderId, int StorageGeterId)
            {
                this.UserId = UserId;
                this.StorageSenderId = StorageSenderId;
                this.StorageGeterId = StorageGeterId;
            }
            public DownloadCertificate()
            {

            }

            public int OpenDownloadCertificate(DownloadCertificate downloadCertificate)
            {
                int id;
                id = DownloadCertificateData.OpenDownloadCertificate(downloadCertificate);
                return id;
            }
            public int Pull()
            {
                int Pid = DownloadCertificateData.Pull();
                return Pid;
            }

        }
    }    
}
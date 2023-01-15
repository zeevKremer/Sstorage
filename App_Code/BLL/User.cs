using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public class User
        {
            public int Uid { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public int Rid { get; set; }
            public string AddingDate { get; set; }


            public User()
            {
                this.Uid = 0;
                this.Name = "";
                this.Password = "";
                this.Rid = 0;
                this.AddingDate = "";
                

            }
            public User(int Uid, string Name, string Password, int Rid, string AddingDate)
            {
                this.Uid = Uid;
                this.Name = Name;
                this.Password = Password;
                this.Rid = Rid;
                this.AddingDate = AddingDate;
            }
            public User(int Uid, string Name, string Password, int Rid)
            {
                this.Uid = Uid;
                this.Name = Name;
                this.Password = Password;
                this.Rid = Rid;               
            }
            public User(string Name, string Password, int Rid)
            {               
                this.Name = Name;
                this.Password = Password;
                this.Rid = Rid;
            }
            public User(int Uid)
            {
                this.Uid = Uid;
                
            }
            public User(string Name, string Password)
            {                
                this.Name = Name;
                this.Password = Password;                
            }
            public int isExist(User user)
            {
                int uid;
                uid = UserData.isExist(user);
                return uid;
            }
            public int ValidAdd(User user)
            {
                int flag;
                flag = UserData.ValidAdd(user);
                return flag;
            }

            public User getUser(User USER)
            {
                User user = UserData.getUser(USER);                
                return user;
            }
            public List<User> GetAllUsers()
            {
                List<User> LstUsers = new List<User>();
                LstUsers = UserData.GetAllUsers();
                return LstUsers;
            }
            public void AddUser(User USER)
            {
                 UserData.AddUser(USER);                
            }
            public void UpUser(User USER)
            {
                UserData.UpUser(USER);
            }

        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sstorage.DAL;

namespace Sstorage
{
    namespace BLL
    {
        public class Category
        {
            public int CatId { get; set; }
            public string CatName { get; set; }
            public int FatherId { get; set; }
            public Category()
            {
                this.CatId = 0;
                this.CatName = "";                
                this.FatherId = 0;

            }
            public Category(int CatId, string CatName,int FatherId)
            {
                this.CatId = CatId;
                this.CatName = CatName;
                this.FatherId = FatherId;               
            }


            public void AddCategory(Category Cat)
            {
                CategoryData.AddCategory(Cat);
            }
            public void UpCategory(Category Cat)
            {
                CategoryData.UpCategory(Cat);
            }
            public int isExist(Category Cat)
            {
                int Exist = 0;
                Exist = CategoryData.isExist(Cat);
                return Exist;
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sstorage
{namespace BLL
    {
        public class Funcs
        {
            public static string RandomName(int Size)
            {
                string Chars = "abcdefghijklmnopqrstuvwxyz0123456789";
                string Name = "";
                Random rnd = new Random();
                int index;
                for (int i = 0; i < Size; i++)
                {
                    index = rnd.Next(Chars.Length - 1);
                    Name += Chars[index];
                }

                return Name;

            }
        }
    }    
}
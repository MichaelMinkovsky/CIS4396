using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibrary
{
    public class PhotoName
    {
        string currentPhoto;
        int userId;

        public string CurrentPhoto 
        {
         get{return currentPhoto;}
            set { currentPhoto = value; }
        }

        public int UserID
        {
            get { return userId; }
            set { userId = value; }
        }

        public PhotoName() { }

        public PhotoName(string CurrentPhoto, int UserId) 
        {
            currentPhoto = CurrentPhoto;
            userId = UserId;
        }
    }
}

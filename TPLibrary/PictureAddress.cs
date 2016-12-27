using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibrary
{
   public class PictureAddress
    {
        string filename;

            public string Filename
            {
                get{return filename;}
                set {filename=value ;} 
            }

        public PictureAddress(string Filename)
        {filename = Filename;}
    }
}

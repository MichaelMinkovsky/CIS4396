using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibrary
{
    public class School
    {
         string schoolName;
       DateTime startDay;
       DateTime endDay;
         string schoolDescription;
         string major;

        public string SchoolName
        {
          get{return schoolName;}
          set{schoolName = value;}
        }

        public DateTime StartDay
        {
            get{return startDay;}
          set{startDay = value;}
        }

        public DateTime EndDay
        {
        get{return endDay;}
          set{endDay = value;}
        }

        public string SchoolDescription
        {
            get{return schoolDescription;}
          set{schoolDescription = value;}
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public School() { }

        public School(string SchoolName, DateTime StartDay, DateTime EndDay, string SchoolDescription, string Major) 
        {
            schoolName = SchoolName;
            startDay = StartDay;
            endDay = EndDay;
            schoolDescription = SchoolDescription;
            major = Major;
        }
    }
}

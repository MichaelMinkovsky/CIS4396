using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibrary
{
    public class Job
    {
       string companyName;
       string position;
       string city;
       string description;

       public string CompanyName
       {
           get { return companyName; }
           set {companyName= value;}
       }

       public string Position
       {
           get { return position; }
           set { position = value; }
       }

       public string City
       {
           get { return city; }
           set { city = value; }
       }

       public string Description
       {
           get { return description; }
           set { description = value; }
       }

       public Job() { }

       public Job(string CompanyName, string Position, string City, string Description)
       {
       companyName = CompanyName;
       position = Position;
       city = City;
       description = Description;
       }
    }
}

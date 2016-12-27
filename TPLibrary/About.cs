using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibrary
{
    public class About
    {
        string aboutMe;
        string favoriteQoutes;
        string hobbies;

        public string AboutMe
        {
            get { return aboutMe; }
            set { aboutMe = value; }
        }

        public string FavoriteQoutes
        {
            get { return favoriteQoutes; }
            set { favoriteQoutes = value; }
        }

        public string Hobbies
        {
            get { return hobbies; }
            set { hobbies = value; }
        }

        public About() { }

        public About(string About, string favoriteQoutes, string Hobbies) 
        {
            aboutMe = About;
            favoriteQoutes = FavoriteQoutes;
            hobbies = Hobbies;
        }
    }
}

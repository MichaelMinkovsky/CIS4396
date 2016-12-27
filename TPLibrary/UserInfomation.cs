using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLibrary
{
    public class UserInfomation
    {
           int userId;
        string firstName;
        string lastName;
        string username;
        string password;
        string emailAddress;
        string address;
        string city;
        string state;
        string question1;
        string question2;
        string question3;
        string answer1;
        string answer2;
        string answer3;
        string font;
        string fontColor;
        string bgColor;
        string photoPrivacy;
        string profilePrivacy;
        string personalPrivacy;

        public int UserId
        {
           get{return userId;}
           set{userId = value;}
        } 

        public string FirstName
        {
           get{return firstName;}
           set{firstName = value;}
        } 

        public string LastName
        {
           get{return lastName;}
           set{lastName = value;}
        } 

        public string Username
        {
           get{return username;}
           set{username = value;}
        }

        public string Password
        {
           get{return password;}
           set{password = value;}
        }

        public string EmailAddress
        {
           get{return emailAddress;}
           set{emailAddress = value;}
        }

        public string Address
        {
           get{return address;}
           set{address = value;}
        }

        public string City
        {
           get{return city;}
           set{city = value;}
        }

        public string State
        {
           get{return state;}
           set{state = value;}
        }

        public string Question1
        {
           get{return question1;}
           set{question1 = value;}
        }

        public string Question2
        {
           get{return question2;}
           set{question2 = value;}
        }

        public string Question3
        {
           get{return question3;}
           set{question3 = value;}
        }

        public string Answer1
        {
           get{return answer1;}
           set{answer1 = value;}
        }

        public string Answer2
        {
           get{return answer2;}
           set{answer2 = value;}
        }

        public string Answer3
        {
            get { return answer3; }
            set { answer3 = value; }
        }
        
        public string Font
        {
            get { return font; }
            set { font = value; }
        }

        public string FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }

        public string BgColor
        {
            get { return bgColor; }
            set { bgColor = value; }
        }

        public string PhotoPrivacy
        {
            get { return photoPrivacy;}
            set { photoPrivacy = value; }
        }

        public string ProfilePrivacy
        {
            get { return profilePrivacy; }
            set { profilePrivacy = value; }
        }

        public string PersonalPrivacy
        {
            get { return personalPrivacy; }
            set { personalPrivacy = value; }
        }
        
        public UserInfomation() { }

        public UserInfomation(int ID, string FirstName, string LastName, string Username, string Password, string EmailAddress, string Address,
           string City, string State, string Question1, string Answer1, string Question2, string Answer2, string Question3, string Answer3)
        {
            userId = ID;
            firstName = FirstName;
            lastName = LastName;
            username = Username;
            password = Password;
            emailAddress = EmailAddress;
            address = Address;
            city = City;
            state = State;
            question1 = Question1;
            answer1 = Answer1;
            question2 = Question2;
            answer2 = Answer2;
            question3 = Question3;
            answer3 = Answer3;
        }

        public UserInfomation(string FirstName, string LastName, string Username, string Password, string EmailAddress, string Address,
           string City, string State, string Question1, string Answer1, string Question2, string Answer2, string Question3, string Answer3, string Font, string FontColor, string BgColor)
        {
            firstName = FirstName;
            lastName = LastName;
            username = Username;
            password = Password;
            emailAddress = EmailAddress;
            address = Address;
            city = City;
            state = State;
            question1 = Question1;
            answer1 = Answer1;
            question2 = Question2;
            answer2 = Answer2;
            question3 = Question3;
            answer3 = Answer3;
            font = Font;
            fontColor = FontColor;
            bgColor = BgColor;
        }


        public UserInfomation(int ID, string FirstName, string LastName, string Username, string Password, string EmailAddress, string Address,
          string City, string State, string Question1, string Answer1, string Question2, string Answer2, string Question3, string Answer3, string Font,
            string FontColor, string BgColor, string PhotoPrivacy, string ProfilePrivacy, string PersonalPrivacy)
        {
             userId = ID;
            firstName = FirstName;
            lastName = LastName;
            username = Username;
            password = Password;
            emailAddress = EmailAddress;
            address = Address;
            city = City;
            state = State;
            question1 = Question1;
            answer1 = Answer1;
            question2 = Question2;
            answer2 = Answer2;
            question3 = Question3;
            answer3 = Answer3;
            font = Font;
            fontColor = FontColor;
            bgColor = BgColor;
            photoPrivacy = PhotoPrivacy;
            profilePrivacy = ProfilePrivacy;
            personalPrivacy = PersonalPrivacy;
        }
        //user setting
        public UserInfomation( string Font, string FontColor, string BgColor)
        {
            font = Font;
            fontColor = FontColor;
            bgColor = BgColor;
        }
        
    }
}

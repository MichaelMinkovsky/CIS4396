using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateLibrary
{
    public class Realtor
    {
        public string firstName, lastName, state, phoneNumber;

        public Realtor(string firstName, string lastName, string state, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.state = state;
            this.phoneNumber = phoneNumber;
        }
            
        public string FirstName
        {
            get {return firstName;}
            set {firstName = value;}
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

    }
}
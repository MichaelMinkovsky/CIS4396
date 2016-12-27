using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateLibrary
{
    public class Home
    {
        public string address, city, state, availability, homeType;
        public double listingPrice;
        public int squareFootage, numBedrooms, numBathrooms;

        public Home(string address, string city, string state, string availability, string homeType, double listingPrice, int squareFootage, int numBedrooms, int numBathrooms)        
        {
            this.address = address;
            this.city = city;
            this.state = state;
            this.availability = availability;
            this.homeType = homeType;
            this.listingPrice = listingPrice;
            this.squareFootage = squareFootage;
            this.numBedrooms = numBedrooms;
            this.numBathrooms = numBathrooms;
        }
            
        public string Address
        {
            get {return address;}
            set {address = value;}
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        public string HomeType
        {
            get { return homeType; }
            set { homeType = value; }
        }

        public double ListingPrice
        {
            get { return listingPrice; }
            set { listingPrice = value; }
        }

        public int SquareFootage
        {
            get { return squareFootage; }
            set { squareFootage = value; }
        }

        public int NumBedrooms
        {
            get { return numBedrooms; }
            set { numBedrooms = value; }
        }

        public int NumBathrooms
        {
            get { return numBathrooms; }
            set { numBathrooms = value; }
        }
        
    }
}
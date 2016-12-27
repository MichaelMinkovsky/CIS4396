using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilderLibrary
{
    public class Room
    {
        string roomDescription;
        double price;
        double upgradesCost;
        double totalCost;
        //double grandTotal;
        int length;
        int width;

        public Room()
        {

        }

        public Room(string roomDescription, double price, double upgradesCost, double totalCost)
        {
            this.roomDescription = roomDescription;
            this.price = price;
            this.upgradesCost = upgradesCost;
            this.totalCost = totalCost;
        }

        public Room(string roomDescription, double price, int length, int width)
        {
            this.roomDescription = roomDescription;
            this.price = price;
            this.length = length;
            this.width = width;
        }
            
        public string RoomDescription
        {
            get {return roomDescription;}
            set {roomDescription = value;}
        }

        public int Length
        {
            get { return length; }
            set { price = value; }
        }

        public int Width
        {
            get { return width; }
            set { price = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double UpgradesCost
        {
            get { return upgradesCost; }
            set { upgradesCost = value; }
        }

        public double TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        //public double GrandTotal
        //{
        //    get { return grandTotal; }
        //    set { grandTotal = value; }
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeBuilderLibrary
{
    public class Home
    {
        Room newRoom = new Room();
        Upgrade newUpgrade = new Upgrade();
        List<Room> roomList = new List<Room>();
        List<Upgrade> upgradeList = new List<Upgrade>();
        List<Room> outputRoomList = new List<Room>();
        public void AddRoom(string roomDescription, double price, int length, int width)
        {
            newRoom = new Room(roomDescription, price, length, width);
            roomList.Add(newRoom);
        }

        public void AddUpgrade(string upgradeDescription, double upgradePrice, string upgradeRoomName)
        {
            newUpgrade = new Upgrade(upgradeDescription, upgradePrice, upgradeRoomName);
            upgradeList.Add(newUpgrade);
        }

        public void DeleteRoom(string roomDescription)
        {
            foreach (Room item in roomList)
            {
                if (item.RoomDescription == roomDescription)
                {
                    roomList.Remove(item);
                }
            }
        }

        public void DeleteUpgrade(string upgradeDescription)
        {
            foreach (Upgrade item in upgradeList)
            {
                if (item.UpgradeDescription == upgradeDescription)
                {
                    UpgradeList.Remove(item);
                }
            }
        }

        public List<Room> RoomList
        {
            get { return roomList; }
        }

        public List<Upgrade> UpgradeList
        {
            get { return upgradeList; }
        }

        public List<Room> OutputRoomList
        {
            get { return outputRoomList; }
        }

        public List<Room> OutputList()
        {
            foreach (Room item in roomList)
            {
                string str = item.RoomDescription + " (" + item.Length + "X" + item.Width + ") with";
                double price = item.Price * item.Length * item.Width;
                double upgrade = 0;
                double totalCost = price + upgrade;
                double grandTotal = 0;
                grandTotal += totalCost;


                foreach (Upgrade item1 in upgradeList)
                {
                    if (item.RoomDescription.Contains(item1.UpgradeRoomName))
                    {
                        str += ", " + item1.UpgradeDescription;
                        upgrade += item1.UpgradePrice;
                        totalCost += upgrade;
                        grandTotal += totalCost;
                    }
                }

                Room roomOutput = new Room(str, price, upgrade, totalCost);
                OutputRoomList.Add(roomOutput);   
            }

            return outputRoomList;
        }
        
    }
}

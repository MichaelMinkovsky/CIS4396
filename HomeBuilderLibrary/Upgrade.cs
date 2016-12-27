using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBuilderLibrary
{
    public class Upgrade
    {
        string upgradeDescription;
        double upgradePrice;
        string upgradeRoomName;

        public Upgrade()
        {
        }

        public Upgrade(string upgradeDescription, double upgradePrice, string upgradeRoomName)
        {
            this.upgradeDescription = upgradeDescription;
            this.upgradePrice = upgradePrice;
            this.upgradeRoomName = upgradeRoomName;
        }

        public string UpgradeDescription
        {
            get { return upgradeDescription; }
            set { upgradeDescription = value; }
        }

        public double UpgradePrice
        {
            get { return upgradePrice; }
            set { upgradePrice = value; }
        }
        
        public string UpgradeRoomName
        {
            get { return upgradeRoomName; }
            set { upgradeRoomName = value; }
        }
    }
}

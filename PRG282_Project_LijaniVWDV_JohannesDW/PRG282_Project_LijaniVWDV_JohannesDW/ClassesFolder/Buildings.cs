using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_LijaniVWDV_JohannesDW
{
    class Buildings
    {
        private string buildingID;
        private string buildingName;
        private string buildingType;
        private int buildingHP;

        public string BuildingID { get => buildingID; set => buildingID = value; }
        public string BuildingName { get => buildingName; set => buildingName = value; }
        public string BuildingType { get => buildingType; set => buildingType = value; }
        public int BuildingHP { get => buildingHP; set => buildingHP = value; }

        public Buildings()
        {

        }

        public Buildings(string id, string name, string type, int hp)
        {
            this.buildingID = id;
            this.buildingName = name;
            this.buildingType = type;
            this.buildingHP = hp;
        }
    }
}

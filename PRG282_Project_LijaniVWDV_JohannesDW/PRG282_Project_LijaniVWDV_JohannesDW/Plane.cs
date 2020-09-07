using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_LijaniVWDV_JohannesDW
{
    class Plane
    {
        private int planeID;
        private string planeName;
        private string planeType;
        private int maxAltitude;
        private int maxSpeed;
        private int maxWeight;
        private int fuelCapacity;
        private int mountingPoints;

        public int PlaneID { get => planeID; set => planeID = value; }
        public string PlaneName { get => planeName; set => planeName = value; }
        public string PlaneType { get => planeType; set => planeType = value; }
        public int MaxAltitude { get => maxAltitude; set => maxAltitude = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public int MaxWeight { get => maxWeight; set => maxWeight = value; }
        public int FuelCapacity { get => fuelCapacity; set => fuelCapacity = value; }
        public int MountingPoints { get => mountingPoints; set => mountingPoints = value; }

        public Plane()
        {

        }

        public Plane(int id, string name, string type, int alt, int speed, int fuel, int mount)
        {
            this.planeID = id;
            this.planeName = name;
            this.planeType = type;
            this.maxAltitude = alt;
            this.maxSpeed = speed;
            this.fuelCapacity = fuel;
            this.mountingPoints = mount;
        }
    }
}

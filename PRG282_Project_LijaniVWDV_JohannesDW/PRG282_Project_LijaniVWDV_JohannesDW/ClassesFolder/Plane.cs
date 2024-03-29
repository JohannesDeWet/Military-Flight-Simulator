﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_LijaniVWDV_JohannesDW
{
    class Plane
    {
        private string planeID;
        private string planeName;
        private int planePH;
        private string planeType;
        private int maxAltitude;
        private int payload;
        private int cruiseSpeed;
        private int maxSpeed;
        private int fuelCapacity;
        private int mountingPoints;

        public string PlaneID { get => planeID; set => planeID = value; }
        public string PlaneName { get => planeName; set => planeName = value; }
        public int PlaneHP { get => planePH; set => planePH = value; }
        public string PlaneType { get => planeType; set => planeType = value; }
        public int MaxAltitude { get => maxAltitude; set => maxAltitude = value; }
        public int Payload { get => payload; set => payload = value; }
        public int CruiseSpeed { get => cruiseSpeed; set => cruiseSpeed = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public int FuelCapacity { get => fuelCapacity; set => fuelCapacity = value; }
        public int MountingPoints { get => mountingPoints; set => mountingPoints = value; }

        public Plane(){}
        public Plane(string id, string name, int hp, string type, int alt, int payload, int speedcruise, int speedmax, int fuel, int mount)
        {
            this.planeID = id;
            this.planeName = name;
            this.planePH = hp;
            this.planeType = type;
            this.maxAltitude = alt;
            this.payload = payload;
            this.cruiseSpeed = speedcruise;
            this.maxSpeed = speedmax;
            this.fuelCapacity = fuel;
            this.mountingPoints = mount;
        }
    }
}

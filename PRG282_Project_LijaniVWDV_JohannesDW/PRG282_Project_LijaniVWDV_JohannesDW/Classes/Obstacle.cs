using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_LijaniVWDV_JohannesDW
{
    class Obstacle
    {
        private string obstacleName;
        private int obstacleAltitude;

        //I am unsure of what else to add to this class? This class refers to the obstacles placed by the user
        //Was thinking of size or range, maybe something like damage? -- Lijani

        public string ObstacleName { get => obstacleName; set => obstacleName = value; }
        public int ObstacleAltitude { get => obstacleAltitude; set => obstacleAltitude = value; }

        public Obstacle()
        {

        }

        
    }
}

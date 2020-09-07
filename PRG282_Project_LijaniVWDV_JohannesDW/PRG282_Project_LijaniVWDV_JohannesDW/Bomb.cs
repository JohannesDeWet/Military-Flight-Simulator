using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_LijaniVWDV_JohannesDW
{
    class Bomb
    {
        private int bombID;
        private string bombName;
        private int bombWeight;
        private int damage;
        private int nrOfSlots;

        public int BombID { get => bombID; set => bombID = value; }
        public string BombName { get => bombName; set => bombName = value; }
        public int BombWeight { get => bombWeight; set => bombWeight = value; }
        public int Damage { get => damage; set => damage = value; }
        public int NrOfSlots { get => nrOfSlots; set => nrOfSlots = value; }

        public Bomb()
        {

        }

        public Bomb(int id, string name, int weight, int damage, int slots)
        {
            this.bombID = id;
            this.bombName = name;
            this.bombWeight = weight;
            this.damage = damage;
            this.nrOfSlots = slots;
        }
    }
}

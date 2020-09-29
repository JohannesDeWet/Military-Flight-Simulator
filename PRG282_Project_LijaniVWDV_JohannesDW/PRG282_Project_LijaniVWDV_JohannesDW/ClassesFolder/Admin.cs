using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project_LijaniVWDV_JohannesDW.ClassesFolder
{
    class Admin
    {
        private string adminID;
        private string adminName;
        private string adminPassword;

        public string AdminID { get => adminID; set => adminID = value; }
        public string AdminName { get => adminName; set => adminName = value; }
        public string AdminPassword { get => adminPassword; set => adminPassword = value; }

        public Admin() { }

        public Admin(string id, string username, string password)
        {
            this.adminID = id;
            this.adminName = username;
            this.adminPassword = password;
        }
    }
}

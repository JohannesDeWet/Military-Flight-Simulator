using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PRG282_Project_LijaniVWDV_JohannesDW.DataHandlers
{
    class DataBaseDataHandeler
    {
        /*
            to connect to the database making use of the sql server managment studio use the following:
            server name:    militarysim.database.windows.net
            authentication: sql server authentication
            login:          MatinLijani
            Password:       ThereIs@Horse@1234
         */
        private string connectionString = @"Server=tcp:militarysim.database.windows.net,1433;Initial Catalog=MilitarySimDataDase;Persist Security Info=False;User ID=MatinLijani;Password=ThereIs@Horse@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}

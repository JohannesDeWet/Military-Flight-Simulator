using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PRG282_Project_LijaniVWDV_JohannesDW.DataHandlers
{
    class DatabaseDataHandler
    {
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        private SqlDataReader myReader;

        public List<Plane> SelectAllPlanes() 
        {
            List<Plane> myPlaneCollection = new List<Plane>();
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception){throw;}
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand("SELECT * FROM Planes", myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Plane myPlane = new Plane((string)myReader["PlaneID"], (string)myReader["PlaneName"], (int)myReader["PlaneHP"], (string)myReader["PlaneType"], (int)myReader["MaxAltitude"], (int)myReader["PayLoad"], (int)myReader["CruiseSpeed"], (int)myReader["MaxSpeed"], (int)myReader["FuelRange"], (int)myReader["MountingPoints"]);
                    myPlaneCollection.Add(myPlane);
                }
            }
            catch (Exception){throw;}
            finally
            {
                myConnection.Close();
            }
            return myPlaneCollection;
        }
    }
}

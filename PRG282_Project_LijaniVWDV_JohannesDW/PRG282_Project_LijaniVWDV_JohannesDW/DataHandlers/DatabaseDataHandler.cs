using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using PRG282_Project_LijaniVWDV_JohannesDW.ClassesFolder;

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
        public List<Bomb> SelectAllBombs()
        {
            List<Bomb> myBombCollection = new List<Bomb>();
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand("SELECT * FROM Bombs", myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Bomb myBomb = new Bomb((string)myReader["BombID"], (string)myReader["BombName"], (int)myReader["BombWeight"], (int)myReader["Damage"], (int)myReader["SlotsNeeded"]);
                    myBombCollection.Add(myBomb);
                }
            }
            catch (Exception) { throw; }
            finally
            {
                myConnection.Close();
            }
            return myBombCollection;
        }
        public bool AdminCanLogin(string username, string password)
        {
            bool canLog = false;
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand("SELECT COUNT(Username) FROM AdminUsers WHERE Username = '" + username + "' AND Password = '" + password + "'", myConnection);
                int rowCount = Convert.ToInt32(myCommand.ExecuteScalar());
                if (rowCount >= 1)
                {
                    canLog = true;
                }
                else if (rowCount <= 0)
                {
                    canLog = false;
                }
            }
            catch (Exception) { throw; }
            finally
            {
                myConnection.Close();
            }
            return canLog;
        }
        public void EditPlanes(string planeId, int hp, int altitude, int payload, int maxspeed, int range, int mountPoints)
        {
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand($"UPDATE Planes SET PlaneHP = '{hp}', MaxAltitude = '{altitude}', PayLoad = '{payload}', MaxSpeed = '{maxspeed}', FuelRange = '{range}', MountingPoints = '{mountPoints}' WHERE PlaneID = '{planeId}'", myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                myConnection.Close();
            }
        }
        public List<Admin> SelectAllAdmins()
        {
            List<Admin> myAdminCollection = new List<Admin>();
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand("SELECT * FROM AdminUsers", myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    myAdminCollection.Add(new Admin((string)myReader["Username"], (string)myReader["Password"]));
                }
            }
            catch (Exception) { throw; }
            finally
            {
                myConnection.Close();
            }
            return myAdminCollection;
        }
        public void AddAdmin(string username, string password)
        {
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {

                myCommand = new SqlCommand(@"INSERT INTO AdminUsers(Username,Password) VALUES (@Username,@Password)", myConnection);
                myCommand.Parameters.AddWithValue("@Username", username);
                myCommand.Parameters.AddWithValue("@Password", password);

                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            finally
            {
                myConnection.Close();
            }
        }
        public void DeleteAdmin(string name)
        {
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {
                myCommand = new SqlCommand($"DELETE FROM AdminUsers WHERE Username = '{name}'", myConnection);

                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            finally
            {
                myConnection.Close();
            }
        }
        public void EditAdmin(string initialName,string newName, string password)
        {
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand($"UPDATE AdminUsers SET Username = '{newName}', Password = '{password}' WHERE Username = '{initialName}'", myConnection);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception) { throw; }
            finally
            {
                myConnection.Close();
            }
        }

        public List<Buildings> GetBuildings()
        {
            List<Buildings> myBuildingCollection = new List<Buildings>();
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand("SELECT * FROM Buildings", myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Buildings myBuilding = new Buildings((string)myReader["BuildingID"], (string)myReader["BuildingName"], (string)myReader["BuildingType"], (int)myReader["BuildingHealth"]);
                    myBuildingCollection.Add(myBuilding);
                }
            }
            catch (Exception) { throw; }
            finally
            {
                myConnection.Close();
            }
            return myBuildingCollection;
        }
        public List<Buildings> SelectAllBuildings()
        {
            List<Buildings> myBuildingCollection = new List<Buildings>();
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand("SELECT * FROM Buildings", myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Buildings myPlane = new Buildings((string)myReader["BuildingID"], (string)myReader["BuildingName"], (string)myReader["BuildingType"], (int)myReader["BuildingHealth"]);
                    myBuildingCollection.Add(myPlane);
                }
            }
            catch (Exception) { throw; }
            finally
            {
                myConnection.Close();
            }
            return myBuildingCollection;
        }

        public Plane GetSpecificPlane(string planeName)
        {
            Plane myPlane = null;
            try
            {
                myConnection = new SqlConnection(@"Data Source =.; Initial Catalog = MilitarySimDataDase; Integrated Security = SSPI");
            }
            catch (Exception) { throw; }
            try
            {
                string query = @"SELECT * FROM Planes WHERE PlaneName = " + planeName;
                myConnection.Open();
                myCommand = new SqlCommand(query, myConnection);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    myPlane = new Plane((string)myReader["PlaneID"], (string)myReader["PlaneName"], (int)myReader["PlaneHP"], (string)myReader["PlaneType"], (int)myReader["MaxAltitude"], (int)myReader["PayLoad"], (int)myReader["CruiseSpeed"], (int)myReader["MaxSpeed"], (int)myReader["FuelRange"], (int)myReader["MountingPoints"]);
                }

            }
            catch (Exception) 
            {
                MessageBox.Show("There was an error connection to the database");
            }
            finally
            {
                myConnection.Close();
            }
            return myPlane;
        }
    }

}

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
            try
            {
                myConnection = new SqlConnection(); 
                
            }
            catch (Exception)
            {

                throw;
            }
            myQuery = @"SELECT * FROM INTO Students (StudentID, FirstName, LastName,CourseID) VALUES ('" + sID + "', '" + sName + "','" + sSurname + "','" + cID + "')";
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand(myQuery, myConnection);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("insert succes");

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}

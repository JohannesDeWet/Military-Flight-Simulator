using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PRG282_Project_LijaniVWDV_JohannesDW.DataHandlers
{
    class TextFileDataHandler
    {
        private string filepath = @"Resources\TextFiles\MissionReport.txt";

        /*
            the format of the file should be as follows
            (targetes identified)^(targeted locaiton)^(target damage delt)^(max possible damage to targets)^(obsticalse identified)^(obsticalse location)
            ^(mission time)^(Plane used)^(Distance traveled)^(feul used)^(inventory used)
         */

        public List<string> ReadExternalReportFile()
        {
            List<string> reportdetails = new List<string>();
            string fileLine;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader srReader = new StreamReader(filepath);
                //Read line of text
                fileLine = srReader.ReadLine();
                //Continue to read until end of file
                while (fileLine != null)
                {
                    //write the line to list
                    reportdetails.Add(fileLine);
                    //Read the next line
                    fileLine = srReader.ReadLine();
                }
                //close the file
                srReader.Close();
            }
            catch (Exception) { MessageBox.Show("Error: Reading reportdata failed, please contact developer"); }

            return reportdetails;
        }
        public void WriteExternalReportFile(string[] targetesIdentified, string[] targetedLocaitons, int[] targetDamageDelt, int maxPossibleDamage, string[] obsticalseIdentified, string[] obsticaleLocation, string missionTime, string planeUsed, float DistanceTraveled,int MaxFeul,  float feulUsed, string[] inventoryStart,string[] inventoryUsed)
        {
            string identifiedTargets = "";
            string locationOfTarget = "";
            string damageToTarget = "";
            for (int i = 0; i < targetesIdentified.Length; i++)
            {
                identifiedTargets += targetesIdentified[i] + "*";
                locationOfTarget += targetedLocaitons[i] + "*";
                damageToTarget += targetDamageDelt[i] + "*";
            }
            string identifiedOdsticles = "";
            string locationOfOdsticles = "";
            for (int i = 0; i < obsticalseIdentified.Length; i++)
            {
                identifiedOdsticles += obsticalseIdentified[i] + "*";
                locationOfOdsticles += obsticaleLocation[i] + "*";
            }
            string Startinventory = "";
            for (int i = 0; i < inventoryStart.Length; i++)
            {
                Startinventory += inventoryStart[i] + "*";
            }
            string Usedinventory = "";
            for (int i = 0; i < inventoryUsed.Length; i++)
            {
                Usedinventory += inventoryUsed[i] + "*";
            }


            try
            {
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine(identifiedTargets + "^" + locationOfTarget + "^" + damageToTarget + "^" + maxPossibleDamage + "^" + identifiedOdsticles + "^" + locationOfOdsticles + "^" + missionTime + "^" + planeUsed + "^" + DistanceTraveled + "^" + MaxFeul + "^" + feulUsed + "^" + Startinventory + "^" + Usedinventory);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured writing to the file");
                throw;
            }

        }
    }
}

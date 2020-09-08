using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PRG282_Project_LijaniVWDV_JohannesDW.DataHandlers
{
    class TextFileDataHandeler
    {
        private string filepath = @"Resources\TextFiles\MissionReport.txt";
        /*
            the format of the file should be as follows
            (targetes identified)^(targeted attacked)^(targeted locaiton)^(target damage delt)^(mission success persentage)^(mission time)^(Plane used)^()
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
    }
}

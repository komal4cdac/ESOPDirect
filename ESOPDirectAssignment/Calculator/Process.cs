using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace ESOPDirectAssignment.Calculator
{
    public class Process
    {
        public void SaveToServer(int number,float result)
        {
            
            string RootPath = AppDomain.CurrentDomain.BaseDirectory;
            
            string fileName = RootPath + "ResultFiles\\Result.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            // Create a new file     
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                sw.WriteLine("Factorial of  " + number + " is " + result);
               
            }
           

            
        }
    }
}
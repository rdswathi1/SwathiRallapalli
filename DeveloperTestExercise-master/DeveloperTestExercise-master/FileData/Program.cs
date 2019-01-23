using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string fileName = args[1];
            //FileDetails object intilization
            FileDetails objFileDetails = new FileDetails();
            
            #region conditionCheck to chcek version or sive 
            //Condition chcek if the first argument is for version
            if (args[0].ToLower().Trim() == "–v" || args[0].ToLower().Trim() == "--v" || args[0].ToLower().Trim() == "/v" || args[0].ToLower().Trim() == "--version")
            {
                string fileVersion = objFileDetails.Version(fileName);
                Console.WriteLine("Given file Version:" + fileVersion);
                Console.ReadLine();
            }
            //Condition chcek if the first argument is for Size
            else if (args[0].ToLower().Trim() == "–s" || args[0].ToLower().Trim() == "--s" || args[0].ToLower().Trim() == "/s" || args[0].ToLower().Trim() == "--size")
            {
                int fileSize = objFileDetails.Size("Given file size:" + fileName);
                Console.WriteLine(fileSize);
                Console.ReadLine();
            }
            //If the given Augrments in not related to Version or Size then this block witll execute
            else
            {
                Console.WriteLine("Given Argument does not match");
                Console.ReadLine();
            } 
            #endregion
        }
    }
}

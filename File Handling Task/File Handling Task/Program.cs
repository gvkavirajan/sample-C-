using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace File_Handling_Task
{
    class Program
    {
        static void rd()
        {
            string rd = string.Empty;
            foreach (string key in ConfigurationManager.Appsettings)
            {
                if(key=="Root_Directory")
                {
                    rd = ConfigurationManager.AppSettings[key];
                    Directory.CreateDirectory(rd);
                }
                else
                {
                    string value = ConfigurationManager.Appsettings[key];
                    string[] foldernames=value(',').ToArray();
                    foreach(string FolderName in foldernames)
                    {
                        Directory.CreateDirectory(Path.Combine(rd,FolderName));
                        Console.WriteLine("key:{0},value:{1}",key,value);
                    }
                }
            }
        }
        static void Main(string[] args) 
        {
            rd();
        }
    }
}

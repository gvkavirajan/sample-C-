using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace FileCreation
{               
    class Program
    {
        //static void ShowConfig()
        //{
        //    //Directory  Create

        //    string rootDirectory = string.Empty;
        //    foreach (string key in ConfigurationManager.AppSettings)
        //    {

        //        if (key == "Root_Directory")
        //        {
        //            rootDirectory = ConfigurationManager.AppSettings[key];
        //            Directory.CreateDirectory(rootDirectory);
        //        }
        //        else
        //        {
        //            string value = ConfigurationManager.AppSettings[key];
        //            string[] folderNames = value.Split(',').ToArray();
        //            foreach (string folderName in folderNames)
        //            {
        //                Directory.CreateDirectory(Path.Combine(rootDirectory, folderName));
        //                Console.WriteLine("Key: {0}, Value: {1}", key, value);
        //            }
        //        }

        //    }

        //    string path = @"E:\\FolderCreated\";    // understand and explain - Where we need to use @ symbol and why?
        //    if (Directory.Exists(path))
        //    {
        //        foreach (string file in Directory.GetFiles(path))
        //        {
        //            File.Delete(file);
        //            ShowConfig();
        //        }
        //    }
        //    else
        //    {
        //        ShowConfig();
        //    }
        //}
        //static void deletefolder()
        //{
        //    ShowConfig();
        //}


        //Create File

        //static void CreatingCsvFiles()
        //{
        //    string filePath = "E:\\" + "filename.csv";
        //    if (!File.Exists(filePath))
        //    {
        //        File.Create(filePath).Close();
        //    }
        //    string  = ",";

        //    List<string[]> output = new List<string[]>();
        //    output.Add(new string[] { "EmpID", "Name", "MobileNumber", "Email" });
        //    output.Add(new string[] { "1", "Muthu", "9547894561", "muthu@gmail.com" });
        //    output.Add(new string[] { "2", "Mani", "9214789510", "mani@gmail.com" });
        //    output.Add(new string[] { "3", "kumar", "9787963424", "kumar@gmail.com" });

        //    int length = output.Count; 
        //    StringBuilder sb = new StringBuilder();
        //    for (int index = 0; index < length; index++)
        //        sb.AppendLine(string.Join(xyz, output[index]));
        //    File.AppendAllText(filePath, sb.ToString());
        //}
         
         
    
        static void Main(string[] args)
        {
            //ShowConfig();
            //CreatingCsvFiles();
            //deletefolder();
            FileProcessor processor = new FileProcessor();
            processor.CreateFolder();
            processor.CreateFile();
        }
    }
}


 
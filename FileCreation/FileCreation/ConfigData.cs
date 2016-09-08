using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreation
{
    internal class ConfigData
    {
        public static string FolderPath
        {
            get { return ConfigurationManager.AppSettings["Root_Directory"]; }
        }

        public static string FoldersNames
        {
            get { return ConfigurationManager.AppSettings["Folders_Name"]; }
        }

        public static string FilePath
        {
            get { return ConfigurationManager.AppSettings["File_Path"]; }
        }

        public static string FileName
        {
            get { return ConfigurationManager.AppSettings["Files_Name"]; }
        }

        public static string Delimiter
        {
            get { return ConfigurationManager.AppSettings["Delimiter"]; }
        }

       
    }
}

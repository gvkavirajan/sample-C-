using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileCreation
{
    class FileProcessor
    {
        internal void CreateFolder()
        {
            string[] folders = ConfigData.FoldersNames.Split(';');

            if (!Directory.Exists(ConfigData.FolderPath))
                {
                    Directory.CreateDirectory(ConfigData.FolderPath);
                }
           
            IEnumerable<string> directories = Directory.EnumerateDirectories(ConfigData.FolderPath);
            foreach (string oldDirectories in directories)
                {
                    Directory.Delete(oldDirectories, true);
                }
            
            foreach (string folder in folders)
                {
                    if (!Directory.Exists(Path.Combine(ConfigData.FolderPath, folder)))
                        {
                            Directory.CreateDirectory(Path.Combine(ConfigData.FolderPath, folder));
                        }
                }
        }

        internal void CreateFile()
            {
                string file = Path.Combine(ConfigData.FilePath, ConfigData.FileName);
                if (!File.Exists(file))
                    {
                        File.Delete(file);
                    }
            File.Create(file).Close();
            List<string[]> output = new List<string[]>();
            output.Add(new string[] { "EmpID", "Name", "MobileNumber", "Email" });
            output.Add(new string[] { "1", "Muthu", "9547894561", "muthu@gmail.com" });
            output.Add(new string[] { "2", "Mani", "9214789510", "mani@gmail.com" });
            output.Add(new string[] { "3", "kumar", "9787963424", "kumar@gmail.com" });


            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < output.Count; index++)
                {
                    sb.AppendLine(string.Join(ConfigData.Delimiter, output[index]));
                }
            File.AppendAllText(file, sb.ToString());
        }
    }
}

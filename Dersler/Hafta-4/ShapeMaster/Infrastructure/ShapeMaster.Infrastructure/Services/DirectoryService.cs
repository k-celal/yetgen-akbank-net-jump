using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Infrastructure.Services
{
    internal static class DirectoryService
    {
        public static string ProjectFolder => Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;
        public static string DatabasePath => Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName+"\\Database";

        public static bool isFileExist(string path)
        {
            if (File.Exists(path)) return true;
            return false;
        }
        public static void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
        public static string ReadFile(string path) {
        
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            throw new Exception("File doesn't exist");

        }
    }
}

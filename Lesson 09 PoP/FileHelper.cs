using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Lesson_09_PoP
{
    public static class FileHelper
    {
        public static void CreateOrUpdateFile(string fileName, string content)
        {
            using (StreamWriter writer = File.AppendText(fileName))
            {
                writer.WriteLine(content);
            }
        }

        public static bool FileExists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        public static void DeleteFile(string fileName)
        {
            if (FileExists(fileName))
            {
                File.Delete(fileName);
            }
            else
            {
                Debug.Write(fileName + "does not exists.s");
            }
        }
    }
}

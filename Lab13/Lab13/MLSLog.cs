using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class MLSLog
    {
        public static void Log(Type t,string info,StreamWriter sw)
        {
            sw.WriteLine(DateTime.Now + " - " + t.FullName + " - " + info);
        }

        public static void Read(string path)
        {
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            
        }

        public static void Search(string path,string info)
        {
            
            foreach(string line in File.ReadLines(path))
            {
                if (line.Contains(info))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

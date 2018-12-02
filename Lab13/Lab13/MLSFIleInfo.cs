using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class MLSFIleInfo
    {
        public static void GetFileInfo(string path)
        {
            Console.WriteLine("Путь : " + Path.GetFileName(path));
            Console.WriteLine("Расширение : " + Path.GetExtension(path));
            Console.WriteLine("Полный путь : " + Path.GetFullPath(path));
            Console.WriteLine("Время создания : " + File.GetCreationTime(path));
            Console.WriteLine();
        }
    }
}

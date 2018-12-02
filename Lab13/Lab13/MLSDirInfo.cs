using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class MLSDirInfo
    {
        public static void GetDirInfo(string path)
        {
            Console.WriteLine("Количество файлов в папке : " + new DirectoryInfo(path).GetFiles().Length);
            Console.WriteLine("Время создания : " + new DirectoryInfo(path).CreationTime);
            Console.WriteLine("Количество подпапок : " + new DirectoryInfo(path).GetDirectories().Length);
            Console.WriteLine("Родительская папка : " + new DirectoryInfo(path).Parent);
            Console.WriteLine();
        }
    }
}

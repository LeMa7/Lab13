using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("mlslogfile.txt", true);
            sw.Close();
            MLSLog.Read("mlslogfile.txt");
            MLSLog.Search("mlslogfile.txt", "log1");
            MLSDiskInfo.GetDriveInfo("C:\\");
            MLSFIleInfo.GetFileInfo(@"D:\Labs\1.txt");
            MLSDirInfo.GetDirInfo(@"D:\Labs\OOP");
            MSLFileManager.Manager1("D:\\");
            MSLFileManager.Manager2();
            MLSLog.Search("mlslogfile.txt", "14.12.2018");
            MLSLog.NumberOfLines();
        }
    }
}

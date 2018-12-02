using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab13
{
    class MSLFileManager
    {
        public static void Manager1(string path)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\MLSInspect");
            di.Create();
            StreamWriter sw = new StreamWriter(@"D:\MLSInspect\mlsdirinfo.txt");
            sw.WriteLine("Количество файлов : " + new DirectoryInfo(path).GetFiles().Length);
            sw.WriteLine("Количество папок : " + new DirectoryInfo(path).GetDirectories().Length);
            sw.Close();
            FileInfo fi = new FileInfo(@"D:\MLSInspect\mlsdirinfo.txt");
            fi.CopyTo(@"D:\Labs\mlsdirinfo2.txt");
            fi.Delete();
        }

        public static void Manager2()
        {
            int i = 0;
            DirectoryInfo di = new DirectoryInfo(@"D:\MLSFiles");
            di.Create();
            DirectoryInfo di2 = new DirectoryInfo(@"D:\\");
            foreach(FileInfo fi in di2.GetFiles())
            {
                if (fi.Extension == ".txt")
                {
                    i++;
                    fi.CopyTo($@"D:\MLSFiles\{i}.txt");
                }
            }
            di.MoveTo(@"D:\MLSInspect\MLSFiles");
            ZipFile.CreateFromDirectory(@"D:\MLSInspect\MLSFiles", @"D:\\Lab13.zip");
            ZipFile.ExtractToDirectory(@"D:\\Lab13.zip", @"D:\DirectoryForZip");

        }
    }
}

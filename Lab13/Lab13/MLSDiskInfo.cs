using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class MLSDiskInfo
    {
        public static void GetDriveInfo(string diskName)
        {
            Console.WriteLine("Информация о диске :");
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                if(drive.Name == diskName)
                { 
                    Console.WriteLine("Общий размер диска : " + drive.TotalSize);
                    Console.WriteLine("Свободно места на диске : " + drive.TotalFreeSpace);
                    Console.WriteLine("Метка тома : " + drive.VolumeLabel);
                    Console.WriteLine("Имя файловой системы : " + drive.DriveFormat);
                    Console.WriteLine();
                }
            }

        }
    }
}

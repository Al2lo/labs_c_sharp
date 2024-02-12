using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Work_Lab
{
    public class LADDiskInfocs
    {
        public static void GetFreeSpace()
        {
            foreach (var item in (DriveInfo.GetDrives()))
            {
                Console.WriteLine("информации о  свободном месте на диске: " + item.Name + item.AvailableFreeSpace);
                LADLog.WriteLog("информации о  свободном месте на диске: " + item.Name + item.AvailableFreeSpace + "\n");
                
            }
        }

        public static void GetFileSystem()
        {
            foreach (var item in (DriveInfo.GetDrives()))
            {
                Console.WriteLine("информации о Файловой системе: " + item.DriveFormat);
                LADLog.WriteLog("информации о Файловой системе: " + item.DriveFormat + "\n");

            }
        }

        public static void GetDiskInfo()
        {
            foreach (var item in (DriveInfo.GetDrives()))
            {
                Console.WriteLine("информации о disk:");
                Console.WriteLine("имя: " + item.Name);
                Console.WriteLine("объем: " + item.TotalSize);
                Console.WriteLine("доступный объем: " + item.AvailableFreeSpace);
                Console.WriteLine("метка тома: " + item.VolumeLabel);


                LADLog.WriteLog("информации о disk: " + item.DriveFormat + "\n");
                LADLog.WriteLog("имя: " + item.Name + "\n");
                LADLog.WriteLog("объем: " + item.TotalSize + "\n");
                LADLog.WriteLog("доступный объем: " + item.AvailableFreeSpace + "\n");
                LADLog.WriteLog("метка тома: " + item.VolumeLabel + "\n");

            }
        }
    }
}

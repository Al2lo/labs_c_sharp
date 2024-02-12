using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Work_Lab
{
    internal static class LADDirInfo
    {
        public static void GetCountOFFiles(string nameOfDirectory)
        {
            DirectoryInfo info = new DirectoryInfo(nameOfDirectory);

            Console.WriteLine("Количестве файлов: " + info.GetFiles().Length);

            LADLog.WriteLog("Количестве файлов: " + info.GetFiles().Length);

        }

        public static void  GetTimeOfCreate(string nameOfDirectory)
        {
            DirectoryInfo info = new DirectoryInfo(nameOfDirectory);

            Console.WriteLine("Время создания: " + info.CreationTime);

            LADLog.WriteLog("Время создания: " + info.CreationTime);

        }

        public static void GetCountOfUnderDirectoru(string nameOfDirectory)
        {
            DirectoryInfo info = new DirectoryInfo(nameOfDirectory);

            Console.WriteLine("Количестве файлов: " + info.GetDirectories().Length);

            LADLog.WriteLog("Количестве файлов: " + info.GetDirectories().Length);
        }

        public static void GetBaseDirectories(string nameOfDirectories)
        {
            DirectoryInfo info = new DirectoryInfo(nameOfDirectories);
            DirectoryInfo end = new DirectoryInfo(@"D:\");
            Console.WriteLine("Parants catalog: ");
            LADLog.WriteLog("Parants catalog: ");
            while (info.Parent != null)
            {
                Console.WriteLine(info.Parent);
                LADLog.WriteLog(info.Parent);
                info = info.Parent;
            }
        }
    }
}

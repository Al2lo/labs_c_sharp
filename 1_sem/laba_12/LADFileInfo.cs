using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Lab
{
    public static class LADFileInfo
    {
        public static void GetFullTravel(string name)
        {
            FileInfo fileInfo = new FileInfo(name);

            Console.WriteLine("Полный путь: " + fileInfo.DirectoryName);
            LADLog.WriteLog("Полный путь: " + fileInfo.DirectoryName + "\n");

        }

        public static void GetInfofile(string name)
        {
            FileInfo fileInfo = new FileInfo(name);

            Console.WriteLine("имя: " + fileInfo.Name);
            Console.WriteLine("Размер: " + fileInfo.Length);
            Console.WriteLine("расширение: " + fileInfo.Extension);

            LADLog.WriteLog("имя: " + fileInfo.Name + "\n");
            LADLog.WriteLog("Размер: " + fileInfo.Length + "\n");
            LADLog.WriteLog("расширение: " + fileInfo.Extension + "\n");

        }

        public static void GetInfoTimeOfWork(string name)
        {
            FileInfo info = new FileInfo(name);

            Console.WriteLine("Time of Create" + info.CreationTime + "\n");
            Console.WriteLine("Last Writer" + info.LastWriteTime + "\n");
         
        }
    }
}

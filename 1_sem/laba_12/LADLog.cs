using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Work_Lab
{
    public static class LADLog
    {
        static FileInfo logFile = new FileInfo(@"D:\ООП\laba_12\bin\Debug\net6.0\LADLog.txt");

        public static void DeleteLog()
        {
            logFile.Delete();
        }
        public static void WriteLog(object info)
        {
            File.AppendAllText("LADlog.txt", Convert.ToString(info));
            File.AppendAllText("LADlog.txt", "\n ДАТА ИЗМЕНЕНИЙ : " + DateTime.Now.ToString() + "\n");
        }

    }
}

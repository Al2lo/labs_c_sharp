using System;
using System.Diagnostics;

namespace Work_Lab
{

    class Program
    {



        public static void Main(string[] argv)
        {
            try
            {
                LADDiskInfocs.GetFreeSpace();
                LADDiskInfocs.GetFileSystem();
                LADDiskInfocs.GetDiskInfo();
                LADFileInfo.GetFullTravel("LADLog.txt");
                LADFileInfo.GetInfofile("LADLog.txt");

                LADDirInfo.GetCountOFFiles(@"D:\ООП\laba_12\bin\Debug\net6.0");
                LADDirInfo.GetTimeOfCreate(@"D:\ООП\laba_12\bin\Debug\net6.0");
                LADDirInfo.GetBaseDirectories(@"D:\ООП\laba_12\bin\Debug\net6.0");

                LADFileManager.WorkA(@"D:\ООП\laba_12\bin\Debug\net6.0");
                LADFileManager.WorkB(@"D:\ООП\laba_12\bin\Debug\net6.0");

                LADFileManager.CreateZipFIle(@"D:\ООП\laba_12\bin\Debug\net6.0\zip");

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
           

        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Work_Lab
{
    internal static class LADFileManager
    {
        public static void WorkA(string directors)
        {
            DriveInfo driveInfo = new DriveInfo(@"D:\ООП\laba_12\bin\Debug\net6.0");
            string[] allDirectories = Directory.GetDirectories(@"D:\ООП\laba_12\bin\Debug\net6.0");
            string[] allFiles = Directory.GetFiles(@"D:\ООП\laba_12\bin\Debug\net6.0");


            string path = directors+'\\'+ "LADInspect";
            DirectoryInfo directory = new DirectoryInfo(path);
            directory.Create();
            using (StreamWriter writerFile = new StreamWriter(path+"\\laddirinfo.txt",true))
            {
                writerFile.WriteLine("Все файлы:");
                foreach (var item in allFiles)
                {
                    writerFile.WriteLine(item);
                }
                writerFile.WriteLine("Все директории :");
                foreach (var item in allDirectories)
                {
                    writerFile.WriteLine(item);
                }

                File.Copy(path+"\\laddirinfo.txt", @"D:\ООП\laba_12\bin\Debug\net6.0\\LADInspect\\newFile.txt",true); 
            }
            File.Delete(path + "\\laddirinfo.txt");

        }

        public static void WorkB(string newDirectors)
        {

            Directory.CreateDirectory(newDirectors + "LADFiles");
            DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\ООП\laba_11\bin\Debug\net6.0");
            FileInfo[] files = directoryInfo.GetFiles("*.txt");

            foreach (var file in files)
            {
                file.CopyTo(newDirectors + "LADFiles\\" + file.Name, true);
            }
            DirectoryInfo secDirectoryInfo = new DirectoryInfo(newDirectors + "LADFiles\\");
            FileInfo[] allFiles = secDirectoryInfo.GetFiles();
            foreach (var file in allFiles)
            {
                File.Copy(newDirectors + "LADFiles\\" + file.Name, newDirectors + "\\LADInspect\\1" + file.Name, true);
            }

        }


        public static void CreateZipFIle(string path)
        {
            if (File.Exists("D:\\ООП\\laba_12\\bin\\Debug\\net6.0\\zipFile.zip"))
            {
                File.Delete("D:\\ООП\\laba_12\\bin\\Debug\\net6.0\\zipFile.zip");
            }
            ZipFile.CreateFromDirectory(path, "zipFile.zip");

            ZipFile.ExtractToDirectory("zipFile.zip", "D:\\ООП\\laba_12\\bin\\Debug\\net6.0\\LADInspect",true);

        }


       
    }
}

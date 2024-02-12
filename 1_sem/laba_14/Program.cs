using System;
using System.Diagnostics;
using System.Threading;
using System.Reflection;


namespace Work_Lab
{
    public class Program
    {
        public static void GetProcesses()
        {
            Process[] vsProcs = Process.GetProcesses();
            foreach (var item in vsProcs)
            {
                Console.WriteLine(item.ProcessName + "\t-----\t" + item.Id);
            }
        }

        public static void GetDomainInfo()
        {
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine(domain.FriendlyName + "\t-----\t" + domain.Id + "\t-----\t" + domain.BaseDirectory);
            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly asm in assemblies)
            {
                Console.WriteLine(asm.GetName().Name);
            }
            //AppDomain newDomain = AppDomain.CreateDomain("New");

            //newDomain.Load("D:\\ООП\\laaba_2\\laaba_2\\obj\\Debug\\net6.0\\laaba_2.dll");
            //AppDomain.Unload(newDomain);

        }


        public static void Main(string[] argv)
        {
            Mutex mutex = new Mutex();
            Program.GetProcesses();
            Program.GetDomainInfo();
            Console.WriteLine("Enter count of numb");
            int n = Convert.ToInt32(Console.ReadLine());
            Thread thread = new Thread(new ThreadStart(()=>
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(i);
                }
            }));
            thread.Start();
            Thread.Sleep(5000);
            Console.WriteLine("Enter count of numb");
            int count = Convert.ToInt32(Console.ReadLine());
            Thread thread1 = new Thread(() =>
            {
                string str = "";
                for (int i = 0; i < count; i += 2)
                {
                    Thread.Sleep(50);
                    Console.WriteLine(i);
                    Thread.Sleep(70);
                    str += i;
                }
                mutex.WaitOne();
                File.WriteAllText("file.txt", str);
                mutex.ReleaseMutex();
            });
            Thread thread2 = new Thread(() =>
            {

                string str = "";
                for (int i = 1; i < count; i += 2)
                {
                    Thread.Sleep(700);
                    Console.WriteLine(i);
                    Thread.Sleep(30);
                    str += i;
                }
                mutex.WaitOne();
                File.WriteAllText("file.txt", str);
                mutex.ReleaseMutex();
            });

            //Thread thread1 = new Thread(() =>
            //{
            //    string str = "";
            //    for (int i = 0; i < count; i += 2)
            //    {
            //        Thread.Sleep(50);
            //        Console.WriteLine(i);
            //        Thread.Sleep(1100);
            //        str += i;
            //    }
            //    mutex.WaitOne();
            //    File.WriteAllText("file.txt", str);
            //    mutex.ReleaseMutex();
            //});
            //Thread thread2 = new Thread(() =>
            //{
            //    string str = "";
            //    for (int i = 1; i < count; i += 2)
            //    {
            //        Thread.Sleep(70);
            //        Console.WriteLine(i);
            //        Thread.Sleep(1110);
            //        str += i;
            //    }
            //    mutex.WaitOne();
            //    File.WriteAllText("file.txt", str);
            //    mutex.ReleaseMutex();
            //});

            thread1.Start();
            thread2.Start();
            string arr = "food";
            Thread.Sleep(3000);
            TimerCallback callback = new TimerCallback((object path) =>
            {
                Console.WriteLine(path.ToString());
            });

            Timer time = new Timer(callback, arr, 2500, 100);
            //Timer time = new Timer(callback, arr, 700, 100);

        }
    }
}
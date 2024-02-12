using System;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace Work_Lab
{
    public class Program
    {
        async public static void Vyvod()
        {
            Console.WriteLine("dlfl");
            for (int i = 0; i < 10; i++)
            {
                await Task.Run(() => PrinttValue(i));
                await Task.Delay(250);
            }
            
        }
        public static void PrinttValue(int s)
        {
            Console.WriteLine(s);
        }
       async public static void Zadanie7()
        {
            BlockingCollection<int> coll = new BlockingCollection<int>();

            Task prodovec1 = new(() =>
            {
                Thread.Sleep(20);
                Console.WriteLine("set: 1");
                coll.Add(1);
            });
            Task prodovec2 = new(() =>
            {
                Thread.Sleep(120);
                Console.WriteLine("set: 2");
                coll.Add(2);
            });
            Task prodovec3 = new(() =>
            {
                Thread.Sleep(10);
                Console.WriteLine("set: 3");
                coll.Add(3);
            });

            Task buyer1 = new(() =>
            {
                Thread.Sleep(20);
                if (coll.Count == 0)
                {
                    Console.WriteLine("no elements!");
                }
                Thread.Sleep(80);
                int n = coll.Take();
                Console.WriteLine("get: "+n);
            });
            Task buyer2 = new(() =>
            {
                Thread.Sleep(620);
                if (coll.Count == 0)
                {
                    Console.WriteLine("no elements!");
                }
                int n = coll.Take();
                Console.WriteLine("get: " + n);
            });
            Task buyer3 = new(() =>
            {
                Thread.Sleep(3);
                if (coll.Count == 0)
                {
                    Console.WriteLine("no elements!");
                }
                int n = coll.Take();
                Console.WriteLine("get: " + n);
            });
            Task buyer4 = new(() =>
            {
                if (coll.Count == 0)
                {
                    Console.WriteLine("no elements!");
                }
                int n = coll.Take();
                Console.WriteLine("get: " + n);
            });
            Task buyer5 = new(() =>
            {
                Thread.Sleep(130);
                if (coll.Count == 0)
                {
                    Console.WriteLine("no elements!");
                }
                int n = coll.Take();
                Console.WriteLine("get: " + n);
            });
            Task buyer6 = new(() =>
            {
                Thread.Sleep(49);
                if (coll.Count == 0)
                {
                    Console.WriteLine("no elements!");
                }
                int n = coll.Take();
                Console.WriteLine("get: " + n);
            });
            prodovec1.Start();
            prodovec2.Start();
            prodovec3.Start();
            buyer1.Start();
            buyer2.Start();
            buyer3.Start();
            buyer4.Start();
            buyer5.Start();
            buyer6.Start();



            Task.WaitAll(buyer1,buyer2, buyer3, buyer4, buyer5, buyer6,prodovec1,prodovec2,prodovec3);

        }



        public async static void PrintValue(int sum)
        {
            Console.WriteLine(sum);
        }


        public static void Main(string[] argv)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Program program = new Program();
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Action action = new(() =>
            {

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("THIS OPERATION WAC CANSLED!");
                    stopwatch.Stop();
                    Console.WriteLine(stopwatch.ElapsedTicks);
                    return;
                }
                if (n == 1) // 1 - не простое число
                {
                    Console.WriteLine(n + " - непростое\n");
                    stopwatch.Stop();
                    Console.WriteLine(stopwatch.ElapsedTicks);
                    return;
                }
                // перебираем возможные делители от 2 до sqrt(n)
                for (int d = 2; d * d <= n; d++)
                {
                    // если разделилось нацело, то составное
                    if (n % d == 0)
                    {
                        Console.WriteLine(n + " -чисо составное\n");
                        stopwatch.Stop();
                        Console.WriteLine(stopwatch.ElapsedTicks);
                        return;
                    }
                }
                Console.WriteLine(n + " -число простое\n");
                stopwatch.Stop();
                Console.WriteLine(stopwatch.ElapsedTicks);
                // если нет нетривиальных делителей, то простое
            });

            //------------1--------------


            //Task taskPoiskEasyNumbers1 = new Task(action);
            //Task taskPoiskEasyNumbers2 = new Task(action);
            //Task taskPoiskEasyNumbers3 = new Task(action);
            //taskPoiskEasyNumbers1.Start();
            //Console.WriteLine("ид таски: " + taskPoiskEasyNumbers1.Id + " статус: " + taskPoiskEasyNumbers1.Status);
            //if (taskPoiskEasyNumbers1.IsCompleted)
            //{
            //    Console.WriteLine("Задача завершена");
            //}
            //else
            //{
            //    Console.WriteLine("Task not complete");
            //}

            //taskPoiskEasyNumbers2.Start();

            //taskPoiskEasyNumbers3.Start();

            //////////////////2////////////////
            ///

            //Task taskPoiskEasyNumbers1 = new Task(action, token);
            //Task taskPoiskEasyNumbers2 = new Task(action);
            //Task taskPoiskEasyNumbers3 = new Task(action);
            //taskPoiskEasyNumbers1.Start();
            //cancellationTokenSource.Cancel();
            //Console.WriteLine("ид таски: " + taskPoiskEasyNumbers1.Id + " статус: " + taskPoiskEasyNumbers1.Status);
            //if (taskPoiskEasyNumbers1.IsCompleted)
            //{
            //    Console.WriteLine("Задача завершена");
            //}
            //else
            //{
            //    Console.WriteLine("Task not complete");
            //}
            //taskPoiskEasyNumbers2.Start();
            //taskPoiskEasyNumbers3.Start();


            ////////////////////////3///////////////////
            int a = 1;
            int b = 8;
            int c = 0;
            Task<int> task1 = new Task<int>(() =>
            {
                return a + b;
            });

            Task<int> task2 = new(() =>
            {
                return a + c;
            });

            Task<int> task3 = new(() =>
            {
                return b + c;
            });

            ////////4.1/////////////
            //Task taskPrint = task1.ContinueWith(task => PrintValue(task1.Result));
            //task1.Start();
            //task2.Start();
            //task3.Start();
            //taskPrint.Wait();

            /////////////4.2///////////
            //Task taskPrint = new(() => Console.WriteLine(task1.GetAwaiter().GetResult() + task2.GetAwaiter().GetResult() + task3.GetAwaiter().GetResult()));
            //taskPrint.Start();
            //Thread.Sleep(1000);
            ////////////////5//////////////
            Stopwatch sw = new Stopwatch();
            //for (int i = 0; i < 1000; i++)
            //{
            //    PrintValue(i);
            //}
            //sw.Stop();
            //Console.WriteLine("\n\nmil: " + sw.ElapsedMilliseconds);


            sw.Start();
            //Parallel.For(0, 1000, PrintValue);
            //sw.Stop();
            //Console.WriteLine("\n\nmil: " + sw.ElapsedMilliseconds);

            foreach (var item in new List<int>() { 1, 2, 3, 4 })
            {
                PrintValue(item);
            }
            Console.WriteLine("\n\n\nmill: " + sw.ElapsedMilliseconds);
            sw.Restart();
            Parallel.ForEach(new List<int>() { 1, 2, 3, 4 }, PrintValue);
            sw.Stop();
            Console.WriteLine("\n\nmil: " + sw.ElapsedMilliseconds);

            /////////////////////6/////////////////

            //Parallel.Invoke(() =>
            //{
            //    int a = 12 + 32142;
            //    Console.WriteLine("ID OF TASK: " + Task.CurrentId);
            //},
            //    () =>
            //    {
            //        int a = 342 - 311341;
            //        Console.WriteLine("ID OF TASK: " + Task.CurrentId);
            //    },
            //    () =>
            //    {
            //        int a = 123 / 12;
            //        Console.WriteLine("ID OF TASK: " + Task.CurrentId);
            //    },
            //    () =>
            //    {
            //        int a = 11 * 23;
            //        Console.WriteLine("ID OF TASK: " + Task.CurrentId);
            //    }
            //);


            ///////////7////////////////

            // Zadanie7();

            ////////8///////
            //Vyvod();
            //Thread.Sleep(1000);

        }
    }
}
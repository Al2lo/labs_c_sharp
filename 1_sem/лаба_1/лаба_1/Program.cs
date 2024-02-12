using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Объявления переменных
            bool isBool = true;
            byte isByte = 1;
            char isChar = 'f';
            short isShort = 2;
            int isInt = 5;
            long isLong = 42;
            float isFloat = 3;
            double isDouble = 3.1;
            decimal isDecimal = 7;


            isBool = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(isBool);

            isByte = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(isByte);

            isChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(isChar);

            isShort = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(isShort);

            isLong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isLong);

            isFloat = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(isFloat);

            isDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(isDouble);

            isDecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(isDecimal);

            //Явное приведение
            isFloat = (float)isDouble;
            isDouble = (double)isFloat;
            isInt = (int)isFloat;
            isShort = (short)isInt;
            isFloat = (float)isInt;
            isDecimal = Convert.ToDecimal(isFloat);


            //Неявное преобразование
            isFloat = isInt;
            isDecimal = isInt;
            isInt = isShort;
            isDouble = isFloat;
            isLong = isInt;


            //УПАКОВКА И Распаковка 
            Object obj = isInt;
            isInt = (int)obj;

            // неявная типизированная переменная
            var a = 1;
            var b = "djkfjksdjg";
            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());


            //работы с Nullable
            int? numb_nullable = null;
            Console.WriteLine(numb_nullable.HasValue);
            Console.WriteLine(numb_nullable ?? 15);
            Console.WriteLine(numb_nullable.GetValueOrDefault(1));


            //Объясните причину ошибки
            var problem_numb = 4;
            //problem_numb = 1.3;

            //Объявите строковые литералы.Сравните их
            string str1 = "good1";
            string str2 = "good";
            string str3 = "happy birthday";
            string full_str = str1 + str2 + str3;
            string[] split_str;


            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(string.Compare(str2, str1));
            Console.WriteLine(string.Equals(str1, str2));

            //Создайте три строки на основе String
            Console.WriteLine(str1 + str2 + str3);
            Console.WriteLine(string.Concat(str1, str3, str2));
            Console.WriteLine(str1 + string.Copy(str1));// устарело
            Console.WriteLine(str1.Substring(3));
            split_str = str3.Split(' ');
            foreach (string word in split_str)
            {
                Console.WriteLine($"word: {word}");
            }
            Console.WriteLine(str2.Insert(2, "maks"));
            Console.WriteLine(str3.Remove(2, 4));


            //Создайте пустую и null строку
            string null_str = null;
            Console.WriteLine(string.IsNullOrEmpty(null_str));


            //StringBuilder
            StringBuilder str_build = new StringBuilder("naaame");
            str_build.Remove(1, 2);
            str_build.Append('?');
            str_build.Insert(0, "what is your ");
            Console.WriteLine(str_build);


            //мфссив в виде матрицы
            int[,] arr = new int[3, 3] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            Console.WriteLine(string.Format("\n{0} {1} {2}\n{3} {4} {5}\n{6} {7} {8}\n", arr[0, 0], arr[0, 1], arr[0, 2], arr[1, 0], arr[1, 1],
                arr[1, 2], arr[2, 0], arr[2, 1], arr[2, 2]));


            //Создайте одномерный массив строк
            string[] arr_str = new string[] { str1, str2, str3 };


            foreach (string word in arr_str)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(arr_str.Length);
            Console.WriteLine("введит номер элемента на замену");
            int numb = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("введите слово на замену");
            string zamena = Console.ReadLine();

            arr_str[numb] = zamena;

            Console.WriteLine('\n');

            foreach (string word in arr_str)
            {
                Console.WriteLine(word);
            }


            //ступенчаый массив

            int[][] arr_styp = { new int[2], new int[3], new int[4] };

            Console.WriteLine("Введите элементы массива");

            foreach (int[] x in arr_styp)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = Convert.ToInt32(Console.ReadLine());
                }
            }


            foreach (int[] x in arr_styp)
            {
                foreach (int v in x)
                {
                    Console.Write(" " + v);
                }
                Console.WriteLine();

            }

            //Создайте неявно типизированные переменные для хранения массива и строки.

            var strin = "sssss";
            var arr_var = new[] { 1, 2, 3 };



            //Задайте кортеж из 5 элементов с типами int, string, char, string,  ulong.

            (int, string, char, string, ulong) tuple = (5, " fff", 's', "dkjg", 5);

            Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item1 + tuple.Item2);

            (int, string) CreateCortage1()
            {
                int age = 8;
                string name = "maks";
                return (age, name);
            }

            (int, string) CreateCortage2()
            {
                int age = 9;
                string name = "nikita";
                return (age, name);
            }

            var (m1, m2) = CreateCortage1();
            Console.WriteLine(m1 + " " + m2);
            Console.WriteLine(CreateCortage2().CompareTo(CreateCortage1()));
            int[] arrf = new int[4] { 1, 2, 3, 4 };
            string strf = "finiki";

            //function cortage
            (int, int, int, char) func(int[] arrs, string strs)
            {

                int max = 0, sum = 0, min = 1000;

                for (int i = 0; i < arrs.Length; i++)
                {

                    if (max < arrs[i])
                    {
                        max = arrs[i];
                    }

                    if (min > arrs[i])
                    {
                        min = arrs[i];
                    }

                    sum += arrs[i];

                }

                char s = strs[0];

                return (max, min, sum, s);
            }

            Console.WriteLine(func(arrf, strf));

            //cheked and uncheked

            void checkFunc()
            {
                checked
                {
                    int imax = int.MaxValue;
                    Console.WriteLine(imax);// наверное в надо езе + 1
                }
            }

            void uncheckFunc()
            {
                unchecked
                {
                    int imax = int.MaxValue;
                    Console.WriteLine(imax);
                }
            }
            checkFunc();
            uncheckFunc();
        }

    }
}

using System;


namespace Work_Lab
{

    interface a
    {
        public void vu(string a);
    }
    class Program:a
    {
        public void vu(string a)
        {
            Console.WriteLine(a);
        }
        public string name;

        public static void Main(string[] argv)
        {
            Type type = typeof(Program);
            Program program = new Program();
            Reflector.GetNameOfSborka(type);
            Reflector.GetCountOfConstructors(type);


            IEnumerable<string> arr = Reflector.GetMethods(type);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();



            IEnumerable<string> arr2 = Reflector.GetInfoPolia(type);
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();


            IEnumerable<string> arr3 = Reflector.GetInterface(type);
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            string name = new Program().ToString();
            Console.WriteLine(name);
            Reflector.GetNameOFMethods(name);

            object obj = Reflector.GetObj<Program>(name);
            Console.WriteLine(obj.ToString());

            name = new Holop().ToString();
            object holop = Reflector.GetObj<Holop>(name);
            Console.WriteLine(holop.ToString());


            name = new Worker().ToString();
            object worker = Reflector.GetObj<Worker>(name);
            Console.WriteLine(worker.ToString());

            Program program1 = new Program();
            Reflector.MethodWithInvoke(program1);
        }

    }
}
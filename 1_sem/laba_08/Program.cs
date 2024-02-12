using System;

namespace Lab_Work
{
    public delegate void Message(string message);
    public delegate Holop Grade();
    public delegate void Func(string oldSring);
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Holop holop = new Holop{nameOfWorker = "Jon"};
            Worker worker = new Worker();


            holop = holop.Work(holop);
            holop = holop.Work(holop);
            holop = holop.Work(holop);
            holop = holop.Work(holop);


            holop = holop.Work(holop);
            holop = holop.Work(holop);

            holop = holop.Work(holop);
            holop = holop.Work(holop);




            holop = holop.Buy(holop);
            holop = holop.Buy(holop);
            holop = holop.Buy(holop);



            String str = new String("ksdkjklsdjk jkdjksndvnslkdn h  hsjdhgkj!!");

            str.CallAll(str);


        }
    }
}
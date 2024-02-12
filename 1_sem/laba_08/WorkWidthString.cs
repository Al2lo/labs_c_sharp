using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    public class String
    {
        public string str;

        public String(string sttt)
        {
            str = sttt;
        }


        public void RemoveProbel(string oldString)
        {
            string newString = "";
            for (int i = 0; i < this.str.Length; i++)
            {
                if (this.str[i] ==' ' && this.str[i+1] == ' ')
                {
                    continue;

                }

                newString += this.str[i];

            }

            Console.WriteLine(newString);

        }

        public void RemovePunct(string oldString)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.' || str[i]==','|| str[i] == '!' || str[i] =='?')
                {
                    str.Remove(i);
                }
            }

            Console.WriteLine(str);
        }

        public void UpSymbols(string oldString)
        {
            this.str = this.str.ToUpper();

            Console.WriteLine(str);

        }

        public void Remove(string a)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (str[i] == a[j])
                    {
                        str.Remove(i);
                    }
                }
               
            }
            Console.WriteLine(str);
        }

        public void Insert(string a)
        {
            Console.WriteLine("what is position?");
            int position = Convert.ToInt32(Console.Read());
            Console.WriteLine("what is Symbol?");
            string positiona = Console.ReadLine();
            str.Insert(str.Length -1,positiona);
            Console.WriteLine(str);
        }

        public void CallAll(String strr)
        {

            Func func = strr.RemoveProbel;
            func += strr.RemovePunct;
            func += strr.UpSymbols;
            func += strr.Insert;
            func += strr.Remove;
            func(strr.str);
        }

    }
}

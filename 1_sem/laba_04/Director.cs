using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_04
{
    internal class Director
    {
        enum DirectorYear: int{one = 1999, three, four, five, six}
        struct Name
        {
            public string directorName;
            public string directorFamily;

            public Name(string name, string firstName)
            {
                this.directorName = name;
                this.directorFamily = firstName;
            }
        }
        Name directorName = new Name() { directorName = "alex", directorFamily = "novak" };
        public override string ToString()
        {
            Console.WriteLine($"информацию о типе: {base.ToString()} имя: {directorName} фамилия: {directorName.directorFamily}");
            return base.ToString();
        }
    }
}

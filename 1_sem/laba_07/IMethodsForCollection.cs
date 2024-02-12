using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_lab
{
    internal interface IMethodsForCollection<T>
    {
        public void Add(T item);
        public void Delete(T item);
        public void GetInfo();

        public void ReadFile(Set<string> set);

    }
}

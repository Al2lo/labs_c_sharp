using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4_5
{
    public class Memento
    {
        public Stack<List<Bluds>> history { get;  set; }
        public Memento()
        {
            history = new Stack<List<Bluds>>();
        }
    }
}

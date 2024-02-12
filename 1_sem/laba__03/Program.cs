//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace variant_2
//{
//    internal class Set<T>
//    {
//        private HashSet<T> _item = new HashSet<T>();

//        public void Add(T _item)
//        {
//            if (_item ==null)
//            {
//                throw new ArgumentNullException(nameof(_item));
//            }
//            if (a)
//            {

//            }
//        }
//        static void Main(string[] args)
//        {
//            Set<T> set = new Set<T>();

//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_03
{
    internal class Set<T>
    {

        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (!_items.Contains(item))
            {
                _items.Add(item);
            }

        }

        static void Main(string[] args)
        {
            Set<int> set = new Set<int>();

            set.Add(5);
        }
    }
}


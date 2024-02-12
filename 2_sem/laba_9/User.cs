using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_9
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Works Work { get; set; }
        public int Id_work
        {
            get
            {
                return Work.Id;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Work_lab
{
    [Serializable]
    public class Director
    {
        enum DirectorYear: int{one = 1999, three, four, five, six}
        [NonSerialized]
        [XmlIgnore]
        public string directorName;

            public string directorFamily;
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    public class Airplane
    {
        [UserValidationAttribute]
        private int id;
        [UserValidationAttribute]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int countOfPlace { get; set; }
        [UserValidationAttributeYear] [property: Range(0, 50000)]
        public int dateOfCreate { get; set; }
        [property:Range(0,50000) ]
        [UserValidationAttributeweight]
        public int maxWeight { get; set; }
        [property: Range(0, 50000)]
        public int dateOfLastOsmotr { get; set; }
        public string type { get; set; }  
        public string model { get; set; }

        public List<PersonOfEcipash> ekipash = new List<PersonOfEcipash>();
        

    }
}

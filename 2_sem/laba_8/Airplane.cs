using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    public class Airplane
    {
        public int id { get; set; }
        public string type { get; set; }
        public string model { get; set; }
        public int freePlace { get; set; }

        public string dataCreate { get; set; }

        public int maxWeight { get; set; }

        public string dateLastOsm { get; set; }

        public string img { get; set; }

        public List<PersonOfEcipash> ekipash = new List<PersonOfEcipash>();

        public Airplane(int id, string type, string model,int freePalce, string dateOfCreate, int maxWeight,string dateOfLastOsm, string imgSorce)
        {
            this.id = id;
            this.type = type;
            this.model = model;
            this.freePlace = freePalce;
            this.dataCreate = dateOfCreate;
            this.maxWeight = maxWeight;
            this.dateLastOsm = dateOfLastOsm;
            this.img = imgSorce;
        }
        public Airplane(int id)
        {
            this.id = id;
        }
    }
}

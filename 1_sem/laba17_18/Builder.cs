using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_lab
{
    public abstract class Builder
    {
        public  string typeOfCar { get; set; }
        public int maxWeight { get; set; }
        public (int, int) size { get; set; }
        public Builder(string typeOfCar, int maxWeight, (int, int) size)
        {
            this.typeOfCar = typeOfCar;
            this.maxWeight = maxWeight;
            this.size = size;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace laba4_5
{
    public class Bluds
    {
        public int index;
        public string type{ get; set; }
        public string fullName{ get; set; }
        public string name { get; set; }
        public string comment { get; set; }
        public string pathToImage { get; set; }
        public int coast { get; set; }

        public Bluds()
        { }
        public Bluds(string type, string fullname, string comment,string name, int coast, List<Ingtidients> ingtidients,string path)
        {
            this.type = type;
            this.fullName = fullname;
            this.name = name;
            this.comment = comment;
            this.coast = coast;
            this.ingtidients = ingtidients;
            pathToImage = path;
            
        }


        public List<Ingtidients> ingtidients = new List<Ingtidients>();

        public void AddIngridient(Ingtidients ingtidient)
        {
            ingtidients.Add(ingtidient);
        }
        public void OutIngrideints()
        {
            Console.WriteLine("Состав: ");
            foreach (var item in ingtidients)
            {
                Console.Write(item.nameOfIngridient + "\t");
            }
        }
       
    }
}

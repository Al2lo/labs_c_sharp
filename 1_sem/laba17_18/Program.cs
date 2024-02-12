using System;

namespace Work_lab
{




    public class Program
    {




        public static void Main(string[] argv)
        {
            Driver driver2 = new Driver("hetch", 13, (1, 6), 2, "eri");
            Driver driver1 = new Driver("sidan", 15, (3, 3), 1, "valeri");
            Driver dr = new Driver("sidan", 15, (3, 3), 1, "valeri");
            Driver prototype = dr.Clone();
            prototype.GetInfoAboutDrivera(prototype);
;            Client client = new Client();
            client.GiveZakaz(("sidan", 15, 3, 3));
        }
    }
}
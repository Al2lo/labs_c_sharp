using System;

namespace Work_lab
{
    class Program
    {







        public static void Main(string[] argv)
        {
            string name = "kate";
            CustomSerialize<string>.serializeToJson(name);
            CustomSerialize<string>.serializeToXml(name);
            CustomSerialize<string>.SerializeToBinary(name);
            CustomSerialize<string>.SerializeToSoap(name);
            string n1 = CustomSerialize<string>.DesirializeOfSoap("soap.soap");
            string n2 = CustomSerialize<string>.DeserialieOJson("jsonFile.json");
            string n3 = CustomSerialize<string>.DesirializeOfXml("xmlFile.xml");
            string n4 = CustomSerialize<string>.DesirealizefBinarye("binary.dat");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Director director = new Director { directorName = "alex", directorFamily = "fooooo" };
            Director director1 = new Director();
            Director director2 = new Director();
            Director director3 = new Director();
            Director director4 = new Director();


            CustomSerialize<Director>.serializeToJson(director);
            CustomSerialize<Director>.serializeToXml(director);
            CustomSerialize<Director>.SerializeToBinary(director);
            CustomSerialize<Director>.SerializeToSoap(director);
            director1 = CustomSerialize<Director>.DesirializeOfSoap("soap.soap");
            director2 = CustomSerialize<Director>.DeserialieOJson("jsonFile.json");
            director3 = CustomSerialize<Director>.DesirializeOfXml("xmlFile.xml");
            director4 = CustomSerialize<Director>.DesirealizefBinarye("binary.dat");


            Console.WriteLine(director1.directorFamily + director1.directorName);
            Console.WriteLine(director2.directorFamily + director2.directorName);
            Console.WriteLine(director3.directorFamily + director3.directorName);
            Console.WriteLine(director4.directorFamily + director4.directorName);




            List<Director> list = new List<Director>();
            list.Add(director);
            list.Add(director1);
            list.Add(director2);
            list.Add(director3);
            list.Add(director4);
            CustomSerialize<List<Director>>.serializeToXml(list);
            
            List<Director> directors = new List<Director>();
            directors =  CustomSerialize<List<Director>>.DesirializeOfXml("xmlFile.xml");


            foreach(var directorr in directors)
            {
                Console.WriteLine(directorr.ToString());
            }

            CustomSerialize<string>.XmlSelectAll("xmlFile.xml");
            CustomSerialize<string>.XmlSelectElements("xmlFile.xml", "ArrayOfDirector");



            CustomSerialize<string>.CreateXDOc("jdkljlkd.xml");
            CustomSerialize<string>.Zapros("jdkljlkd.xml");
            CustomSerialize<string>.Zapros1("jdkljlkd.xml");


        }
    }
}
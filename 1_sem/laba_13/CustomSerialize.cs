using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;
using System.Globalization;

namespace Work_lab
{
    public static class CustomSerialize<T>
    {
        private static void ChekFile(string nameFile)
        {
            if (File.Exists(nameFile))
            {
                File.Delete(nameFile);
            }
        }
        public static void SerializeToBinary(T obj)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            CustomSerialize<T>.ChekFile("binary.dat");

            using (FileStream file = new FileStream("binary.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(file, obj);
            };
        }

        public static void SerializeToSoap(T obj)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            CustomSerialize<T>.ChekFile("soap.soap");

            using (FileStream file = new FileStream("soap.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(file, obj);
            };
        }


        public static void serializeToXml(T obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            CustomSerialize<T>.ChekFile("xmlFile.xml");

            using (FileStream file = new FileStream("xmlFile.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(file, obj);
            }
        }


        public static void serializeToJson(T obj)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(T));

            CustomSerialize<T>.ChekFile("jsonFile.json");

            using (FileStream file = new FileStream("jsonFile.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(file, obj);
            }
        }

        public static T DesirealizefBinarye(string nameFile)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                T variable = (T)formatter.Deserialize(file);
                return variable;
            };
        }

        public static T DesirializeOfSoap(string nameFile)
        {
            SoapFormatter formatter = new SoapFormatter();

            using (FileStream file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                T variable = (T)formatter.Deserialize(file);
                return variable;
            }
        }

        public static T DesirializeOfXml(string nameFile)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            using (FileStream file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                T value = (T)formatter.Deserialize(file);
                return value;
            }
        }

        public static T DeserialieOJson(string nameFile)
        {
            DataContractJsonSerializer formaatter = new DataContractJsonSerializer(typeof(T));

            using (FileStream file = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                T value = (T)formaatter.ReadObject(file);
                return value;
            }

        }

        public static void XmlSelectAll(string name)
        {
            string outStr = "";
            XPathDocument doc = new XPathDocument(name);
            XPathNavigator navigator = doc.CreateNavigator();
            XPathNodeIterator iterator = navigator.Select("*");
            while (iterator.MoveNext())
            {
                outStr += iterator.Current.Name + iterator.Current.Value;
                iterator.Current.MoveToParent();

            }

            Console.WriteLine(outStr);

        }


        public static void XmlSelectElements(string name, string nameOfAttribute)
        {
            string outStr = "";

            XPathDocument doc = new XPathDocument(name);

            XPathNavigator navigator = doc.CreateNavigator();
            XPathNodeIterator iterator = navigator.Select(nameOfAttribute);

            while (iterator.MoveNext())
            {
                outStr += iterator.Current.Name + iterator.Current.Value;

            }
            Console.WriteLine(outStr);

        }

        public static void CreateXDOc(string path)
        {
            XDocument doc = new XDocument();
            XElement library = new XElement("Library");
            XElement book = new XElement("Book","8");
            XAttribute attribute = new XAttribute("name", "food");
            book.Add(attribute);
            XElement book1 = new XElement("book1", new XAttribute("name", "dWord"));
            library.Add(book);
            library.Add(book1);
            doc.Add(library);
            doc.Save(path);

        }


        public static void Zapros(string name)
       {
            XDocument xElement = XDocument.Load(name);

            var zapros = from item in xElement.Descendants("Book")
                         where item.Name == "Book"
                         where item.Value == "8"
                         select item;
            foreach (var item in zapros)
            {
                Console.WriteLine(item.Name + "-" + item.Attribute("name").Value);
            }
        }



        public static void Zapros1(string name)
        {
            XDocument xElement = XDocument.Load(name);

            var zapros = from item in xElement.Descendants("Book")
                         where item.Name == "Book"
                         select new
                         {
                             Name = "global",
                             Value = "192",

                         };
            foreach (var item in zapros)
            {
                Console.WriteLine(item.Name + "-" + item.Value);
            }
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using System.IO;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace Work_Lab
{
    static class Reflector
    {
        public static void GetNameOfSborka(Type type)
        {
            using (StreamWriter file = new StreamWriter("file.txt", true))
            { 
                file.WriteLine(type.Assembly.FullName);
                file.WriteLine(type.Assembly.Location);
            }
        }

        public static void GetCountOfConstructors(Type type)
        {
            int count = 0;
            using (StreamWriter file = new StreamWriter("file.txt", true))
            {
                file.Write("конструкторы: ");
                foreach (ConstructorInfo ctor in type.GetConstructors())
                {
                    if (ctor.IsPublic)
                    {
                        file.WriteLine("Есть");
                        break;
                    }
                    count++;
                }
                if (count == type.GetConstructors().Length)
                {
                    file.WriteLine("No");
                }
            }
        }


        public static IEnumerable<string> GetMethods(Type type)
        {
            List<string> list = new List<string>();
            using (StreamWriter file = new StreamWriter("file.txt", true))
            {
                file.Write("Публичные методы: ");
                foreach (var item in type.GetMethods())
                {
                    if (item.IsPublic)
                    {
                        file.WriteLine(item.Name + " ");
                        list.Add(item.Name);
                    }

                }


            }
            IEnumerable<string> strings = list;
            return strings;
        }

        public static IEnumerable<string> GetInfoPolia(Type type)
        {
            List<string> list = new List<string>();
            using (StreamWriter file = new StreamWriter("file.txt", true))
            {
                file.Write("Информация о полях и свойствах: ");
                foreach (var item in type.GetFields())
                {

                    file.WriteLine(item.Name + ", " + item.FieldType + ", " + item.FieldHandle);
                    list.Add(item.Name);

                }


            }
            IEnumerable<string> strings = list;
            return strings;
        }



        public static IEnumerable<string> GetInterface(Type type)
        {
            List<string> list = new List<string>();
            using (StreamWriter file = new StreamWriter("file.txt", true))
            {
                file.Write("Информация о интерфейсах: ");
                foreach (var item in type.GetInterfaces())
                {

                    file.WriteLine(item.FullName + " " + item.Namespace + " " + item.Attributes);
                    list.Add(item.Name);

                }


            }
            IEnumerable<string> strings = list;
            return strings;
        }

        public static void GetNameOFMethods(string name)
        {
            using (StreamWriter file = new StreamWriter("file.txt", true))
            {
                Type type = Type.GetType(name);
                file.Write("Информация о методах: ");
                foreach (var item in type.GetMethods())
                {

                    file.WriteLine(item.Name);
                    Console.WriteLine(item.Name);

                }
            }



        }



        public static void MethodWithInvoke(object objPar)
        {
            using (StreamReader file = new StreamReader("fileReader.txt",true))
            {
                object[] obj = { " "};
                string[] strings = file.ReadToEnd().Split(' ');
                string Param = "ksjgk";
                object[] arrPar = {(object)Param};
                Type magicType = Type.GetType(strings[0]);
                MethodInfo magicConstructor = magicType.GetMethod(strings[1]);
                object d = magicConstructor.Invoke(objPar, new object[] { arrPar[0] } );
            }
        }


        public static T GetObj<T>(string type)
        {
            Type obj = Type.GetType(type);
            ConstructorInfo objConstructor = obj.GetConstructor(Type.EmptyTypes);
            object newClassObject = objConstructor.Invoke(new object[] { });
            return (T)newClassObject;
        }


    }


}

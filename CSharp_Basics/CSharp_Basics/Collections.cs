using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class CollectionsExample
    {
        [Test]
        public void SimpleArray()
        {
            var array = new string[5];
            array[0] = "Emka";
            array[1] ="Patryk";
            array[2] = "ewa";


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        [Test]
        public void SimpleCollection()
        {
            var list = new List<string>();
            list.Add("Emka");
            list.Add("Patryk");
            list.Add("ewa");


            foreach (var listelemnet in list)
            {
                if (listelemnet.Length > 3)
                {
                    Console.WriteLine(listelemnet);
                }
            }
        }

        [Test]
        public void SimpleCollection2()
        {
            var list = new List<string> { "Emka", "ewa", "patryk"};

            Console.WriteLine(list.Where(x => x.Length > 3).First());
        }


        [Test]
        public void SimpleCollection3()
        {
            var dictionary = new Dictionary<string, Employee>()
            {
                {"Emka", new Employee("Emka", 666, "Koszalin")},
                {"Lka", new Employee("Lka", 669, "Koszalin")},
                {"Ska", new Employee("Ska", 668, "Koszalin")},
                {"Xlka", new Employee("Xlka", 664, "Wroclaw")},
            };

            Console.WriteLine(dictionary["Emka"].Name);
        }
    }
}
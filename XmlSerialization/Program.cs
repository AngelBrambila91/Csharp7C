using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace XmlSerialization
{
    public class Person
    {
        public Person()
        {

        }
        public Person(decimal initialSalary)
        {
            Salary = initialSalary;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public HashSet<Person> Children { get; set; }
        protected decimal Salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person(30000M) {
                    FirstName = "Adrian",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(2000, 07, 03)
                },

                new Person(30000M) {
                    FirstName = "Oscar",
                    LastName = "Uchiha",
                    DateOfBirth = new DateTime(2000, 07, 03)
                },

                new Person(30000M) {
                    FirstName = "Elena",
                    LastName = "Fresa",
                    DateOfBirth = new DateTime(2000, 07, 03)
                },

                new Person(30000M) {
                    FirstName = "Ana",
                    LastName = "Scream",
                    DateOfBirth = new DateTime(2000, 07, 03)
                },

                new Person(30000M) {
                    FirstName = "Ricardo",
                    LastName = "Lol",
                    DateOfBirth = new DateTime(2000, 07, 03)
                }
            };

            var xs = new XmlSerializer(typeof(List<Person>));
            //create path
            string path = Combine(CurrentDirectory, "people.xml");

            using( FileStream stream = File.Create(path))
            {
                xs.Serialize(stream, people);
            }

            using (FileStream xmlLoad = File.Open(path, FileMode.Open))
            {
                var loadedPoeple = (List<Person>)xs.Deserialize(xmlLoad);

            foreach (var item in loadedPoeple)
            {
                WriteLine($"{item.LastName} {item.Children.Count}");
            }
            }

            string jsonPath = Combine(CurrentDirectory, "people.json");
            using( StreamWriter jsonStream = File.CreateText(jsonPath))
            {
                var jss = new Newtonsoft.Json.JsonSerializer();
                jss.Serialize(jsonStream, people);
            }
        }
    }
}

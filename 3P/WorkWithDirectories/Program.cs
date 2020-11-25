using System;
using static System.Console;
using System.IO;
using static System.IO.Directory;
using static System.Environment;
using static System.IO.Path;
using System.Xml;
using System.Linq;
namespace WorkWithDirectories
{
    class Program
    {
        static string[] Persons = new string[] {
                "Adrian", "Eddie", "Ricardo", "Fer", "Oscar"
        };
        static void Main(string[] args)
        {
            #region Creating our own URL's
                var newFolder = Combine(Directory.GetCurrentDirectory(), "TestingDirectory", "New Folder", "Something");
                WriteLine($"Working with {newFolder}");
                if(Exists(newFolder))
                {
                    WriteLine("Folder Already Exists");
                }
                else
                {
                CreateDirectory(newFolder);
                }
                WriteLine(Exists(newFolder));
                Delete(Combine(Directory.GetCurrentDirectory(), "TestingDirectory"), recursive:true);
                WriteLine(Exists(newFolder));
            #endregion

            #region Managing Files
                //WorkWithfiles();
            #endregion

            #region writing an XML File
                WorkWithXML();
            #endregion

        }

        static void WorkWithfiles()
        {
            var dir = Combine(
                GetFolderPath(SpecialFolder.Personal), "WorkWithFiles", "OutPutFiles"
            );
            CreateDirectory(dir);
            string textFile = Combine(dir, "Dummy.txt");
            string backupFile = Combine(dir, "Dummy.bak");
            WriteLine($"Working with {textFile}");
            WriteLine($"File exists? : {File.Exists(textFile)}");

            StreamWriter textWriter = File.CreateText(textFile);
            textWriter.WriteLine("Holo canobo");
            textWriter.Close();

            WriteLine($"File exists after write? : {File.Exists(textFile)}");
            File.Copy(sourceFileName: textFile, destFileName: backupFile, overwrite:true);
            WriteLine($"BackupFile exists? : {File.Exists(backupFile)}");
            ReadLine();

            File.Delete(textFile);
            WriteLine($"File exists? : {File.Exists(textFile)}");

            //Read from backup File
            WriteLine("Reading content from backupFile");
            StreamReader textReader = File.OpenText(backupFile);
            WriteLine(textReader.ReadToEnd());
        }

        static void WorkWithXML()
        {
            string xmlFile = Combine(CurrentDirectory, "streams.xml");
            FileStream xmlFileStream = File.Create(xmlFile);
            XmlWriter xml = XmlWriter.Create(xmlFileStream, new XmlWriterSettings {Indent = true});


            //write the XML Declaration (UTF and stuff)
            xml.WriteStartDocument();

            // write a root element
            xml.WriteStartElement("Persons");

            // enumerate data that cointains in each tag
            foreach (string item in Persons)
            {
                xml.WriteElementString("Name", item);
            }

            xml.WriteEndElement();
            xml.Close();
            xmlFileStream.Close();

            WriteLine($"{xmlFile} cointains {new FileInfo(xmlFile).Length}");
            WriteLine(File.ReadAllText(xmlFile));


            for

        }
    }
}

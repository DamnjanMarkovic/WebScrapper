using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using ClassLibrary.Models;
using ClassLibrary.Models.GamaAlati;

namespace ClassLibrary.MainSingletones
{
    public class GamaAlatiSingletone
    {
        private static GamaAlatiSingletone instance;
        private GamaAlatiSingletone() { }

        public static GamaAlatiSingletone Instance => instance ?? (instance = new GamaAlatiSingletone());

        public void GamaAlati()
        {
            //Read from existing XML-s
            ReadFromXMLDoc();

        }

        private void ReadFromXMLDoc()
        {
            UrlSet urlSet = new UrlSet();

            string path = @"C:\Users\Damnjan Markovic\source\repos\Web\WebScrapping\WebScrapper\ClassLibrary\SiteMaps\GamaAlati\sitemap-2-1.xml";

            using (StreamReader reader = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UrlSet));
                urlSet = (UrlSet)serializer.Deserialize(reader);
            }
            Console.WriteLine();

            List<Url> lista = new List<Url>();

            //using (StreamReader reader = new StreamReader(path))
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(List<Url>));
            //    lista = (List<Url>)serializer.Deserialize(reader);
            //}
            //Console.WriteLine();

            //var xml = XDocument.Load(@"C:\Users\Damnjan Markovic\source\repos\Web\WebScrapping\WebScrapper\ClassLibrary\SiteMaps\GamaAlati\sitemap-2-1.xml");

            //List<Url> listAllEntries = new List<Url>();

            //foreach (var nextFile in xml)
            //{
            //    try
            //    {
            //        XmlSerializer serializer = new XmlSerializer(typeof(Entry));
            //        using (TextReader reader = new StringReader(System.IO.File.ReadAllText(nextFile.FullName)))
            //        {
            //            Entry result = (Entry)serializer.Deserialize(reader);
            //            listAllEntries.Add(result);
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}












            //// Query the data and write out a subset of contacts
            //var query = from c in xml.Root.Descendants("contact")
            //            where (int)c.Attribute("id") < 4
            //            select c.Element("firstName").Value + " " +
            //                   c.Element("lastName").Value;


            //foreach (string name in query)
            //{
            //    Console.WriteLine("Contact's Full Name: {0}", name);
            //}
        }
    }
}

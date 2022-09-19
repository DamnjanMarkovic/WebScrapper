using ClassLibrary.Models;
using LINQtoCSV;
//using SoftCircuits.CsvParser;
//using Csv;
//using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class HelperFunctions
    {
        public static string RemoveLastWords(this string input, int numberOfLastWordsToBeRemoved, char delimitter)
        {
            string[] words = input.Split(new[] { delimitter });
            words = words.Reverse().ToArray();
            words = words.Skip(numberOfLastWordsToBeRemoved).ToArray();
            words = words.Reverse().ToArray();
            string output = String.Join(delimitter.ToString(), words);
            return output;
        }

        public static async Task<string> GetHtml(string url)
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }

        public static void WriteCsvFileModelDefault(List<CSVModelDefault> listModelDefaultObjects, string fileName)
        {
            //using LinqToCSV
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                SeparatorChar = ','
            };

            var csvContext = new CsvContext();
            csvContext.Write(listModelDefaultObjects, $"{fileName}.csv", csvFileDescription);

            Console.WriteLine($"CSV File {fileName} Created.");


            //using CsvHelper
            //using (var writer = new StreamWriter($"{fileName}.csv"))
            //using (var csv = new CsvWriter($"{fileName}.csv"))
            //{
            //    foreach (var item in listModelDefaultObjects)
            //    {
            //        csv.WriteRow(item);

            //    }
            //}

            //using SoftCircuits.CsvParser;
            //CsvWriter<CSVModelDefault> writerS = new CsvWriter<CSVModelDefault>($"{fileName}.csv");

            //using (CsvWriter<CSVModelDefault> writer = writerS)
            //{
            //    writer.WriteHeaders();

            //    foreach (CSVModelDefault person in listModelDefaultObjects)
            //        writer.Write(person);
            //}



            //get all cultures
            //CultureInfo[] specificCultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            //foreach (CultureInfo ci in specificCultures)

            //    Console.WriteLine(ci.DisplayName);
            //Console.WriteLine("Total: " + specificCultures.Length);



            //using CsvHelper
            //using (var writer = new StreamWriter($"{fileName}.csv"))
            //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            //{
            //    csv.WriteRecords(listModelDefaultObjects);
            //}


        }
        //public static void WriteCsvFile(List<Product> products, string fileName)
        //{
        //    var csvFileDescription = new CsvFileDescription
        //    {
        //        FirstLineHasColumnNames = true,
        //        SeparatorChar = ','
        //    };

        //    var csvContext = new CsvContext();
        //    csvContext.Write(products, $"{fileName}.csv", csvFileDescription);

        //    Console.WriteLine($"CSV File {fileName} Created.");
        //}
        
    }
}

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
            //create fake headers
            httpClient.DefaultRequestHeaders.Add("User-Agent",
                            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:77.0) Gecko/20100101 Firefox/77.0");
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

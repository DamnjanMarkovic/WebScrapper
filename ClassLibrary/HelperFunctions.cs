using ClassLibrary.Models;
using LINQtoCSV;
using System;
using System.Collections.Generic;
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
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                SeparatorChar = ','
            };

            var csvContext = new CsvContext();
            csvContext.Write(listModelDefaultObjects, $"{fileName}.csv", csvFileDescription);

            Console.WriteLine($"CSV File {fileName} Created.");
        }
        public static void WriteCsvFile(List<Product> products, string fileName)
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                SeparatorChar = ','
            };

            var csvContext = new CsvContext();
            csvContext.Write(products, $"{fileName}.csv", csvFileDescription);

            Console.WriteLine($"CSV File {fileName} Created.");
        }

        public static List<CSVModelDefault> CreateListOfCSVModelDefault(List<Product> products)
        {
            List<CSVModelDefault> listCSVModelDefaults = new List<CSVModelDefault>();
            foreach (Product product in products)
            {
                if (!string.IsNullOrEmpty(product.Name))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var techSpecs in product.TechSpecs)
                    {
                        sb.Append($"{techSpecs.Key}: {techSpecs.Value}; ");
                    }

                    CSVModelDefault modelDefault = new CSVModelDefault()
                    {
                        Title = product.Name,
                        Vendor = "Makita",
                        Image_Src = product.ImageLink,
                        Variant_SKU = product.ProductNumber,
                        Body = sb.ToString(),
                        Type = product.Type
                    };
                    listCSVModelDefaults.Add(modelDefault);
                }
            }
            return listCSVModelDefaults;
        }
    }
}

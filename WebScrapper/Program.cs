using ClassLibrary;
using ClassLibrary.Models;
using HtmlAgilityPack;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Xml;

namespace WebScrapper
{
    class Program
    {
        #region Props
        public static Logger log = LogManager.GetCurrentClassLogger();
        public delegate List<Product> ProductLinks();
        public delegate List<Product> ProductsDetails();

        public static List<Product> products = new List<Product>();
        #endregion
        static void Main(string[] args)
        {
            ProductLinks productLinks = GetProductsLinks;
            IAsyncResult arProductLinks = productLinks.BeginInvoke(null, null);

            while (!arProductLinks.IsCompleted) { }

            HelperFunctions.WriteCsvFile(products, "ProductsLinks");

            ProductsDetails productsDetails = GetProductsDetails;
            IAsyncResult arProductsDetails = productsDetails.BeginInvoke(null, null);

            while (!arProductsDetails.IsCompleted) { }

            List<CSVModelDefault> listModelDefault = HelperFunctions.CreateListOfCSVModelDefault(products);

            HelperFunctions.WriteCsvFileModelDefault(listModelDefault, "Final_Products");

            Console.ReadLine();
        }


        private static List<Product> GetProductsDetails()
        {
            foreach (Product product in products)
            {
                if (product.Id < 4)
                {
                    var url = $"{product.URL}";
                    var httpClient = new HttpClient();
                    string html = HelperFunctions.GetHtml(url).Result;
                    var htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(html);

                    var headerlists = new List<HtmlNode>();
                    var listNodes = new List<HtmlNode>();


                    var contentContainer = htmlDocument.DocumentNode.Descendants("body").ToList();

                    foreach (var containerElement in contentContainer[0].Descendants())
                    {
                        if (containerElement.Attributes["class"] != null && containerElement.Attributes["class"].Value != null && containerElement.Attributes["class"].Value == "product-container")
                        {
                            foreach (var productTitleElement in containerElement.Descendants())
                            {
                                if (productTitleElement.Attributes["class"] != null && productTitleElement.Attributes["class"].Value != null && productTitleElement.Attributes["class"].Value == "product-title")
                                {
                                    foreach (var item in productTitleElement.Descendants())
                                    {
                                        if (item.Name != null && item.Name == "h1")
                                        {
                                            product.Name = item.InnerHtml.ToString();
                                        }
                                    }
                                }
                                if (productTitleElement.Attributes["class"] != null && productTitleElement.Attributes["class"].Value != null && productTitleElement.Attributes["class"].Value == "product-number")
                                {
                                    product.ProductNumber = productTitleElement.InnerHtml.ToString();
                                }
                                if (productTitleElement.Attributes["class"] != null && productTitleElement.Attributes["class"].Value != null && productTitleElement.Attributes["class"].Value == "images")
                                {
                                    foreach (var item in productTitleElement.Descendants())
                                    {
                                        if (item.Attributes["class"] != null && item.Attributes["class"].Value != null && item.Attributes["class"].Value.Contains("big"))
                                        {
                                            foreach (var itemA in item.Descendants())
                                            {
                                                if (itemA.Name.ToString().Equals("a"))
                                                {
                                                    if (itemA.Attributes["href"] != null && itemA.Attributes["href"].Value != null &&
                                                                                        itemA.Attributes["href"].Value.Trim().Contains("https:"))
                                                    {
                                                        product.ImageLink = itemA.Attributes["href"].Value.Trim();
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        if (containerElement.Attributes["class"] != null && containerElement.Attributes["class"].Value != null && containerElement.Attributes["class"].Value == "techspecs-container")
                        {
                            foreach (var itemTechSpecs in containerElement.ChildNodes)
                            {
                                string key = "";
                                string value = "";
                                if (itemTechSpecs.Attributes["class"] != null && itemTechSpecs.Attributes["class"].Value != null && itemTechSpecs.Attributes["class"].Value == "techspecs")
                                {
                                    foreach (var itemRows in itemTechSpecs.ChildNodes)
                                    {
                                        if (itemRows.Attributes["class"] != null && itemRows.Attributes["class"].Value != null && itemRows.Attributes["class"].Value == "techspecs--row")
                                        {
                                            foreach (var itemTechSpecsFinal in itemRows.ChildNodes)
                                            {


                                                if (itemTechSpecsFinal.Attributes["class"] != null && itemTechSpecsFinal.Attributes["class"].Value != null && itemTechSpecsFinal.Attributes["class"].Value == "techspecs--row-specification")
                                                {
                                                    key = itemTechSpecsFinal.InnerHtml.ToString().Trim();
                                                }
                                                else if (itemTechSpecsFinal.Attributes["class"] != null && itemTechSpecsFinal.Attributes["class"].Value != null && itemTechSpecsFinal.Attributes["class"].Value == "techspecs--row-value")
                                                {
                                                    value = itemTechSpecsFinal.InnerHtml.ToString().Trim();
                                                }
                                            }
                                            product.TechSpecs.Add(new KeyValuePair<string, string>(key, value));

                                        }
                                    }



                                }
                            }
                        }

                        if (containerElement.Attributes["class"] != null && containerElement.Attributes["class"].Value != null && containerElement.Attributes["class"].Value == "container_breadcrumbs")
                        {
                            foreach (var item in containerElement.Descendants())
                            {
                                if (item.Attributes["class"] != null && item.Attributes["class"].Value != null && item.Attributes["class"].Value == "crumb")
                                {
                                    if (!string.IsNullOrEmpty(item.InnerHtml.Trim()) && !item.InnerHtml.Trim().Equals("Homepage") && !item.InnerHtml.Trim().Equals(product.Name))
                                    {
                                        product.Type += $"{item.InnerHtml.Trim()}; ";
                                    }
                                }
                            }
                        }
                    }

                    product.Type = Regex.Replace(HelperFunctions.RemoveLastWords(product.Type, 2, ';'), @"; ", " > ") + " >";

                    log.Warn($"Product with link: {product.URL} added.");
                    log.Warn($"Product ID: {product.Id} and name: {product.Name}.");
                    foreach (var item in product.TechSpecs)
                    {
                        log.Warn($"Product details Key: {item.Key}, value: {item.Value}.");
                    }
                    log.Warn($"Product type: {product.Type}.");

                    log.Warn($"-----------------------------------------------------------");
                }

            }
            return products;
        }

        private static List<Product> GetProductsLinks()
        {
            //https://www.makita.rs/sitemap.xml

            string URLString = "https://www.makita.rs/data/pam/sitemap/sitemap-1-1.xml";

            XmlTextReader reader = new XmlTextReader(URLString);
            int productID = 0;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Text:
                        if (reader.Value.ToString().Contains("https://www.makita.rs/product/"))
                        {
                            productID++;
                            products.Add(new Product() { Id = productID, URL = reader.Value.ToString() });
                        }
                        break;
                }
            }
            return products;
        }
    }
}

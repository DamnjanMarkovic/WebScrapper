using ClassLibrary.Models;
using HtmlAgilityPack;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary.MainSingletones
{
    public class MakitaSingletone
    {
        #region Properties
        public delegate List<ProductMakita> ProductLinks();
        public delegate List<ProductMakita> ProductsDetails();

        public static Logger log = LogManager.GetCurrentClassLogger();

        public static List<ProductMakita> products = new List<ProductMakita>();

        #endregion


        private static MakitaSingletone instance;
        private MakitaSingletone() { }

        public static MakitaSingletone Instance => instance ?? (instance = new MakitaSingletone());

        private static List<CSVModelDefault> CreateListOfCSVModelDefault(List<ProductMakita> products)
        {
            List<CSVModelDefault> listCSVModelDefaults = new List<CSVModelDefault>();
            foreach (ProductMakita product in products)
            {
                if (!string.IsNullOrEmpty(product.Title))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var techSpecs in product.TechSpecs)
                    {
                        sb.Append($"{techSpecs.Key}: {techSpecs.Value}; ");
                    }

                    CSVModelDefault modelDefault = new CSVModelDefault()
                    {
                        Handle = product.Title,
                        Title = product.Title,
                        Vendor = "Makita",
                        Image_Src = product.ImageLink,
                        Variant_SKU = product.ProductNumber,
                        Body = sb.ToString(),
                        CustomProductType = product.Type,
                        Status = "active",
                        Published = "TRUE",
                        Option1_Name = "Title",
                        Option1_Value = "Default Title",
                        Variant_Inventory_Qty = "0",
                        Variant_Inventory_Policy = "Deny",
                        Variant_FulFillment_Service = "manual",
                        Variant_Requires_Shipping = "TRUE",
                        Variant_Taxable = "TRUE",
                        Image_Position = "1",
                        Image_Alt_Text = product.Title,
                        Gift_Card = "FALSE"



                    };
                    listCSVModelDefaults.Add(modelDefault);
                }
            }
            return listCSVModelDefaults;
        }

        public void Makita()
        {
            ProductLinks productLinks = GetProductsLinks;
            IAsyncResult arProductLinks = productLinks.BeginInvoke(null, null);

            while (!arProductLinks.IsCompleted) { }

            //HelperFunctions.WriteCsvFile(products, "ProductsLinks");

            ProductsDetails productsDetails = GetProductsDetails;
            IAsyncResult arProductsDetails = productsDetails.BeginInvoke(null, null);

            while (!arProductsDetails.IsCompleted) { }

            List<CSVModelDefault> listModelDefault = CreateListOfCSVModelDefault(products);

            HelperFunctions.WriteCsvFileModelDefault(listModelDefault, "Final_Products");
        }

        private static List<ProductMakita> GetProductsDetails()
        {
            foreach (ProductMakita product in products)
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
                                            product.Handle = item.InnerHtml.ToString();
                                            product.Title = item.InnerHtml.ToString();
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
                                    if (!string.IsNullOrEmpty(item.InnerHtml.Trim()) && !item.InnerHtml.Trim().Equals("Homepage") && !item.InnerHtml.Trim().Equals(product.Title))
                                    {
                                        product.Type += $"{item.InnerHtml.Trim()}; ";
                                    }
                                }
                            }
                        }
                    }

                    product.Type = Regex.Replace(HelperFunctions.RemoveLastWords(product.Type, 2, ';'), @"; ", " > ") + " >";

                    log.Warn($"Product with link: {product.URL} added.");
                    //log.Warn($"Product ID: {product.Id} and name: {product.Name}.");
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

        private static List<ProductMakita> GetProductsLinks()
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
                            products.Add(new ProductMakita() { Id = productID, URL = reader.Value.ToString() });
                        }
                        break;
                }
            }
            return products;
        }
    }
}

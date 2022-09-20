using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using ClassLibrary.Models;
using ClassLibrary.Models.GamaAlati;
using HtmlAgilityPack;
using NLog;
using RestSharp;

namespace ClassLibrary.MainSingletones
{
    public class GamaAlatiSingletone
    {
        #region Props

        public UrlSet urlSet = new UrlSet();

        public delegate List<ProductGamaAlati> ProductLinks();
        public delegate List<ProductGamaAlati> ProductsDetails();

        public static Logger log = LogManager.GetCurrentClassLogger();

        public static List<ProductGamaAlati> products = new List<ProductGamaAlati>();


        #endregion


        private static GamaAlatiSingletone instance;
        private GamaAlatiSingletone() { }

        public static GamaAlatiSingletone Instance => instance ?? (instance = new GamaAlatiSingletone());

        public void GamaAlati()
        {
            //Read from existing XML-s
            GetUrlSetFromXMLs();

            ProductLinks productLinks = GetProductsLinks;
            IAsyncResult arProductLinks = productLinks.BeginInvoke(null, null);

            while (!arProductLinks.IsCompleted) { }


            ProductsDetails productsDetails = GetProductsDetails;
            IAsyncResult arProductsDetails = productsDetails.BeginInvoke(null, null);

            while (!arProductsDetails.IsCompleted) { }

            List<CSVModelDefault> listModelDefault = CreateListOfCSVModelDefault(products);

            HelperFunctions.WriteCsvFileModelDefault(listModelDefault, "Final_Products");

        }
        private void GetUrlSetFromXMLs()
        {
            urlSet = new UrlSet();

            //TODO - fix path
            string path = @"C:\Users\Damnjan Markovic\source\repos\Web\WebScrapping\WebScrapper\ClassLibrary\SiteMaps\GamaAlati\sitemap-2-4.xml";
            //string path = @"C:\Users\Damnjan Markovic\source\repos\Web\WebScrapping\WebScrapper\ClassLibrary\SiteMaps\GamaAlati\XMLFile1.xml";

            using (StreamReader reader = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UrlSet));
                urlSet = (UrlSet)serializer.Deserialize(reader);
            }
            Console.WriteLine();
        }

        private List<ProductGamaAlati> GetProductsLinks()
        {
            int productID = 0;
            foreach (var item in urlSet.UrlList)
            {
                productID++;

                //limit products to 50
                if (productID < 50)
                {
                    products.Add(new ProductGamaAlati()
                    {
                        Id = productID,
                        Title = item.Image_image?.Image_title,
                        ProductURL = item.Loc,
                        ImageSrc = item.Image_image?.Image_loc,
                        ImageAltText = item.Image_image?.Image_title
                    });
                }
            }
            return products;
        }


        private static List<ProductGamaAlati> GetProductsDetails()
        {
            foreach (ProductGamaAlati product in products)
            {
                Console.WriteLine($"Product No. {product.Id} of {products.Count} created.");
                var url = $"{product.ProductURL}";
                string html = HelperFunctions.GetHtml(url).Result;
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(html);

                var headerlists = new List<HtmlNode>();
                var listNodes = new List<HtmlNode>();

                var contentContainer = htmlDocument.DocumentNode.Descendants("body").ToList();

                foreach (var containerElement in contentContainer[0].Descendants())
                {
                    if (containerElement.Attributes["class"] != null && containerElement.Attributes["class"].Value != null && containerElement.Attributes["class"].Value == "page-main")
                    {

                        foreach (var productElement in containerElement.Descendants())
                        {
                            //Fetch Product Body
                            if (productElement.Attributes["class"] != null && productElement.Attributes["class"].Value != null && productElement.Attributes["class"].Value == "product attribute description")
                            {
                                product.BodyHtml = productElement.InnerHtml.ToString();
                            }

                            //Fetch Product SKU
                            if (productElement.Attributes["data-product-sku"] != null && productElement.Attributes["data-product-sku"].Value != null)
                            {
                                product.VariantSKU = productElement.Attributes["data-product-sku"].Value;
                            }

                            //Fetch Product Vendor
                            if (productElement.Attributes["class"] != null && productElement.Attributes["class"].Value != null && productElement.Attributes["class"].Value == "product attribute deklaracija")
                            {
                                foreach (var item in productElement.Descendants())
                                {
                                    if (item.Name.ToString().Equals("li"))
                                    {
                                        if (item.InnerText != null && !string.IsNullOrEmpty(item.InnerText) &&
                                                                                        item.InnerText.Contains("Proizvođač"))
                                        {
                                            var result = item.InnerText.ToString();
                                            product.Vendor = result.Substring(result.LastIndexOf(':') + 2);
                                        }
                                    }
                                }
                            }
                            //Fetch VariantSKU
                            if (productElement.Attributes["class"] != null && productElement.Attributes["class"].Value != null && productElement.Attributes["class"].Value == "product-add-form")
                            {
                                foreach (var item in productElement.Descendants())
                                {
                                    if (item.Attributes["data-product-sku"] != null && item.Attributes["data-product-sku"].Value != null)
                                    {
                                        product.VariantSKU = item.InnerHtml.ToString();
                                    }
                                }
                            }
                            if (productElement.Attributes["class"] != null && productElement.Attributes["class"].Value != null && productElement.Attributes["class"].Value == "product-number")
                            {
                                product.VariantSKU = productElement.InnerHtml.ToString();
                            }

                            //Fetch Prices
                            if (productElement.Attributes["class"] != null && productElement.Attributes["class"].Value != null && productElement.Attributes["class"].Value == "product-info-price")
                            {
                                foreach (var item in productElement.Descendants())
                                {
                                    if (item.Attributes["data-price-type"] != null && item.Attributes["data-price-type"].Value != null && item.Attributes["data-price-type"].Value == "finalPrice")
                                    {
                                        if (item.Attributes["data-price-amount"] != null && item.Attributes["data-price-amount"].Value != null)
                                            product.VariantPrice = item.Attributes["data-price-amount"].Value;
                                    }
                                    if (item.Attributes["data-price-type"] != null && item.Attributes["data-price-type"].Value != null && item.Attributes["data-price-type"].Value == "oldPrice")
                                    {
                                        if (item.Attributes["data-price-amount"] != null && item.Attributes["data-price-amount"].Value != null)
                                            product.VariantCompareAtPrice = item.Attributes["data-price-amount"].Value;
                                    }
                                }
                                product.BodyHtml = productElement.InnerHtml.ToString();
                            }

                            //Fetch Weight
                            if (productElement.Attributes["class"] != null && productElement.Attributes["class"].Value != null && productElement.Attributes["class"].Value == "product attribute overview")
                            {
                                foreach (var item in productElement.Descendants())
                                {
                                    if (item.Name.ToString().Equals("li"))
                                    {
                                        if (item.InnerText != null && !string.IsNullOrEmpty(item.InnerText) &&
                                                                                        item.InnerText.Contains("Težina"))
                                        {
                                            try
                                            {
                                                var result = item.InnerText.ToString();
                                                //removing 'Težina'
                                                var result_01 = result.Substring(result.LastIndexOf(':') + 2);
                                                //removing ' kg'
                                                var result_02 = result_01.Remove(result_01.Length - 3);
                                                //replace ',' with '.'
                                                var result_03 = result_02.Replace(',', '.');
                                                //try convert to number
                                                double amount = Convert.ToDouble(result_03);
                                                //get value in grams
                                                double finalAmount = amount * 1000;
                                                //finaly, set the value as string
                                                product.VariantGrams = finalAmount.ToString();
                                            }
                                            catch (Exception)
                                            {
                                                continue;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                product.CustomProductType = "alat";
            }
            return new List<ProductGamaAlati>();
        }


        private static List<CSVModelDefault> CreateListOfCSVModelDefault(List<ProductGamaAlati> products)
        {
            List<CSVModelDefault> listCSVModelDefaults = new List<CSVModelDefault>();
            
            foreach (ProductGamaAlati product in products)
            {
                if (!string.IsNullOrEmpty(product.Title) &&
                    !string.IsNullOrEmpty(product.Vendor) &&
                    product.Vendor.ToUpper().Equals("MAKITA"))
                {
                    CSVModelDefault modelDefault = new CSVModelDefault()
                    {
                        Handle = product.Title,
                        Title = product.Title,
                        Body = product.BodyHtml,
                        Vendor = product.Vendor,
                        CustomProductType = product.CustomProductType,
                        Published = "TRUE",
                        Option1_Name = "Title",
                        Option1_Value = "Default Title",
                        Variant_SKU = product.VariantSKU,
                        Variant_Grams = product.VariantGrams,
                        Variant_Inventory_Qty = "0",
                        Variant_Inventory_Policy = "Deny",
                        Variant_FulFillment_Service = "manual",
                        Variant_Price = product.VariantPrice,
                        Variant_Compare_At_Price = product.VariantCompareAtPrice,
                        Variant_Requires_Shipping = "TRUE",
                        Variant_Taxable = "TRUE",
                        Image_Src = product.ImageSrc,
                        Image_Position = "1",
                        Image_Alt_Text = product.Title,
                        Gift_Card = "FALSE",
                        Variant_Weight_Unit = "kg",                        
                        Status = "active",
                    };
                    listCSVModelDefaults.Add(modelDefault);
                }
            }
            return listCSVModelDefaults;
        }
    }
}

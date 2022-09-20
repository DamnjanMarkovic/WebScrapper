using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models.GamaAlati
{
    public class ProductGamaAlati
    {
        public string Handle { get; set; }
        public string Title { get; set; }
        public string BodyHtml { get; set; }
        public string Vendor { get; set; }

        public string CustomProductType { get; set; }

        public string VariantSKU { get; set; }
        public string VariantGrams { get; set; }

        public string VariantPrice { get; set; }
        public string VariantCompareAtPrice { get; set; }
        public string ImageSrc { get; set; }

        //depends on number of images for that product
        public string ImagePosition { get; set; }
        public string ImageAltText { get; set; }



        //additional props

        public List<string> ListImageSrc { get; set; } = new List<string>();

        public int Id { get; set; }
        public string ProductURL { get; set; }

        //public List<KeyValuePair<string, string>> TechSpecs { get; set; } = new List<KeyValuePair<string, string>>();

    }
}

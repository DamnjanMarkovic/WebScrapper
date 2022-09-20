using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class ProductMakita
    {
        public string Handle { get; set; }
        public string Title { get; set; }


        public int Id { get; set; }
        public string URL { get; set; }
        public string ProductNumber { get; set; }

        public string ImageLink { get; set; }

        public List<KeyValuePair<string, string>> TechSpecs { get; set; } = new List<KeyValuePair<string, string>>();

        public string Type { get; set; } = string.Empty;
    }
}

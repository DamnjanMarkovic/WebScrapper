using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary.Models.GamaAlati
{
	[XmlRoot(ElementName = "urlset")]
	public class UrlSet
    {
		[XmlElement(ElementName = "url")]
		public List<Url> UrlList { get; set; }

	}
}


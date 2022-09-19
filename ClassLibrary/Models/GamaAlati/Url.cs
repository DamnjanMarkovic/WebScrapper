using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary.Models.GamaAlati
{
	//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	//[XmlRoot(Namespace = "ClassLibrary.Models.GamaAlati", ElementName = "url", DataType = "string", IsNullable = true)]
	//[Serializable, XmlRoot("url")]
	//[XmlRoot(ElementName = "url")]



	[XmlRoot(ElementName = "url")]
	public class Url
	{
		[XmlElement(ElementName = "loc")]
		public string Loc { get; set; }
		[XmlElement(ElementName = "lastmod")]
		public string Lastmod { get; set; }
		[XmlElement(ElementName = "changefreq")]
		public string Changefreq { get; set; }
		[XmlElement(ElementName = "priority")]
		public string Priority { get; set; }
		[XmlElement(ElementName = "image_image")]
		public Image_image Image_image { get; set; }
		[XmlElement(ElementName = "PageMap", Namespace = "http://www.google.com/schemas/sitemap-pagemap/1.0")]
		public PageMap PageMap { get; set; }
	}


	[XmlRoot(ElementName = "image_image")]
	public class Image_image
	{
		[XmlElement(ElementName = "image_loc")]
		public string Image_loc { get; set; }
		[XmlElement(ElementName = "image_title")]
		public string Image_title { get; set; }
		[XmlElement(ElementName = "image_caption")]
		public string Image_caption { get; set; }
	}

	[XmlRoot(ElementName = "Attribute", Namespace = "http://www.google.com/schemas/sitemap-pagemap/1.0")]
	public class Attribute
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
	}

	[XmlRoot(ElementName = "DataObject", Namespace = "http://www.google.com/schemas/sitemap-pagemap/1.0")]
	public class DataObject
	{
		[XmlElement(ElementName = "Attribute", Namespace = "http://www.google.com/schemas/sitemap-pagemap/1.0")]
		public List<Attribute> Attribute { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "PageMap", Namespace = "http://www.google.com/schemas/sitemap-pagemap/1.0")]
	public class PageMap
	{
		[XmlElement(ElementName = "DataObject", Namespace = "http://www.google.com/schemas/sitemap-pagemap/1.0")]
		public DataObject DataObject { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}


}

using LINQtoCSV;

namespace ClassLibrary.Models
{
    public class CSVModelDefault
    {
        public string Handle { get; set; }
        public string Title { get; set; }

        [CsvColumn(Name = "Body(HTML)")]
        public string Body { get; set; }
        public string Vendor { get; set; }
        public string Type { get; set; }
        public string Tags { get; set; }
        public string Published { get; set; }
        [CsvColumn(Name = "Option1 Name")]
        public string Option1_Name { get; set; }
        [CsvColumn(Name = "Option1 Value")]
        public string Option1_Value { get; set; }
        [CsvColumn(Name = "Option2 Name")]
        public string Option2_Name { get; set; }
        [CsvColumn(Name = "Option2 Value")]
        public string Option2_Value { get; set; }
        [CsvColumn(Name = "Option3 Name")]
        public string Option3_Name { get; set; }
        [CsvColumn(Name = "Option3 Value")]
        public string Option3_Value { get; set; }
        [CsvColumn(Name = "Variant SKU")]
        public string Variant_SKU { get; set; }
        [CsvColumn(Name = "Variant Grams")]
        public string Variant_Grams { get; set; }
        [CsvColumn(Name = "Variant Inventory Trackery")]
        public string Variant_Inventory_Trackery { get; set; }
        [CsvColumn(Name = "Variant Inventory Qty")]
        public string Variant_Inventory_Qty { get; set; }
        [CsvColumn(Name = "Variant Inventory Policy")]
        public string Variant_Inventory_Policy { get; set; }
        [CsvColumn(Name = "Variant FulFillmen Service")]
        public string Variant_FulFillment_Service { get; set; }
        [CsvColumn(Name = "Variant Price")]
        public string Variant_Price { get; set; }
        [CsvColumn(Name = "Variant Compare At Price")]
        public string Variant_Compare_At_Price { get; set; }
        [CsvColumn(Name = "Variant Requires Shipping")]
        public string Variant_Requires_Shipping { get; set; }
        [CsvColumn(Name = "Variant Taxable")]
        public bool Variant_Taxable { get; set; }
        [CsvColumn(Name = "Variant Barcode")]
        public string Variant_Barcode { get; set; }
        [CsvColumn(Name = "Image Src")]
        public string Image_Src { get; set; }
        [CsvColumn(Name = "Image Position")]
        public string Image_Position { get; set; }
        [CsvColumn(Name = "Image Alt Text")]
        public string Image_Alt_Text { get; set; }
        [CsvColumn(Name = "Gift Card")]
        public string Gift_Card { get; set; }
        [CsvColumn(Name = "Variant Image")]
        public string Variant_Image { get; set; }
        [CsvColumn(Name = "Variant Weight Unit")]
        public string Variant_Weight_Unit { get; set; }
        [CsvColumn(Name = "Variant Tax Code")]
        public string Variant_Tax_Code { get; set; }
        [CsvColumn(Name = "Cost per item")]
        public string Cost_per_item { get; set; }

    }
}

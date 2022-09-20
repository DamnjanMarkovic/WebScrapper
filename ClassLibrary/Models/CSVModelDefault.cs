
using CsvHelper.Configuration.Attributes;
using LINQtoCSV;
using SoftCircuits.CsvParser;
using System.Runtime.Serialization;

namespace ClassLibrary.Models
{
    public class CSVModelDefault
    {

    [CsvColumn(FieldIndex = 1, Name = "Handle")]
    public string Handle { get; set; }

    [CsvColumn(FieldIndex = 2, Name = "Title")]
    public string Title { get; set; }

    [CsvColumn(FieldIndex = 3, Name = "Body (HTML)")]
    public string Body { get; set; }

    [CsvColumn(FieldIndex = 4, Name = "Vendor")]
    public string Vendor { get; set; }

    [CsvColumn(FieldIndex = 5, Name = "Standardized Product Type")]
    public string StandardizedProductType { get; set; }

    [CsvColumn(FieldIndex = 6, Name = "Custom Product Type")]
    public string CustomProductType { get; set; }

    [CsvColumn(FieldIndex = 7, Name = "Tags")]
    public string Tags { get; set; }

    [CsvColumn(FieldIndex = 8, Name = "Published")]
    public string Published { get; set; }        

    [CsvColumn(FieldIndex = 9, Name = "Option1 Name")]
    public string Option1_Name { get; set; }

    [CsvColumn(FieldIndex = 10, Name = "Option1 Value")]
    public string Option1_Value { get; set; }
    [CsvColumn(FieldIndex = 11, Name = "Option2 Name")]
    public string Option2_Name { get; set; }
    [CsvColumn(FieldIndex = 12, Name = "Option2 Value")]
    public string Option2_Value { get; set; }
    [CsvColumn(FieldIndex = 13, Name = "Option3 Name")]
    public string Option3_Name { get; set; }
    [CsvColumn(FieldIndex = 14, Name = "Option3 Value")]
    public string Option3_Value { get; set; }

    [CsvColumn(FieldIndex = 15, Name = "Variant SKU")]
    public string Variant_SKU { get; set; }

    [CsvColumn(FieldIndex = 16, Name = "Variant Grams")]
    public string Variant_Grams { get; set; }

    [CsvColumn(FieldIndex = 17, Name = "Variant Inventory Tracker")]
    public string Variant_Inventory_Tracker { get; set; }

    [CsvColumn(FieldIndex = 18, Name = "Variant Inventory Qty")]
    public string Variant_Inventory_Qty { get; set; }

    [CsvColumn(FieldIndex = 19, Name = "Variant Inventory Policy")]
    public string Variant_Inventory_Policy { get; set; }
    [CsvColumn(FieldIndex = 20, Name = "Variant FulFillmen Service")]
    public string Variant_FulFillment_Service { get; set; }
    [CsvColumn(FieldIndex = 21, Name = "Variant Price")]
    public string Variant_Price { get; set; }
    [CsvColumn(FieldIndex = 22, Name = "Variant Compare At Price")]
    public string Variant_Compare_At_Price { get; set; }

    [CsvColumn(FieldIndex = 23, Name = "Variant Requires Shipping")]
    public string Variant_Requires_Shipping { get; set; }
    [CsvColumn(FieldIndex = 24, Name = "Variant Taxable")]
    public string Variant_Taxable { get; set; }
    [CsvColumn(FieldIndex = 25, Name = "Variant Barcode")]
    public string Variant_Barcode { get; set; }

    [CsvColumn(FieldIndex = 26, Name = "Image Src")]
    public string Image_Src { get; set; }



    [CsvColumn(FieldIndex = 27, Name = "Image Position")]
    public string Image_Position { get; set; }
    [CsvColumn(FieldIndex = 28, Name = "Image Alt Text")]
    public string Image_Alt_Text { get; set; }
    [CsvColumn(FieldIndex = 29, Name = "Gift Card")]
    public string Gift_Card { get; set; }


    [CsvColumn(FieldIndex = 30, Name = "SEO Title")]
    public string SEOTitle { get; set; }

    [CsvColumn(FieldIndex = 31, Name = "SEO Description")]
    public string SEODescription { get; set; }

    [CsvColumn(FieldIndex = 32, Name = "Google Shopping / Google Product Category")]
    public string GoogleShoppingGoogleProductCategory { get; set; }


    [CsvColumn(FieldIndex = 33, Name = "Google Shopping / Gender")]
    public string GoogleShoppingGender { get; set; }


    [CsvColumn(FieldIndex = 34, Name = "Google Shopping / Age Group")]
    public string GoogleShoppingAgeGroup { get; set; }


    [CsvColumn(FieldIndex = 35, Name = "Google Shopping / MPN")]
    public string GoogleShoppingMPN { get; set; }

    [CsvColumn(FieldIndex = 36, Name = "Google Shopping / AdWords Grouping")]
    public string GoogleShoppingAdWordsGrouping { get; set; }

    [CsvColumn(FieldIndex = 37, Name = "Google Shopping / AdWords Labels")]
    public string GoogleShoppingAdWordsLabels { get; set; }

    [CsvColumn(FieldIndex = 38, Name = "Google Shopping / Condition")]
    public string GoogleShoppingCondition { get; set; }


    [CsvColumn(FieldIndex = 39, Name = "Google Shopping / Custom Product")]
    public string GoogleShoppingCustomProduct { get; set; }


    [CsvColumn(FieldIndex = 40, Name = "Google Shopping / Custom Label 0")]
    public string GoogleShoppingCustomLabel0 { get; set; }


    [CsvColumn(FieldIndex = 41, Name = "Google Shopping / Custom Label 1")]
    public string GoogleShoppingCustomLabel1 { get; set; }


    [CsvColumn(FieldIndex = 42, Name = "Google Shopping / Custom Label 2")]
    public string GoogleShoppingCustomLabel2 { get; set; }


    [CsvColumn(FieldIndex = 43, Name = "Google Shopping / Custom Label 3")]
    public string GoogleShoppingCustomLabel3 { get; set; }


    [CsvColumn(FieldIndex = 44, Name = "Google Shopping / Custom Label 42")]
    public string GoogleShoppingCustomLabel4 { get; set; }

    [CsvColumn(FieldIndex = 45, Name = "Variant Image")]
    public string Variant_Image { get; set; }
    [CsvColumn(FieldIndex = 46, Name = "Variant Weight Unit")]
    public string Variant_Weight_Unit { get; set; }
    [CsvColumn(FieldIndex = 47, Name = "Variant Tax Code")]
    public string Variant_Tax_Code { get; set; }
    [CsvColumn(FieldIndex = 48, Name = "Cost per item")]
    public string Cost_per_item { get; set; }

    [CsvColumn(FieldIndex = 49, Name = "Status")]
    public string Status { get; set; }





    }
}


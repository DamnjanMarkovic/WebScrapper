
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



#region Old
/*

[ColumnMap(Name = "Handle")]
public string Handle { get; set; }

[ColumnMap(Name = "Title")]
public string Title { get; set; }

[ColumnMap(Name = "Body (HTML)")]
public string Body { get; set; }

[ColumnMap(Name = "Vendor")]
public string Vendor { get; set; }

[ColumnMap(Name = "Standardized Product Type")]
public string StandardizedProductType { get; set; }

[ColumnMap(Name = "Custom Product Type")]
public string CustomProductType { get; set; }

[ColumnMap(Name = "Tags")]
public string Tags { get; set; }

[ColumnMap(Name = "Published")]
public string Published { get; set; }

[ColumnMap(Name = "Option1 Name")]
public string Option1_Name { get; set; }

[ColumnMap(Name = "Option1 Value")]
public string Option1_Value { get; set; }
[ColumnMap(Name = "Option2 Name")]
public string Option2_Name { get; set; }
[ColumnMap(Name = "Option2 Value")]
public string Option2_Value { get; set; }
[ColumnMap(Name = "Option3 Name")]
public string Option3_Name { get; set; }
[ColumnMap(Name = "Option3 Value")]
public string Option3_Value { get; set; }

[ColumnMap(Name = "Variant SKU")]
public string Variant_SKU { get; set; }

[ColumnMap(Name = "Variant Grams")]
public string Variant_Grams { get; set; }



[ColumnMap(Name = "Variant Inventory Tracker")]
public string Variant_Inventory_Tracker { get; set; }


[ColumnMap(Name = "Variant Inventory Qty")]
public string Variant_Inventory_Qty { get; set; }


[ColumnMap(Name = "Variant Inventory Policy")]
public string Variant_Inventory_Policy { get; set; }
[ColumnMap(Name = "Variant FulFillmen Service")]
public string Variant_FulFillment_Service { get; set; }
[ColumnMap(Name = "Variant Price")]
public string Variant_Price { get; set; }
[ColumnMap(Name = "Variant Compare At Price")]
public string Variant_Compare_At_Price { get; set; }



[ColumnMap(Name = "Variant Requires Shipping")]
public string Variant_Requires_Shipping { get; set; }
[ColumnMap(Name = "Variant Taxable")]
public string Variant_Taxable { get; set; }
[ColumnMap(Name = "Variant Barcode")]
public string Variant_Barcode { get; set; }

[ColumnMap(Name = "Image Src")]
public string Image_Src { get; set; }



[ColumnMap(Name = "Image Position")]
public string Image_Position { get; set; }
[ColumnMap(Name = "Image Alt Text")]
public string Image_Alt_Text { get; set; }
[ColumnMap(Name = "Gift Card")]
public string Gift_Card { get; set; }


[ColumnMap(Name = "SEO Title")]
public string SEOTitle { get; set; }

[ColumnMap(Name = "SEO Description")]
public string SEODescription { get; set; }

[ColumnMap(Name = "Google Shopping / Google Product Category")]
public string GoogleShoppingGoogleProductCategory { get; set; }


[ColumnMap(Name = "Google Shopping / Gender")]
public string GoogleShoppingGender { get; set; }


[ColumnMap(Name = "Google Shopping / Age Group")]
public string GoogleShoppingAgeGroup { get; set; }


[ColumnMap(Name = "Google Shopping / MPN")]
public string GoogleShoppingMPN { get; set; }

[ColumnMap(Name = "Google Shopping / AdWords Grouping")]
public string GoogleShoppingAdWordsGrouping { get; set; }

[ColumnMap(Name = "Google Shopping / AdWords Labels")]
public string GoogleShoppingAdWordsLabels { get; set; }

[ColumnMap(Name = "Google Shopping / Condition")]
public string GoogleShoppingCondition { get; set; }


[ColumnMap(Name = "Google Shopping / Custom Product")]
public string GoogleShoppingCustomProduct { get; set; }


[ColumnMap(Name = "Google Shopping / Custom Label 0")]
public string GoogleShoppingCustomLabel0 { get; set; }


[ColumnMap(Name = "Google Shopping / Custom Label 1")]
public string GoogleShoppingCustomLabel1 { get; set; }


[ColumnMap(Name = "Google Shopping / Custom Label 2")]
public string GoogleShoppingCustomLabel2 { get; set; }


[ColumnMap(Name = "Google Shopping / Custom Label 3")]
public string GoogleShoppingCustomLabel3 { get; set; }


[ColumnMap(Name = "Google Shopping / Custom Label 42")]
public string GoogleShoppingCustomLabel4 { get; set; }

[ColumnMap(Name = "Variant Image")]
public string Variant_Image { get; set; }
[ColumnMap(Name = "Variant Weight Unit")]
public string Variant_Weight_Unit { get; set; }
[ColumnMap(Name = "Variant Tax Code")]
public string Variant_Tax_Code { get; set; }
[ColumnMap(Name = "Cost per item")]
public string Cost_per_item { get; set; }

[ColumnMap(Name = "Status")]
public string Status { get; set; }

*/
/*
[Name("Handle")]
public string Handle { get; set; }

[Name("Title")]
public string Title { get; set; }

[Name("Body (HTML)")]
public string Body { get; set; }

[Name("Vendor")]
public string Vendor { get; set; }

[Name("Standardized Product Type")]
public string StandardizedProductType { get; set; }

[Name("Custom Product Type")]
public string CustomProductType { get; set; }

[Name("Tags")]
public string Tags { get; set; }

[Name("Published")]
public string Published { get; set; }

[Name("Option1 Name")]
public string Option1_Name { get; set; }

[Name("Option1 Value")]
public string Option1_Value { get; set; }
[Name("Option2 Name")]
public string Option2_Name { get; set; }
[Name("Option2 Value")]
public string Option2_Value { get; set; }
[Name("Option3 Name")]
public string Option3_Name { get; set; }
[Name("Option3 Value")]
public string Option3_Value { get; set; }

[Name("Variant SKU")]
public string Variant_SKU { get; set; }

[Name("Variant Grams")]
public string Variant_Grams { get; set; }

[Name("Variant Inventory Tracker")]
public string Variant_Inventory_Tracker { get; set; }
[Name("Variant Inventory Qty")]
public string Variant_Inventory_Qty { get; set; }
[Name("Variant Inventory Policy")]
public string Variant_Inventory_Policy { get; set; }
[Name("Variant FulFillmen Service")]
public string Variant_FulFillment_Service { get; set; }
[Name("Variant Price")]
public string Variant_Price { get; set; }
[Name("Variant Compare At Price")]
public string Variant_Compare_At_Price { get; set; }
[Name("Variant Requires Shipping")]
public string Variant_Requires_Shipping { get; set; }
[Name("Variant Taxable")]
public bool Variant_Taxable { get; set; }
[Name("Variant Barcode")]
public string Variant_Barcode { get; set; }
[Name("Image Src")]
public string Image_Src { get; set; }
[Name("Image Position")]
public string Image_Position { get; set; }
[Name("Image Alt Text")]
public string Image_Alt_Text { get; set; }
[Name("Gift Card")]
public string Gift_Card { get; set; }

[Name("SEO Title")]
public string SEOTitle { get; set; }

[Name("SEO Description")]
public string SEODescription { get; set; }

[Name("Google Shopping / Google Product Category")]
public string GoogleShoppingGoogleProductCategory { get; set; }


[Name("Google Shopping / Gender")]
public string GoogleShoppingGender { get; set; }


[Name("Google Shopping / Age Group")]
public string GoogleShoppingAgeGroup { get; set; }


[Name("Google Shopping / MPN")]
public string GoogleShoppingMPN { get; set; }

[Name("Google Shopping / AdWords Grouping")]
public string GoogleShoppingAdWordsGrouping { get; set; }

[Name("Google Shopping / AdWords Labels")]
public string GoogleShoppingAdWordsLabels { get; set; }

[Name("Google Shopping / Condition")]
public string GoogleShoppingCondition { get; set; }


[Name("Google Shopping / Custom Product")]
public string GoogleShoppingCustomProduct { get; set; }


[Name("Google Shopping / Custom Label 0")]
public string GoogleShoppingCustomLabel0 { get; set; }


[Name("Google Shopping / Custom Label 1")]
public string GoogleShoppingCustomLabel1 { get; set; }


[Name("Google Shopping / Custom Label 2")]
public string GoogleShoppingCustomLabel2 { get; set; }


[Name("Google Shopping / Custom Label 3")]
public string GoogleShoppingCustomLabel3 { get; set; }


[Name("Google Shopping / Custom Label 42")]
public string GoogleShoppingCustomLabel4 { get; set; }

[Name("Variant Image")]
public string Variant_Image { get; set; }
[Name("Variant Weight Unit")]
public string Variant_Weight_Unit { get; set; }
[Name("Variant Tax Code")]
public string Variant_Tax_Code { get; set; }
[Name("Cost per item")]
public string Cost_per_item { get; set; }

[Name("Status")]
public string Status { get; set; }

*/
/*
[DataMember(Order = 0, Name = "Handle")]
public string Handle { get; set; }

[DataMember(Order = 1, Name = "Title")]
public string Title { get; set; }

[DataMember(Order = 2, Name = "Body (HTML)")]
public string Body { get; set; }

[DataMember(Order = 3, Name = "Vendor")]
public string Vendor { get; set; }

[DataMember(Order = 4, Name = "Standardized Product Type")]
public string StandardizedProductType { get; set; }

[DataMember(Order = 5, Name = "Custom Product Type")]
public string CustomProductType { get; set; }

[DataMember(Order = 6, Name = "Tags")]
public string Tags { get; set; }

[DataMember(Order = 7, Name = "Published")]
public string Published { get; set; }

[DataMember(Order = 8, Name = "Option1 Name")]
public string Option1_Name { get; set; }

[DataMember(Order = 9, Name = "Option1 Value")]
public string Option1_Value { get; set; }
[DataMember(Order = 10, Name = "Option2 Name")]
public string Option2_Name { get; set; }
[DataMember(Order = 11, Name = "Option2 Value")]
public string Option2_Value { get; set; }
[DataMember(Order = 12, Name = "Option3 Name")]
public string Option3_Name { get; set; }
[DataMember(Order = 13, Name = "Option3 Value")]
public string Option3_Value { get; set; }

[DataMember(Order = 14, Name = "Variant SKU")]
public string Variant_SKU { get; set; }

[DataMember(Order = 15, Name = "Variant Grams")]
public string Variant_Grams { get; set; }

[DataMember(Order = 16, Name = "Variant Inventory Tracker")]
public string Variant_Inventory_Tracker { get; set; }
[DataMember(Order = 17, Name = "Variant Inventory Qty")]
public string Variant_Inventory_Qty { get; set; }
[DataMember(Order = 18, Name = "Variant Inventory Policy")]
public string Variant_Inventory_Policy { get; set; }
[DataMember(Order = 19, Name = "Variant FulFillmen Service")]
public string Variant_FulFillment_Service { get; set; }
[DataMember(Order = 20, Name = "Variant Price")]
public string Variant_Price { get; set; }
[DataMember(Order = 21, Name = "Variant Compare At Price")]
public string Variant_Compare_At_Price { get; set; }
[DataMember(Order = 22, Name = "Variant Requires Shipping")]
public string Variant_Requires_Shipping { get; set; }
[DataMember(Order = 23, Name = "Variant Taxable")]
public bool Variant_Taxable { get; set; }
[DataMember(Order = 24, Name = "Variant Barcode")]
public string Variant_Barcode { get; set; }
[DataMember(Order = 25, Name = "Image Src")]
public string Image_Src { get; set; }
[DataMember(Order = 26, Name = "Image Position")]
public string Image_Position { get; set; }
[DataMember(Order = 27, Name = "Image Alt Text")]
public string Image_Alt_Text { get; set; }
[DataMember(Order = 28, Name = "Gift Card")]
public string Gift_Card { get; set; }

[DataMember(Order = 29, Name = "SEO Title")]
public string SEOTitle { get; set; }

[DataMember(Order = 30, Name = "SEO Description")]
public string SEODescription { get; set; }

[DataMember(Order = 31, Name = "Google Shopping / Google Product Category")]
public string GoogleShoppingGoogleProductCategory { get; set; }


[DataMember(Order = 32, Name = "Google Shopping / Gender")]
public string GoogleShoppingGender { get; set; }


[DataMember(Order = 33, Name = "Google Shopping / Age Group")]
public string GoogleShoppingAgeGroup { get; set; }


[DataMember(Order = 34, Name = "Google Shopping / MPN")]
public string GoogleShoppingMPN { get; set; }

[DataMember(Order = 35, Name = "Google Shopping / AdWords Grouping")]
public string GoogleShoppingAdWordsGrouping { get; set; }

[DataMember(Order = 36, Name = "Google Shopping / AdWords Labels")]
public string GoogleShoppingAdWordsLabels { get; set; }

[DataMember(Order = 37, Name = "Google Shopping / Condition")]
public string GoogleShoppingCondition { get; set; }


[DataMember(Order = 38, Name = "Google Shopping / Custom Product")]
public string GoogleShoppingCustomProduct { get; set; }


[DataMember(Order = 39, Name = "Google Shopping / Custom Label 0")]
public string GoogleShoppingCustomLabel0 { get; set; }


[DataMember(Order = 40, Name = "Google Shopping / Custom Label 1")]
public string GoogleShoppingCustomLabel1 { get; set; }


[DataMember(Order = 41, Name = "Google Shopping / Custom Label 2")]
public string GoogleShoppingCustomLabel2 { get; set; }


[DataMember(Order = 42, Name = "Google Shopping / Custom Label 3")]
public string GoogleShoppingCustomLabel3 { get; set; }


[DataMember(Order = 43, Name = "Google Shopping / Custom Label 42")]
public string GoogleShoppingCustomLabel4 { get; set; }

[DataMember(Order = 44, Name = "Variant Image")]
public string Variant_Image { get; set; }
[DataMember(Order = 45, Name = "Variant Weight Unit")]
public string Variant_Weight_Unit { get; set; }
[DataMember(Order = 46, Name = "Variant Tax Code")]
public string Variant_Tax_Code { get; set; }
[DataMember(Order = 47, Name = "Cost per item")]
public string Cost_per_item { get; set; }

[DataMember(Order = 48, Name = "Status")]
public string Status { get; set; }
*/
/*
public class CSVModelDefault
{
    [CsvColumn(Name = "Handle")]
    public string Handle { get; set; }

    [CsvColumn(Name = "Title")]
    public string Title { get; set; }

    [CsvColumn(Name = "Body (HTML)")]
    public string Body { get; set; }

    [CsvColumn(Name = "Vendor")]
    public string Vendor { get; set; }

    [CsvColumn(Name = "Standardized Product Type")]
    public string StandardizedProductType { get; set; }

    [CsvColumn(Name = "Custom Product Type")]
    public string CustomProductType { get; set; }

    [CsvColumn(Name = "Tags")]
    public string Tags { get; set; }

    [CsvColumn(Name = "Published")]
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



    [CsvColumn(Name = "Variant Inventory Tracker")]
    public string Variant_Inventory_Tracker { get; set; }


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
    public string Variant_Taxable { get; set; }
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


    [CsvColumn(Name = "SEO Title")]
    public string SEOTitle { get; set; }

    [CsvColumn(Name = "SEO Description")]
    public string SEODescription { get; set; }

    [CsvColumn(Name = "Google Shopping / Google Product Category")]
    public string GoogleShoppingGoogleProductCategory { get; set; }


    [CsvColumn(Name = "Google Shopping / Gender")]
    public string GoogleShoppingGender { get; set; }


    [CsvColumn(Name = "Google Shopping / Age Group")]
    public string GoogleShoppingAgeGroup { get; set; }


    [CsvColumn(Name = "Google Shopping / MPN")]
    public string GoogleShoppingMPN { get; set; }

    [CsvColumn(Name = "Google Shopping / AdWords Grouping")]
    public string GoogleShoppingAdWordsGrouping { get; set; }

    [CsvColumn(Name = "Google Shopping / AdWords Labels")]
    public string GoogleShoppingAdWordsLabels { get; set; }

    [CsvColumn(Name = "Google Shopping / Condition")]
    public string GoogleShoppingCondition { get; set; }


    [CsvColumn(Name = "Google Shopping / Custom Product")]
    public string GoogleShoppingCustomProduct { get; set; }


    [CsvColumn(Name = "Google Shopping / Custom Label 0")]
    public string GoogleShoppingCustomLabel0 { get; set; }


    [CsvColumn(Name = "Google Shopping / Custom Label 1")]
    public string GoogleShoppingCustomLabel1 { get; set; }


    [CsvColumn(Name = "Google Shopping / Custom Label 2")]
    public string GoogleShoppingCustomLabel2 { get; set; }


    [CsvColumn(Name = "Google Shopping / Custom Label 3")]
    public string GoogleShoppingCustomLabel3 { get; set; }


    [CsvColumn(Name = "Google Shopping / Custom Label 42")]
    public string GoogleShoppingCustomLabel4 { get; set; }

    [CsvColumn(Name = "Variant Image")]
    public string Variant_Image { get; set; }
    [CsvColumn(Name = "Variant Weight Unit")]
    public string Variant_Weight_Unit { get; set; }
    [CsvColumn(Name = "Variant Tax Code")]
    public string Variant_Tax_Code { get; set; }
    [CsvColumn(Name = "Cost per item")]
    public string Cost_per_item { get; set; }

    [CsvColumn(Name = "Status")]
    public string Status { get; set; }

}
*/

#endregion




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCart.Model
{
    public struct Item_Package
    {
        public string package_value { get; set; }
        public string package_name { get; set; }
    }
    class Item_FullGson
    {
        public Boolean success { get; set; }
        public string message { get; set; }
        public List<Item> itemsList { get; set; }
    }

    public class Item
    {
        public string itemID { get; set; }
        public string name { get; set; }

        public List<Item_Package> item_Packages = new List<Item_Package>();

        //new
        public float salesPrice { get; set; }
        public float minSalesPrice { get; set; }
        public bool isErpItem { get; set; }
        public bool isStockItem { get; set; }
        public bool isStopped { get; set; }
        public float costPrice { get; set; }
        public float availableStock { get; set; }
        public string imgURL_big { get; set; }
        public string imgURL_small { get; set; }

        /*21/04/2019*/
        public float vat { get; set; }
        public float defaultQTY { get; set; }
        public bool isService { get; set; }
        public bool canChangePrice { get; set; }
        public String dataArea { get; set; }
        public string sqlSelect_SecondSelectionForAnItemList { get; set; }
        public bool requiresSecondarySelection { get; set; }

         
        /*21/04/2019*/
    }
    

    //public class Item
    //{
    //    public string ItemID { get; set; }
    //    public string Name { get; set; }
    //    public string img1 { get; set; }
    //    public string img2 { get; set; }

    //}

    //public class JSONConverter_items
    //{
    //    public bool Success { get; set; }
    //    public string Message { get; set; }
    //    public List<Item> ItemsList { get; set; }
    //}

}

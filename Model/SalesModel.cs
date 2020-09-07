using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCart.Model
{
    [Serializable]
    public class SalesTable
    {
        public SalesTable() {
            salesLines = new List<SalesLine>();

            
        }

        public void calcTotalAmount()
        {
            float total = 0;
            foreach (SalesLine sl in salesLines)
                total += sl.lineAmount;

            totalAmount = total;
        }


        public string user_notes { get; set; }
        public int payment_status { get; set; }
        public string payment_result_message { get; set; }
        public string pdf_invoice_fileName { get; set; }
        public string pdf_invoice_baseURL { get; set; }
        public string pdf_invoice_url { get; set; }
       // public Shift shift { get; set; }
        //public int shiftID { get; set; }

        /*need to be saved in database*/
        public String headerTitlePrintingDate { get; set; }
        public String AccountantNotes { get; set; }
        public String atmNumber { get; set; }
        public String str_TK_InvoiceDate { get; set; }
        public String username_created_by { get; set; }
        public String username_edit_by { get; set; }
        public String salesID { get; set; }
        public int printingCount { get; set; }

        //for database only 
        public string id { get; set; }
        public Boolean isInvoiced { get; set; }
        public Boolean isCanceled { get; set; }
        public Boolean isIntegrated { get; set; }
        public Boolean isUpdatedAfterIntegration { get; set; }
        public Boolean needToSendSMS { get; set; }
        public Boolean isSentSMS { get; set; }

        //  public IFormFile ordImage { get; set; }
        public String customerNotes { get; set; }
        public String source { get; set; }

        public String fileByteArrayToString { get; set; }
        public String file_extention_image { get; set; }
        public String file_name_image { get; set; }
        public String file_ImageURL { get; set; }
        public DateTime tkInvoiceDateOnly { get; set; }
        public int tkInvoiceDate_year { get; set; }
        public int tkInvoiceDate_month { get; set; }
        public int tkInvoiceDate_day { get; set; }
        public List<SalesLine> salesLines { get; set; }

        //pending
        public float totalAmount { get; set; }
        public float totalAmountWithVAT { get; set; }
        public String customer_ID { get; set; }
        public String note { get; set; }
        public String salesTakerPersonnelNumber { get; set; }
        public String payment { get; set; }
        public String imageFileName { get; set; }
        public String imageFile_FullPath { get; set; }
        public String customerName { get; set; }
        public String customerMobile { get; set; }
        public String customerEmail { get; set; }
        public String customerAccountNumber { get; set; }
        public String custGroup { get; set; }
        public String inventSite { get; set; }
        public String inventwareHouse { get; set; }
        public String App_Version { get; set; }
        public int userID_CreatedBy { get; set; }

        /*
        var  : ArrayList<SalesLine>? = null
        override fun toString(): String {
            return salesID
        }*/
    }
    class SalesTable_FullGson
    {
        public Boolean success { get; set; }
        public string message { get; set; }
        public List<SalesTable> SalesTableList { get; set; }
    }
    //simple for showing the shift
    // [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class SalesTableSimple
    {
       // public Shift shift { get; set; }
        public int shiftID { get; set; }
        public String AccountantNotes { get; set; }
        public String salesID { get; set; }
        //for database only 
        public string id { get; set; }
        public Boolean isInvoiced { get; set; }
        public Boolean isCanceled { get; set; }
        public Boolean isIntegrated { get; set; }
        public Boolean isUpdatedAfterIntegration { get; set; }
        public String str_TK_InvoiceDate { get; set; }
        public String customerName { get; set; }
        public DateTime tkInvoiceDateOnly { get; set; }
        public int tkInvoiceDate_year { get; set; }
        public int tkInvoiceDate_month { get; set; }
        public int tkInvoiceDate_day { get; set; }

        //pending
        public float totalAmount { get; set; }
        public float totalAmountWithVAT { get; set; }
        public String username_created_by { get; set; }


    }
    class SalesTableSimple_FullGson
    {
        public Boolean success { get; set; }
        public string message { get; set; }
        public List<SalesTableSimple> SalesTableList { get; set; }
    }
    public class SalesLine
    {
        public String salesID { get; set; }
        public float qty { get; set; }
        public float salesPrice { get; set; }
        public float lineAmount { get; set; }

        public Item item { get; set; }
        public string Beneficiary_id { get; set; }
       // public Beneficiary beneficiary { get; set; }

        //for database only 
        public string RefID { get; set; }

        public float lineVAT_percent { get; set; }
        public float lineVAT_Amount { get; set; }
        public float lineAmount_WithVAT { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.ViewModel
{
    public class PrinterListModel
    {
        public string UserCode { get; set; }
        public string Brand { get; set; }
        public string IP { get; set; }
        public string BasicFeatures { get; set; }
        public string NetworkName { get; set; }
        public string Location { get; set; }
        public string InventoryNumber { get; set; }
        public string InvoiceContract { get; set; }
        public string Status { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string SerialNumber { get; set; }
    }
}
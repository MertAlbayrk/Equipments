using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.ViewModel
{
    public class NotebookListModel
    {
        public string UserCode { get; set; }
        public string Users { get; set; }
        public string Vendor { get; set; }
        public string SerialNum { get; set; }
        public string PcName { get; set; }
        public string WifiMac { get; set; }
        public string EthMac { get; set; }
        public string Specification { get; set; }
        public string WindowsCdKey { get; set; }
        public string SSD { get; set; }
        public string SSDSerial { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string OldUser { get; set; }

    }
}
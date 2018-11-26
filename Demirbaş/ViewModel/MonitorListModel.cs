using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.ViewModel
{
    public class MonitorListModel
    {
        public string UserCode { get; set; }
        public string Demirbas { get; set; }
        public string Brand { get; set; }
        public string Users { get; set; }
        public string BasicFeatures { get; set; }
        public string Place { get; set; }
        public string Status { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string OldUser { get; set; }
        public string SerialNumber { get; set; }
    }
}
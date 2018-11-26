using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.ViewModel
{
    public class MobileListModel
    {
        public string UserCode { get; set; }
        public string Demirbas { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Number { get; set; }
        public string SerialNumber { get; set; }
        public string IMEI { get; set; }
        public string MAC { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string OldUser { get; set; }
    }
}
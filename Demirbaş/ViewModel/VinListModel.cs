using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.ViewModel
{
    public class VinListModel
    {
        public string UserCode { get; set; }
        public string Users { get; set; }
        public string Operator { get; set; }
        public string SerialNumber { get; set; }
        public string IMEI { get; set; }
        public string DeviceName { get; set; }
        public string SımCardNo { get; set; }
        public string PIN1 { get; set; }
        public string PIN2 { get; set; }
        public string PUK1 { get; set; }
        public string PUK2 { get; set; }
        public string Special { get; set; }
        public string Status { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string OldUser { get; set; }
    }
}
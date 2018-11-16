using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.Classes
{
    public class DBselection
    {
        public class Mobile
        {
            public string UserCode { get; set; }
            public string Demirbas { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Number { get; set; }
            public string SeriALnUMBER { get; set; }
            public string IMEI { get; set; }
            public string MAC { get; set; }
            public DateTime PurchaseDate { get; set; }
            public string InvoiceNumber { get; set; }
            public string OlüdUser { get; set; }

        }
        public class Notebooks
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
            public DateTime PurchaseDate { get; set; }
            public string InvoiceNumber { get; set; }
            public string OldUser { get; set; }


        }
        public class Others
        {
            public string UserCode { get; set; }
            public string Users { get; set; }
            public string Brand { get; set; }
            public string SerialNumber { get; set; }
            public string Features { get; set; }
            public string Location { get; set; }
            public string Specification { get; set; }
            public DateTime PurchaseDate { get; set; }
            public string InvoiceNumber { get; set; }
            public string OldUser { get; set; }
        }
        public class Software
        {
            public string UserCode { get; set; }
            public string Name { get; set; }
            public string Status { get; set; }
            public DateTime PurchaseteDate { get; set; }

        }
        public class Servers
        {
            public string UserCode { get; set; }
            public string ServerName { get; set; }
            public string Serialnumber { get; set; }
            public string Location { get; set; }

        }
        public class Vınn
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
            public DateTime PurchaseDate { get; set; }
            public string OldUser { get; set; }

        }
        public class Printers
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
            public string PurchaseDate { get; set; }

        }
        public class Monitors
        {
            public string UserCode { get; set; }
            public string Demirbas { get; set; }
            public string Brand { get; set; }
            public string Users { get; set; }
            public string BasicFeatures { get; set; }
            public string Place { get; set; }
            public string Status { get; set; }
            public DateTime PurchaseDate { get; set; }
            public string InvoiceNumber { get; set; }
            public string OldUser { get; set; }
        }

        }
}
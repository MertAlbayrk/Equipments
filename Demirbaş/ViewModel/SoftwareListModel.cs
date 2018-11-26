using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.ViewModel
{
    public class SoftwareListModel
    {
        public string UserCode { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? PurchaseteDate { get; set; }
    }
}
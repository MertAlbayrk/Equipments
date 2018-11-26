using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace Demirbaş.ViewModel
{
    public class MobileModel
    {
        public string Users { get; set; }
        public string SerialNumber { get; set; }
        public int? Page { get; set; }
        public IPagedList<MobileListModel> MobileSearch { get; set; }
    }
}
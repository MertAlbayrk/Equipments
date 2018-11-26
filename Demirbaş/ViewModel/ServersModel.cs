using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.ViewModel
{
    public class ServersModel
    {
        public string SerialNumber { get; set; }
        public int? Page { get; set; }
        public IPagedList<ServersListModel> ServersSearch { get; set; }
    }
}
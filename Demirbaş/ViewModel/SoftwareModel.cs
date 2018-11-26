using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace Demirbaş.ViewModel
{
    public class SoftwareModel
    {

        public string Name { get; set; }
        public int? Page { get; set; }
        public IPagedList<SoftwareListModel> softwareSearch { get; set; }
    }
}
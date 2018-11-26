using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demirbaş.ViewModel
{
    public class NotebookModel
    {
        public string Users { get; set; }
        public string SerialNumber { get; set; }
        public int? Page { get; set; }
        public IPagedList<NotebookListModel> NotebookSearch { get; set; }
    }
}
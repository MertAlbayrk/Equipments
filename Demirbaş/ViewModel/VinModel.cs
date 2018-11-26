using PagedList;

namespace Demirbaş.ViewModel
{
    public class VinModel
    {
        public string Users { get; set; }
        public string SerialNumber { get; set; }
        public int? Page { get; set; }
        public IPagedList<VinListModel> VinSearch { get; set; }
    }
}
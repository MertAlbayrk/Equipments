using PagedList;
namespace Demirbaş.ViewModel
{
    public class MonitorModel
    {
        public string Users { get; set; }
        public string SerialNumber { get; set; }
        public int? Page { get; set; }
        public IPagedList<MonitorListModel> MonitorSearch { get; set; }

    }
}
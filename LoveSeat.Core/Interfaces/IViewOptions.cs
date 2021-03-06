using System.Collections.Generic;

namespace LoveSeat.Core.Interfaces
{
    public interface IViewOptions
    {
        IKeyOptions Key { get; set; }
        IEnumerable<IKeyOptions> Keys { get; set; }
        IKeyOptions StartKey { get; set; }
        IKeyOptions EndKey { get; set; }

        int? Limit { get; set; }
        int? Skip { get; set; }
        bool? Reduce { get; set; }
        bool? Group { get; set; }
        bool? IncludeDocs { get; set; }
        bool? InclusiveEnd { get; set; }
        int? GroupLevel { get; set; }
        bool? Descending { get; set; }
        bool? Stale { get; set; }
        string StaleOption { get; set; }
        string Etag { get; set; }
        string StartKeyDocId { get; set; }
        string EndKeyDocId { get; set; }
        string ToString();
    }
}
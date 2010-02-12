using System.Collections.Generic;
using MvcApplication2.Domain.Entities;

namespace MvcApplication2.Models
{
    public class SearchResultViewModel
    {
        public string Query { get; set; }
        public IEnumerable<JobAd> Results { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
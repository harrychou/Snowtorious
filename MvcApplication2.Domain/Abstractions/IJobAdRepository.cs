using System.Collections.Generic;
using System.Linq;
using MvcApplication2.Domain.Entities;

namespace MvcApplication2.Domain.Abstractions
{
    public interface IJobAdRepository
    {
        IQueryable<JobAd> JobAds { get; }
        IEnumerable<JobAd> Search(string query);
    }
}
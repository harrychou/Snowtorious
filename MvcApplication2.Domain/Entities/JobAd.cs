using System;

namespace MvcApplication2.Domain.Entities
{
    public class JobAd
    {
        public int JobAdID { get; internal set; }
        public string Title { get; internal set; }
        public Decimal Salary { get; internal set; }
        public string Location { get; internal set; }
        public bool OnlyMembersMaySeeDetails { get; internal set; }
    }
}
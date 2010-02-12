using System;
using System.Collections.Generic;
using System.Linq;
using MvcApplication2.Domain.Abstractions;
using MvcApplication2.Domain.Entities;

namespace MvcApplication2.Domain.Repository
{
    public class DBJobAdRepository: IJobAdRepository
    {

        public IEnumerable<JobAd> GetAll()
        {
            string[] languages = new[] { "C#", "C#", "C#", "C#", "C#", "C#", "C#", "C#", "C#", "C#", "Java", "Java", "Java", "Java", "Ruby", "Ruby", "Python", "Python", "Python", "VB6", "" };
            string[] Platforms = new[] { "Web", "Web", "Smart Client", "iPhone", "EDI" };
            string[] levels = new[] { "Senior", "Mid-Level", "Junior", "Junior", "Guru", "", "" };
            string[] titles = new[] { "Programmer", "Developer", "Developer" };
            string[] suffix = new[] { "I", "II", "", "" };
            string[] location = new[]
                                    {
                                        "Baltimore, MD USA", 
                                        "Towson, MD USA", 
                                        "Baltimore, MD USA", 
                                        "Towson, MD USA", 
                                        "Cockeysville, MD USA", 
                                        "Baltimore, MD USA", 
                                        "London, UK", 
                                        "Tokyo, Japan"                                        
                                    };

            // definitely cheating
            foreach (var i in Enumerable.Range(1, 767))
            {
                Random rand = new Random(i);
                yield return new JobAd()
                                 {
                                     JobAdID = rand.Next(10000),
                                     Location = location[rand.Next(location.Length)],
                                     Salary = 100000 - rand.Next(50)*1000,
                                     OnlyMembersMaySeeDetails = rand.Next(2) == 1,
                                     Title = String.Format("{0} {1} {2} {3} {4}",
                                                           levels[rand.Next(levels.Length)],
                                                             Platforms[rand.Next(Platforms.Length)],
                                                             languages[rand.Next(languages.Length)],
                                                             titles[rand.Next(titles.Length)],
                                                             suffix[rand.Next(suffix.Length)])
                                 };

            }
        }


        public IQueryable<JobAd> JobAds
        {
            get 
            {
                return GetAll().AsQueryable();
            }
        }

        public IEnumerable<JobAd> Search(string query)
        {
            return GetAll()
                .Where(
                    ad => ad.Title.ToLower().Contains(query.ToLower())
                    || ad.Location.ToLower().Contains(query.ToLower()))
                .OrderBy(ad => ad.JobAdID);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Domain.Abstractions;
using MvcApplication2.Domain.Repository;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class JobsController : Controller
    {
        //
        // GET: /Jobs/

        private IJobAdRepository _repository = new DBJobAdRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Search(string query, [DefaultValue(1)] int page)
        {
//            return "Total job ads found: " + _repository.Search(query).Count();
            var result = _repository.Search(query);
            return View(new SearchResultViewModel()
                            {
                                Results = result.Skip(10 * (page - 1)).Take(10),
                                Query = query,
                                PagingInfo = new PagingInfo()
                                                 {
                                                     CurrentPage = page,
                                                     PageSize = 10,
                                                     TotalResults = result.Count()
                                                 }
                            });
        }

        public ActionResult DownloadJobDetails(int jobAdID)
        {
            var result = _repository.JobAds.First(x => x.JobAdID == jobAdID);

            if (result.OnlyMembersMaySeeDetails && !Request.IsAuthenticated)
                return new HttpUnauthorizedResult();

            return File(Server.MapPath("/") + "JobAds.pdf", "application/pdf", "Details.pdf");
        }
    }
}

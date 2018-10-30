using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using Raheel.Models.Pages;
using Raheel.Models.ViewModels;

namespace Raheel.Controllers
{
    public class NewsListPageController : PageController<NewsListPage>
    {
        private const int MaxRows = 2;

        public ActionResult Index(NewsListPage currentPage, int page = 0)
        {
            var repo = ServiceLocator.Current.GetInstance<IContentLoader>();
            var pages = repo.GetChildren<NewsPage>(currentPage.ContentLink, currentPage.Language, page, MaxRows);
            var model = new NewsPageViewModel
            {
                CurrentPage = currentPage,
                ListOfNews = pages,
                NumberOfPages = repo.GetChildren<NewsPage>(currentPage.ContentLink).Count()
        };

            return View(model);
        }
    }
}
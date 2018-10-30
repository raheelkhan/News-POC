using System.Collections.Generic;
using Raheel.Models.Pages;

namespace Raheel.Models.ViewModels
{
    public class NewsPageViewModel
    {
        public IEnumerable<NewsPage> ListOfNews { get; set; }
        public NewsListPage CurrentPage { get; set; }
        public int NumberOfPages { get; set; }
    }
}
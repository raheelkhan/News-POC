using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Raheel.Models.Pages
{
    [ContentType(DisplayName = "News Page", GUID = "098bfd17-7a89-429f-8212-68d247088ba4", Description = "This page represent a news article")]
    public class NewsPage : NewsListPage
    {

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title of news",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "News",
            Description = "News content",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString News { get; set; }

    }
}
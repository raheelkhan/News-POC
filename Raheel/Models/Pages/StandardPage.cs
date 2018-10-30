using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Raheel.Models.Pages
{
    [ContentType(DisplayName = "Standard Page", GUID = "2c690704-070b-44f7-a2e5-6730a85c22f1", Description = "For basic pages with heading and content area")]
    public class StandardPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main Heading",
            Description = "Main heading",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainHeading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}
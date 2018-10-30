using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Raheel.Models.Pages
{
    [ContentType(DisplayName = "News List Page", GUID = "7971f08c-78f4-472f-a669-732a3b125653", Description = "This page will serve as listing page for news")]
    public class NewsListPage : PageData
    {
       
    }
}
﻿using AlloyTraining.Models.Media;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        DisplayName = "Start", 
        GUID = "a293d16f-7e7d-4f6a-8d69-47985f9e7442", 
        Description = "The home page for a website with an area for blocks and partial pages.",
        GroupName = SiteGroupNames.Specialized,
        Order = 10)]
    [SiteStartIcon]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading", 
            Description = "If the Heading is not set, the page falls back to showing the Name.",
            GroupName = SystemTabNames.Content, 
            Order = 10)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main content area",
            Description = "Drag and drop images, blocks, folders, and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [AllowedTypes(
            typeof(StandardPage), typeof(BlockData),typeof(ImageData), 
            typeof(ContentFolder), typeof(PdfFile))]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Footer text",
            Description = "The footer text will be shown at the bottom of every page.",
            GroupName = SiteTabNames.SiteSettings,
            Order = 10)]
        public virtual string FooterText { get; set; }

        public virtual decimal Price { get; set; }

        [Display(
            Name = "Search page",
            Description = "If you add a Search page to the site, set this property to reference it to enable search from every page.",
            GroupName = SiteTabNames.SiteSettings,
            Order = 40)]
        [AllowedTypes(typeof(SearchPage))]
        public virtual PageReference SearchPageLink { get; set; }
    }
}
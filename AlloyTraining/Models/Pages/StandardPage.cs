using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using AlloyTraining.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        DisplayName = "Standard",
        GUID = "8fb46427-307e-4bf3-bd4a-8c084dd65a07",
        GroupName = SiteGroupNames.Common,
        Description = "Use this page type unless you need a more specialized one.")]
    [SitePageIcon]
    [AvailableContentTypes(
        Include = new[] { typeof(StandardPage) },
        Exclude = new[] { typeof(ProductPage) })]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 150)]
        public virtual XhtmlString MainBody { get; set; }

        public virtual EmployeeBlock Author { get; set; }
    }
}
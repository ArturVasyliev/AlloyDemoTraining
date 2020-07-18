using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Business.SelectionFactories;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(
        DisplayName = "Product",
        GUID = "914e941f-55f4-4803-99d9-4c78f34c2e8d",
        GroupName = SiteGroupNames.Specialized,
        Description = "Use this for software products that Alloy sells.")]
    [SiteCommerceIcon]
    public class ProductPage : StandardPage
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            Theme = "theme1";
        }

        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        [Display(Name = "Color theme",
        GroupName = SystemTabNames.Content, Order = 310)]
        public virtual string Theme { get; set; }

        [CultureSpecific]
        [Display(Name = "Unique selling points",
        GroupName = SystemTabNames.Content, Order = 320)]
        [Required]
        public virtual IList<string> UniqueSellingPoints { get; set; }

        [Display(
            Name = "Main content area",
            Description = "Drag and drop blocks and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 330)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(
            Name = "Related content area",
            Description = "Drag and drop blocks and pages with partial templates.",
            GroupName = SystemTabNames.Content,
            Order = 340)]
        public virtual ContentArea RelatedContentArea { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor]
    public class ContentFolderController : PartialContentController<ContentFolder>
    {
        private readonly IContentLoader loader;
        public ContentFolderController(IContentLoader loader)
        {
            this.loader = loader;
        }

        public override ActionResult Index(ContentFolder currentContent)
        {
            var viewmodel = new ContentFolderViewModel
            {
                CurrentFolder = currentContent,
                ItemsCount = loader.GetChildren<IContent>
            (currentContent.ContentLink).Count()
            };
            return PartialView(viewmodel);
        }
    }
}
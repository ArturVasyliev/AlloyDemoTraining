using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(
        DisplayName = "Portable Document Format",
        GUID = "f79f9f4a-314b-4eb9-938d-e7ec32fcb315",
        Description = "Use this to upload Portable Document Format (PDF) files.")]
    [MediaDescriptor(ExtensionString = "pdf")]
    public class PdfFile : MediaData
    {
        [Display(Name = "Render preview image")]
        // false: render as simple hyperlink
        // true: render as clickable thumbnail preview image
        public virtual bool RenderPreviewImage { get; set; }
    }
}
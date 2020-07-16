using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(
        DisplayName = "AnyFile",
        GUID = "41da112a-7771-40a9-a8a0-bcde9347e9eb",
        Description = "Use this to upload any type of file.")]
        /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class AnyFile : MediaData
    {
    }
}
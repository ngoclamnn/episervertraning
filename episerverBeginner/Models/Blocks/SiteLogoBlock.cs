using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer;
using EPiServer.Web;

namespace episerverBeginner.Models.Blocks
{
    [ContentType(DisplayName = "SiteBlockData", GUID = "39aef593-2991-4ca1-9078-fa93d0a317e8", Description = "")]
    public class SiteLogoBlock: BlockData
    {
        /// <summary>
        /// Gets the site logotype URL
        /// </summary>
        /// <remarks>If not specified a default logotype will be used</remarks>
        [DefaultDragAndDropTarget]
        [UIHint(UIHint.Image)]
        public virtual Url Url
        {
            get
            {
                var url = this.GetPropertyValue(b => b.Url);

                return url == null || url.IsEmpty()
                           ? new Url("/Static/gfx/logotype.png")
                           : url;
            }
            set
            {
                this.SetPropertyValue(b => b.Url, value);
            }
        }

        [CultureSpecific]
        public virtual string Title { get; set; }
    }
}
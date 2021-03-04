using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSections.Helpers
{
    public static class HTMLHelperExtensions
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string imageUrl, string alt)
        {
            TagBuilder builder = new TagBuilder("img");
            builder.MergeAttribute("src", "/images/" + imageUrl);
            builder.MergeAttribute("alt", alt);
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHtmlHelpers
{
    public static class MvcHtmlHelpers
    {
        //ActionImage("Action", "Controller", RouteValues,ImagePath, Alt, CssClass)
        public static MvcHtmlString ActionImage(this HtmlHelper html, string action,
      string controllerName, object routeValues, string imagePath, string alt = null, string cssClass = null)
        {
            var url = new UrlHelper(html.ViewContext.RequestContext);

            // build the <img> tag
            var imgBuilder = new TagBuilder("img");
            imgBuilder.MergeAttribute("src", url.Content(imagePath));
            if (alt != null)
                imgBuilder.MergeAttribute("alt", alt);
            if (cssClass != null)
                imgBuilder.MergeAttribute("class", cssClass);

            string imgHtml = imgBuilder.ToString(TagRenderMode.SelfClosing);

            // build the <a> tag
            var anchorBuilder = new TagBuilder("a");

            anchorBuilder.MergeAttribute("href", url.Action(action, controllerName, routeValues));
            anchorBuilder.InnerHtml = imgHtml; // include the <img> tag inside
            string anchorHtml = anchorBuilder.ToString(TagRenderMode.Normal);

            return MvcHtmlString.Create(anchorHtml);
        }
    }
}
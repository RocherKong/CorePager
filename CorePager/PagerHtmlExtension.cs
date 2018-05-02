using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorePager
{
    public static class PagerHtmlExtension
    {
        public static IHtmlContent Pager(this IHtmlContent htmlContent, IPagedList pagedList, PagerOptions pagerOptions)
        {
            var tagBuilder = new TagBuilder(pagerOptions.TagName);
            tagBuilder.MergeAttribute("id", pagerOptions.Id);
            tagBuilder.AddCssClass(pagerOptions.CssClass);
            if (!pagerOptions.NoPageHide || pagedList.MaxPageIndex != 1)
            {
                //IUrlHelper urlHelper=new UrlHelperFactory().GetUrlHelper(htmlContent.ViewContext)
            }

            return tagBuilder;
        }
    }
}

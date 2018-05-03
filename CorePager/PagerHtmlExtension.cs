using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;

namespace CorePager
{
    public static class PagerHtmlExtension
    {
        public static IHtmlContent Pager(this IHtmlHelper htmlHelper, IPagedList pagedList, PagerOptions pagerOptions)
        {
            var tagBuilder = new TagBuilder(pagerOptions.TagName);
            tagBuilder.MergeAttribute("id", pagerOptions.Id);
            tagBuilder.AddCssClass(pagerOptions.CssClass);
            if (!pagerOptions.NoPageHide || pagedList.MaxPageIndex != 1)
            {
                IUrlHelper urlHelper = new UrlHelperFactory().GetUrlHelper(htmlHelper.ViewContext);
                var dictionary = new Dictionary<String, object>();
                foreach (var keypair in htmlHelper.ViewContext.HttpContext.Request.Query)
                {
                    dictionary.Add(keypair.Key, keypair.Value);
                }
                if (dictionary.ContainsKey(pagerOptions.PageIndexParameterName))
                {
                    dictionary[pagerOptions.PageIndexParameterName] = 1;
                }
                else
                {
                    dictionary.Add(pagerOptions.PageIndexParameterName, (int)1);
                }

                if (pagedList.CurrentPageIndex > 1)
                {
                    var itemPageUrl = urlHelper.Link(pagerOptions.RouteName, dictionary);
                    AddPageItem(tagBuilder, Constants.DEFAULT_PAGE_TEXT_TEMPLATE, itemPageUrl, pagerOptions.FirstText);
                }
                int num = pagedList.CurrentPageIndex - 1;
                if (num > 1)
                {
                    dictionary[pagerOptions.PageIndexParameterName] = num;
                    AddPageItem(tagBuilder, Constants.DEFAULT_PAGE_TEXT_TEMPLATE, urlHelper.Link(pagerOptions.RouteName, dictionary), pagerOptions.PreText);

                }

                int minPageIndex = pagedList.CurrentPageIndex - Constants.PADDING_PAGE_NUM;
                if (minPageIndex < 1)
                {
                    minPageIndex = 1;
                }
                int maxPageIndex = pagedList.CurrentPageIndex + 4;
                if (maxPageIndex > pagedList.MaxPageIndex)
                {
                    maxPageIndex = pagedList.MaxPageIndex;
                }
                for (int i = minPageIndex; i <= maxPageIndex; i++)
                {
                    var itemTemplate = pagerOptions.ItemTemplate;
                    if (i == pagedList.CurrentPageIndex)
                    {
                        itemTemplate = pagerOptions.CurrentTemplate;
                    }
                    dictionary[pagerOptions.PageIndexParameterName] = i;
                    AddPageItem(tagBuilder, itemTemplate, urlHelper.Link(pagerOptions.RouteName, dictionary), i);
                }

                int next = pagedList.CurrentPageIndex + 1;
                if (next < pagedList.MaxPageIndex)
                {
                    dictionary[pagerOptions.PageIndexParameterName] = next;
                    AddPageItem(tagBuilder, Constants.DEFAULT_PAGE_TEXT_TEMPLATE, urlHelper.Link(pagerOptions.RouteName, dictionary), pagerOptions.NextText);
                }
                if (pagedList.CurrentPageIndex < pagedList.MaxPageIndex)
                {
                    dictionary[pagerOptions.PageIndexParameterName] = pagedList.MaxPageIndex;
                    AddPageItem(tagBuilder, Constants.DEFAULT_PAGE_TEXT_TEMPLATE, urlHelper.Link(pagerOptions.RouteName, dictionary), pagerOptions.LastText);
                }
            }

            return tagBuilder;
        }

        private static void AddPageItem(TagBuilder pagerTagBuilder, string template, string itemPageUrl, string itemPageText)
        {
            string str = template.Replace(string.Format("${0}", "text"), itemPageText).Replace(string.Format("${0}", "url"), itemPageUrl);
            pagerTagBuilder.InnerHtml.AppendHtml(str);
        }

        private static void AddPageItem(TagBuilder pagerTagBuilder, string template, string itemPageUrl, int itemPageIndex)
        {
            string str = template.Replace(string.Format("${0}", "index"), ((int)itemPageIndex).ToString()).Replace(string.Format("${0}", "url"), itemPageUrl);
            pagerTagBuilder.InnerHtml.AppendHtml(str);
        }

    }
}

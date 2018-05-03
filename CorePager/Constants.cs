using System;
using System.Collections.Generic;
using System.Text;

namespace CorePager
{
    public class Constants
    {
        public const string DEFAULT_CURRENT_ITEM_TEMPLATE = "<li class=\"active\"><a href=\"$url\">$index</a></li>";
        public const string DEFAULT_ITEM_TEMPLATE = "<li><a href=\"$url\">$index</a></li>";
        public const string DEFAULT_PAGE_TEXT_TEMPLATE = "<li><a href=\"$url\">$text</a></li>";
        public const string DEFAULT_PAGER_TAG_NAME = "ul";
        public const string ITEM_INDEX_KEY = "index";
        public const string ITEM_URL_KEY = "url";
        public const int PADDING_PAGE_NUM = 4;
        public const string PAGE_TEXT_KEY = "text";

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CorePager
{
    public class PagerOptions
    {
        public String TagName { get; set; } = "ul";

        public String RouteName { get; set; }

        public String PreText { get; set; } = "<";

        public String PageIndexParameterName { get; set; } = "PageIndex";

        public bool NoPageHide { get; set; } = true;

        public String LastText { get; set; } = "尾页";

        public String NextText { get; set; } = ">";

        public String ItemTemplate { get; set; } = Constants.DEFAULT_ITEM_TEMPLATE;

        public String Id { get; set; }

        public String FirstText { get; set; } = "首页";

        public String CurrentTemplate { get; set; } = Constants.DEFAULT_CURRENT_ITEM_TEMPLATE;

        public String CssClass { get; set; }
    }
}

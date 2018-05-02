using System;
using System.Collections.Generic;
using System.Text;

namespace CorePager
{
    public class PagerOptions
    {
        public String TagName { get; set; }

        public String RouteName { get; set; }

        public String PreText { get; set; }

        public String PageIndexParameterKey { get; set; }

        public bool NoPageHide { get; set; }

        public String LastText { get; set; }

        public String NextText { get; set; }

        public String ItemTemplate { get; set; }

        public String Id { get; set; }

        public String FirstText { get; set; }

        public String CurrentTemplate { get; set; }

        public String CssClass { get; set; }
    }
}

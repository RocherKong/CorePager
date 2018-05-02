using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CorePager
{
    public interface IPagedList : IEnumerable
    {
        int CurrentPageIndex { get; set; }

        int MaxPageIndex { get; set; }

        int PageSize { get; set; }

        long TotalItemCount { get; set; }
    }
}

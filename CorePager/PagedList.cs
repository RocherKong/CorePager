using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CorePager
{
    public class PagedList<T> : List<T>, IPagedList<T>, IEnumerable<T>, IEnumerable, IPagedList
    {
        public PagedList(IEnumerable<T> ToPageItemList, int PageIndex, int PageSize, long totalItemCount)
        {
            CurrentPageIndex = PageIndex;
            PageSize = PageIndex;
            TotalItemCount = totalItemCount;
            base.AddRange(ToPageItemList);

        }
        public int CurrentPageIndex { get => this.CurrentPageIndex; set => CurrentPageIndex = value; }
        public int MaxPageIndex { get { return (int)(Math.Ceiling((double)TotalItemCount / (double)PageSize)); } set => MaxPageIndex = value; }
        public int PageSize { get => this.PageSize; set => PageSize = value; }
        public long TotalItemCount { get => this.TotalItemCount; set => TotalItemCount = value; }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CorePager
{
    public class PagedList<T> : List<T>, IPagedList<T>, IEnumerable<T>, IEnumerable, IPagedList
    {
        public PagedList(IEnumerable<T> ToPageItemList, int pageIndex, int pageSize, long totalItemCount)
        {
            CurrentPageIndex = pageIndex;
            this.PageSize = pageSize;
            TotalItemCount = totalItemCount;
            base.AddRange(ToPageItemList);

        }

        private int _currentPageIndex;
        public int CurrentPageIndex { get => this._currentPageIndex; set { _currentPageIndex = value; } }

        public int MaxPageIndex { get { return (int)(Math.Ceiling((double)TotalItemCount / (double)PageSize)); } }

        private int _pageSize;
        public int PageSize { get => this._pageSize; set => _pageSize = value; }

        private long _totalItemCount;
        public long TotalItemCount { get => this._totalItemCount; set { _totalItemCount = value; } }


    }
}

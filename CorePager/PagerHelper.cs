using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePager
{
    public static class PagerHelper
    {
        /// <summary>
        /// IEnumerable转换成MvcPagedList
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="currentPageItems"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalItemCount"></param>
        /// <returns></returns>
        public static PagedList<T> ToPagedList<T>(this IEnumerable<T> currentPageItems, int pageIndex, int pageSize, int totalItemCount)
        {
            return new PagedList<T>(currentPageItems, pageIndex, pageSize, totalItemCount);
        }
    }
}

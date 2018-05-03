using System;
using System.Collections.Generic;
using System.Text;

namespace CorePager
{
    public class QueryStringKeyComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.ToLower() == y.ToLower();
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }
}

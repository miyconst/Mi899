using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.DirectoryServices;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Mi899
{
    internal class GenericComparer<T> : IComparer<T>
    {
        public ListSortDescriptionCollection Sorts { get; set; }
        protected Dictionary<string, PropertyInfo> PropertyInfos { get; set; }

        public GenericComparer()
        {
            PropertyInfos = typeof(T)
                .GetProperties()
                .ToDictionary(k => k.Name, v => v);
        }

        public int Compare([AllowNull] T x, [AllowNull] T y)
        {
            if (Sorts == null || Sorts.Count <= 0 || x == null || y == null)
            {
                return 0;
            }

            foreach (ListSortDescription sort in Sorts)
            {
                var pi = PropertyInfos[sort.PropertyDescriptor.Name];
                var a = pi.GetValue(x);
                var b = pi.GetValue(y);
                int r;

                if (a is int ia && b is int ib)
                {
                    r = ia.CompareTo(ib);
                }
                else if (a is long la && b is long lb)
                {
                    r = la.CompareTo(lb);
                }
                else if (a is decimal da && b is decimal db)
                {
                    r = da.CompareTo(db);
                }
                else
                {
                    string sa = a?.ToString();
                    string sb = b?.ToString();

                    if (sa == null && sb == null)
                    {
                        r = 0;
                    }
                    else if (sa == null)
                    {
                        r = sb.CompareTo(sa) * -1;
                    }
                    else if (sb == null)
                    {
                        r = sa.CompareTo(sb);
                    }
                    else
                    {
                        r = sa.CompareTo(sb);
                    }
                }

                if (sort.SortDirection == ListSortDirection.Descending)
                {
                    r *= -1;
                }

                if (r != 0)
                {
                    return r;
                }
            }

            return 0;
        }
    }
}

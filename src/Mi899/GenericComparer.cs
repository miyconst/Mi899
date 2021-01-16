using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace Mi899
{
    internal class GenericComparer<T> : IComparer<T>
    {
        public ListSortDescriptionCollection Sorts { get; set; }
        private Dictionary<string, PropertyInfo> PropertyInfos { get; set; }

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
                var propertyInfo = PropertyInfos[sort.PropertyDescriptor.Name];
                var left = propertyInfo.GetValue(x);
                var right = propertyInfo.GetValue(y);
                int result;

                switch (left)
                {
                    case int intLeft when right is int intRight:
                        result = intLeft.CompareTo(intRight);
                        break;
                    case long longLeft when right is long longRight:
                        result = longLeft.CompareTo(longRight);
                        break;
                    case decimal decimalLeft when right is decimal decimalRight:
                        result = decimalLeft.CompareTo(decimalRight);
                        break;
                    default:
                    {
                        var stringLeft = left?.ToString();
                        var stringRight = right?.ToString();

                        result = stringLeft switch
                        {
                            null when stringRight == null => 0,
                            null => string.Compare(stringRight, null, StringComparison.Ordinal) * -1,
                            _ => string.Compare(stringLeft, stringRight, StringComparison.Ordinal)
                        };
                        break;
                    }
                }

                if (sort.SortDirection == ListSortDirection.Descending)
                {
                    result *= -1;
                }

                if (result != 0)
                {
                    return result;
                }
            }

            return 0;
        }
    }
}

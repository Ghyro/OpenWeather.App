using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Core
{
    public static class AppExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> param)
            => param == null || !param.Any() || param.Count() < 0;

        public static bool EqIgnoreCase(this string text1, string text2)
            => string.Equals(text1, text2, StringComparison.OrdinalIgnoreCase);

        public static T OfValidType<T>(this object item) where T : class
        {
            if (item == null)
                throw new ArgumentException($"Item {item} is null");

            var req = item as T;

            if (req != null)
                 return req;

            return null;
        }

        public static T FirstOrDefault<T>(this IEnumerable collection)
            => collection.Cast<T>().FirstOrDefault();
    }
}

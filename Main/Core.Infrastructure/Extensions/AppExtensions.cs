using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public static class AppExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> param)
            => param == null || !param.Any();

        public static bool AppEq(this string text1, string text2)
            => string.Equals(text1, text2, StringComparison.OrdinalIgnoreCase);
    }
}

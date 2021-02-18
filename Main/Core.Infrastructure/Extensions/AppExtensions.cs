using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public static class AppExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> param)
            => param == null || !param.Any();
    }
}

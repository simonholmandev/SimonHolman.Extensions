using System.Collections.Generic;
using System.Linq;

namespace SimonHolman.Extensions
{
    public static class IEnumerableExtensions
    {
        public static bool NotNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source != null && source.Any();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }
    }
}

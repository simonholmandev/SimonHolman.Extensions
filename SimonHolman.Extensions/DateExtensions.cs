using System;

namespace SimonHolman.Extensions
{
    public static class DateExtensions
    {
        public static string ToddMMMyyyyString(this DateTime? value)
        {
            return value.HasValue ? value.Value.ToString("dd MMM yyyy") : string.Empty;
        }
    }
}

namespace SimonHolman.Extensions
{
    public static class StringExtensions
    {
        public static bool NotEmpty(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value[..maxLength];
        }
    }
}

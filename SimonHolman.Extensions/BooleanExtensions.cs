namespace SimonHolman.Extensions
{
    public static class BooleanExtensions
    {
        public static string ToYesNoBlankString(this bool? value)
        {
            return value.HasValue ? value.Value ? "Yes" : "No" : string.Empty;
        }

        public static string ToYesNoString(this bool value)
        {
            return value ? "Yes" : "No";
        }

        public static string ToCustomString(this bool? value, string nullString, string trueString, string falseString)
        {
            return value.HasValue ? value.Value ? trueString : falseString : nullString;
        }
    }
}

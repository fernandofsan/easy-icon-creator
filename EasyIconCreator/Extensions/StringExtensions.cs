using System.Text;
using System.Text.RegularExpressions;

namespace EasyIconCreator.Extensions
{
    public static class StringExtensions
    {
        public static string ToSlug(this string source, short limit = 100)
        {
            // Is the source null?
            if (null == source)
            {
                return "";
            }

            // Remove accents
            var bytes = Encoding.GetEncoding("Cyrillic").GetBytes(source);
            var value = Encoding.ASCII.GetString(bytes);

            // Converts "GooglePlus" to "-google-plus"
            value = Regex.Replace(value, @"([A-Z])", "-$1").ToLowerInvariant();

            // Remove invalid characters
            value = Regex.Replace(value, @"[^a-z0-9]+", "-");

            // Remove hyphens
            value = value.Trim('-');

            // Check the limit and truncate the string
            if (limit > 0 && value.Length > limit)
            {
                value = value.Substring(0, limit).Trim('-');
            }

            return value;
        }

    }
}

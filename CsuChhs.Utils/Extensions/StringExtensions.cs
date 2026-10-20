using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace CsuChhs.Utils.Extensions
{
    public static class StringExtensions
    {
        private static readonly Regex NonAlphaNumericRegex =
            new("[^a-z0-9\\s-]", RegexOptions.Compiled);

        private static readonly Regex MultipleSpacesRegex =
            new("[\\s-]+", RegexOptions.Compiled);

        /// <summary>
        /// Converts a string into a URL-friendly slug.
        /// </summary>
        /// <param name="value">The string to be converted into a slug.</param>
        /// <returns>A URL-friendly slug representation of the input string.</returns>
        public static string Slugify(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }

            // Convert accented characters to their ASCII equivalents
            string normalized = value.Normalize(NormalizationForm.FormD);

            var sb = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);

                if (category != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            string result = sb.ToString()
                .Normalize(NormalizationForm.FormC)
                .ToLowerInvariant();

            // Remove invalid characters
            result = NonAlphaNumericRegex.Replace(result, string.Empty);

            // Replace whitespace runs with a single dash
            result = MultipleSpacesRegex.Replace(result, "-");

            return result.Trim('-');
        }

        /// <summary>
        /// Validates the *format* of a potential
        /// CSUID.  This does not validate that the CSUID
        /// is valid, but makes sure it is in the 
        /// correct format.
        /// </summary>
        /// <param name="value">CSUID</param>
        /// <returns></returns>
        public static bool IsValidCsuId(this string value)
        {
            if(!_DigitsOnly(value))
            {
                return false;
            }

            if(!_LengthCorrect(value, 9))
            {
                return false;
            }

            return true;
        }

        private static bool _LengthCorrect(string digits, int length)
        {
            if(digits.Length == length)
            {
                return true;
            }
            return false;
        }

        private static bool _DigitsOnly(string digits)
        {
            foreach(char c in digits)
            {
                if(c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
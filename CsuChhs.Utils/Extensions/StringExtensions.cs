using System.Net;

namespace CsuChhs.Utils.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Convert string into a URL encoded string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToUrlEncodedString(this string value)
        {
            return WebUtility.UrlEncode(value);
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
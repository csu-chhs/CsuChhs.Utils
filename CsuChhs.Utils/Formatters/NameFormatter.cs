namespace CsuChhs.Utils.Formatters
{
    public static class NameFormatter
    {
        /// <summary>
        /// Simple name formatter, for a First Last name.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <returns></returns>
        [Obsolete("Being removed", true)]
        public static string FormatName(string first, string last)
        {
            return $"{first} {last}";
        }
    }
}
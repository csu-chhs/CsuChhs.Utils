namespace CsuChhs.Utils.Utilities
{
    public static class Core
    {

        /// <summary>
        /// Return the maximum number from a set of two
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static int GetMaximumNumber(int first, int second)
        {
            if (first == 0 && second == 0)
            {
                return 1;
            }

            if (first >= second)
            {
                return first;
            }

            return second;
        }

        /// <summary>
        /// Generate a new random pin Number
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomPinNumber()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}

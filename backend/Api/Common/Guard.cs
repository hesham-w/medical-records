namespace Api.Common
{
    public static class Guard
    {
        public static void NotNull(object value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void NotNullOrWhiteSpace(string value, string name)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void EnsureMinimumLength(string value, int minLength, string name)
        {
            NotNullOrWhiteSpace(value, name);

            if (value.Length < minLength)
            {
                throw new ArgumentException($"Length of the string has to be at least {minLength}", name);
            }
        }
    }
}

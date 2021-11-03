namespace System
{
    public static class StringExtensions
    {
        public static string Cut(this string thisString, int size)
        {
            if (thisString.Length < size)
            {
                throw new ArgumentException("the size cannot be greater than string size");
            }

            if (thisString.Length == size)
            {
                return thisString;
            }

            var newStr = thisString.Substring(0, size);

            return newStr + "...";
        }
    }
}
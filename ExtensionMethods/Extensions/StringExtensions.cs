namespace System
{
    public static class StringExtensions
    {
        public static string Cut(this string thisString, int size)
        {
            if (thisString.Length <= size)
            {
                return thisString;
            }


            return thisString.Substring(0, size) + "...";
        }
    }
}
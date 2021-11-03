using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
     class Program
    {
        public static void Main(string[] args)
        {
            var dateTime = new DateTime(2021,11,03,10,24,12);
            Console.WriteLine(dateTime.ElapsedTime());
        }
    }
}   
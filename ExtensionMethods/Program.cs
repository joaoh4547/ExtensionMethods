using System;

namespace ExtensionMethods
{
     class Program
    {
        public static void Main(string[] args)
        {
            // Example 01
            Console.WriteLine("Example 01");
            
            var dateTime = new DateTime(2021,11,03,10,24,12);
            Console.WriteLine(dateTime.ElapsedTime());
            Console.WriteLine("---------------\n");
         
            
            // Example 02
            Console.WriteLine("Example 02");
           
            const string text = "Good morning";
            Console.WriteLine(text.Cut(14));
        }
    }
}   
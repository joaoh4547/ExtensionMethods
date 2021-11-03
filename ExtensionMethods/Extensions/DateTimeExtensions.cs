using System;
using System.Globalization;

namespace ExtensionMethods.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisDateTime)
        {
            TimeSpan span = DateTime.Now.Subtract(thisDateTime);

            if (span.TotalHours < 24.0)
            {
                return span.TotalHours.ToString("F1",CultureInfo.InvariantCulture) + " Horas";
            }
           
            return span.TotalDays.ToString("F1",CultureInfo.InvariantCulture) + " Dias";
            
        }
    }
}
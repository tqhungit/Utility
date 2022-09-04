using System;

namespace Utility.Helpers
{
    public class DateTimeHelper
    {
        /// <summary>
        /// Get Business day between two days, don't count the fromDate and toDate.
        /// This Method is not exclude holidays
        /// </summary>
        /// <param name="fromDate">From Date</param>
        /// <param name="toDate">To Date</param>
        /// <returns>The number of working day.</returns>
        public static int GetBusinessDays(DateTime fromDate, DateTime toDate)
        {
            fromDate = fromDate.AddDays(1);
            toDate = toDate.AddDays(-1);

            if (toDate.Date < fromDate.Date)
                return 0;

            double calcBusinessDays = 1 + ((toDate.Date - fromDate.Date).TotalDays * 5 + (toDate.DayOfWeek - fromDate.DayOfWeek) * 2) / 7;

            if (fromDate.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;
            if (toDate.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;

            return (int)calcBusinessDays;
        }
    }
}

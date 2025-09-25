namespace CsuChhs.Utils.Services
{
    public static class DateService
    {
        public enum AmPm
        {
            Am,
            Pm
        }

        /// <summary>
        /// Return all dates within (and including start/end)
        /// of a given range of time.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static List<DateTime> GetDatesInRange(DateTime start,
            DateTime end)
        {
            List<DateTime> dates = new List<DateTime>();
            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                dates.Add(date);
            }

            return dates;
        }

        /// <summary>
        /// Given a date, return the first day of the previous month.  Helpful in
        /// determining billing start dates for jobs.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetPreviousMonthFirstDay(DateTime date)
        {
            if (date.Month == 1)
            {
                return new DateTime(date.Year - 1, 12, 1);
            }
            return new DateTime(date.Year, date.Month - 1, 1);
        }

        /// <summary>
        /// Given a date, return the last day of the previous month.  Helpful
        /// in determining billing end dates for jobs.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetPreviousMonthLastDay(DateTime date)
        {
            if (date.Month == 1)
            {
                return new DateTime(date.Year - 1, 12, 31);
            }
            return new DateTime(date.Year, date.Month - 1, GetThisMonthFirstDay(date).AddDays(-1).Day);
        }

        /// <summary>
        /// Return the start date of a given month from a date time.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetThisMonthFirstDay(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        /// <summary>
        /// Returns true if the two specified ranges overlap
        /// each other
        /// </summary>
        /// <param name="range"></param>
        /// <param name="range2"></param>
        /// <returns></returns>
        public static bool DateRangeOverlap(DateRange range, DateRange range2)
        {
            return range.Start < range2.End && range2.Start < range.End;
        }

        /// <summary>
        /// Returns the first day of week of a given month.  Must
        /// specify which day you want.
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static DateTime GetFirstDayOfWeekOfMonth(int month, int year, DayOfWeek day)
        {
            DateTime start = DateTime.Parse($"{year}-{month}-01");
            bool found = false;
            while (!found)
            {
                if (start.DayOfWeek == day)
                {
                    found = true;

                }
                else
                {
                    start = start.AddDays(1);
                }
            }

            return start;
        }

        /// <summary>
        /// Given a start and end date, return
        /// a list of TimeFrame objects which represent
        /// work weeks that are fully within that time span.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static List<DateRange> GetWorkWeeks(DateTime start, DateTime end)
        {
            List<DateRange> workWeeks = new List<DateRange>();

            // Find first Monday
            bool mondayFound = false;
            DateTime foundDay = start;
            while (!mondayFound)
            {
                if (foundDay.DayOfWeek == DayOfWeek.Monday)
                {
                    mondayFound = true;
                }
                else
                {
                    foundDay = foundDay.AddDays(1);
                }
            }

            // When this while loop starts the 
            // found day is always the first monday in the data set.
            while (foundDay.Date < end.Date)
            {
                // Create a new TimeFrame
                DateRange workWeek = new DateRange(foundDay, foundDay.AddDays(4));

                workWeeks.Add(workWeek);

                foundDay = foundDay.AddDays(7);
            }

            return workWeeks;
        }
        
        /// <summary>
        /// Converts an existing hour and am/pm to a 24 hour clock.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="amPm"></param>
        /// <returns></returns>
        public static int ConvertAMPMToHourClock(int time, AmPm amPm)
        {
            if (amPm == AmPm.Pm && time == 12)
            {
                return time;
            }

            if (amPm == AmPm.Am)
            {
                return time;
            }
            else
            {
                return 12 + time;
            }
        }

        /// <summary>
        /// Given a date, find the proceeding monday,
        /// unless the day is monday.
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public static DateTime GetLastMonday(DateTime start)
        {
            if (start.DayOfWeek == DayOfWeek.Monday)
            {
                return start;
            }

            DateTime walkingDate = start.AddDays(-1);
            bool found = false;

            while (!found)
            {
                if (walkingDate.DayOfWeek == DayOfWeek.Monday)
                {
                    found = true;
                }
                else
                {
                    walkingDate = walkingDate.AddDays(-1);
                }
            }
            return walkingDate;
        }

        /// <summary>
        /// Calculate the age (years since) for a given birthday
        /// and then a date to calculate from, which is typically, today.
        /// </summary>
        /// <param name="birthday">Birthday or day age starts</param>
        /// <param name="calculateFrom"></param>
        /// <returns>Returns the age determined by the birthday and the calculated day.</returns>
        public static int CalculateAge(DateTime birthday, DateTime calculateFrom)
        {
            var age = calculateFrom.Year - birthday.Year;

            if (birthday.Date > calculateFrom.AddYears(-age)) age--;

            return age;
        }

        /// <summary>
        /// Given a date and a day of the week, find
        /// the closest previous datetime with that day of the week.
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="dayOfWeek"></param>
        /// <returns></returns>
        public static DateTime GetClosestPreviousSpecificWeekday(DateTime date, DayOfWeek dayOfWeek)
        {
            // Check for the initial date passed in before we attempt to search for it.
            if (date.DayOfWeek == dayOfWeek)
            {
                return date;
            }

            bool found = false;

            while (!found)
            {
                date = date.AddDays(-1);
                if (date.DayOfWeek == dayOfWeek)
                {
                    return date;
                }
            }

            throw new InvalidOperationException("Could not find date.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime GetPreviousWeekday(DateTime date)
        {
            bool found = false;

            while (!found)
            {
                date = date.AddDays(-1);
                if (date.IsWeekday())
                {
                    return date;
                }
            }
            throw new InvalidOperationException("Could not find a date.");
        }

        /// <summary>
        /// Gets the first day of the week for the month previous to that which is passed in.
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="dayOfWeek"></param>
        /// <returns></returns>
        public static DateTime GetPreviousMonthFirstDayOfWeek(int month, int year, DayOfWeek dayOfWeek)
        {
            // In the case of January we need to modify the month and year.
            if (month == 1)
            {
                return GetFirstDayOfWeekOfMonth(12, year - 1, dayOfWeek);
            }

            return GetFirstDayOfWeekOfMonth(month - 1, year, dayOfWeek);
        }

        public static DateTime GetNextMonthFirstDayOfWeek(int month, int year, DayOfWeek dayOfWeek)
        {
            if (month == 12)
            {
                return GetFirstDayOfWeekOfMonth(1, year + 1, dayOfWeek);
            }

            return GetFirstDayOfWeekOfMonth(month + 1, year, dayOfWeek);
        }

        /// <summary>
        /// Given the date range, determine if a given date is within it.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="value"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static bool InRange(DateTime start, DateTime end, DateTime value)
        {
            return value >= start && value <= end;
        }

        /// <summary>
        /// Given a date range, determine if the given date is within it, but ignore
        /// dates that are completely equal.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="value"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static bool IsInRangeNotEqual(DateTime start, DateTime end, DateTime value)
        {
            return value > start && value < end;
        }

        /// <summary>
        /// Given a date range, make sure the time span is valid,
        /// ie, make sure the start time occurs before the end time.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static bool IsValidTimeSpan(DateTime start, DateTime end)
        {
            return start < end;
        }

        /// <summary>
        /// Returns a new date time object that maintins the 
        /// time of a previous object while changing the 
        /// date.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static DateTime CreateDateFromTime(int year, int month, int day, DateTime time)
        {
            return new DateTime(year, month, day, time.Hour, time.Minute, 0);
        }

        private static bool IsWeekday(this DateTime dateTimeValue)
        {
            switch (dateTimeValue.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return false;

                case DayOfWeek.Sunday:
                    return false;

                default:
                    return true;
            }
        }
    }


}
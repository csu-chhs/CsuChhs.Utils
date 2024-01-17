using System.ComponentModel.DataAnnotations;

namespace CsuChhs.Utils.Enums
{
    public static class Calendar
    {
        public enum Month
        {
            [Display(Name = "January")]
            January = 1,

            [Display(Name = "February")]
            February = 2,

            [Display(Name = "March")]
            March = 3,

            [Display(Name = "April")]
            April = 4,

            [Display(Name = "May")]
            May = 5,

            [Display(Name = "June")]
            June = 6,

            [Display(Name = "July")]
            July = 7,

            [Display(Name = "August")]
            August = 8,

            [Display(Name = "September")]
            September = 9,

            [Display(Name = "October")]
            October = 10,

            [Display(Name = "November")]
            November = 11,

            [Display(Name = "December")]
            December = 12
        }

        public enum Day
        {
            [Display(Name = "Sunday")]
            Sunday = 0,

            [Display(Name = "Monday")]
            Monday = 1,

            [Display(Name = "Tuesday")]
            Tuesday = 2,

            [Display(Name = "Wednesday")]
            Wednesday = 3,

            [Display(Name = "Thursday")]
            Thursday = 4,

            [Display(Name = "Friday")]
            Friday = 5,

            [Display(Name = "Saturday")]
            Saturday = 6
        }
    }
}

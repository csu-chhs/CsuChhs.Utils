using System.ComponentModel.DataAnnotations;

namespace CsuChhs.Utils.Enums
{
    public static class Colors
    {
        public enum StandardColors
        {
            [Display(Name = "White")]
            White = 0,

            [Display(Name = "Black")]
            Black = 1,

            [Display(Name = "Gray")]
            Gray = 2,

            [Display(Name = "Red")]
            Red = 3,

            [Display(Name = "Blue")]
            Blue = 4,

            [Display(Name = "Yellow")]
            Yellow = 5,

            [Display(Name = "Purple")]
            Purple = 6,

            [Display(Name = "Green")]
            Green = 7,

            [Display(Name = "Orange")]
            Orange = 8
        }


    }
}

using System.ComponentModel.DataAnnotations;
using static CsuChhs.Utils.Enums.Grades;

namespace CsuChhs.Utils.Enums
{
    public class Grades
    {
        public enum Grade
        {
            [Display(Name = "NG (No Grade given)")]
            NG = 0,

            [Display(Name = "A+")]
            AP = 1,

            [Display(Name = "A")]
            A = 2,

            [Display(Name = "A-")]
            AM = 3,

            [Display(Name = "B+")]
            BP = 4,

            [Display(Name = "B")]
            B = 5,

            [Display(Name = "B-")]
            BM = 6,

            [Display(Name = "C+")]
            CP = 7,

            [Display(Name = "C")]
            C = 8,

            [Display(Name = "C-")]
            CM = 9,

            [Display(Name = "D+")]
            DP = 10,

            [Display(Name = "D")]
            D = 11,

            [Display(Name = "D-")]
            DM = 12,

            [Display(Name = "F")]
            F = 13,

            [Display(Name = "Satisfactory/Pass")]
            SP = 14
        }
    }

    public static class GradeExtensions
    {
        public static double ToGPA(this Grade grade)
        {
            switch (grade)
            {
                case Grade.AP: return 4.0;
                case Grade.A: return 4.0;
                case Grade.AM: return 3.7;
                case Grade.BP: return 3.3;
                case Grade.B: return 3.0;
                case Grade.BM: return 2.7;
                case Grade.CP: return 2.3;
                case Grade.C: return 2.0;
                case Grade.CM: return 1.7;
                case Grade.DP: return 1.3;
                case Grade.D: return 1.0;
                case Grade.DM: return 0.7;
                case Grade.F: return 0.0;

                default: throw new ArgumentOutOfRangeException("grade");
            }
        }

        public static double ToGPA(this Grade? grade)
        {
            switch (grade)
            {
                case Grade.AP: return 4.0;
                case Grade.A: return 4.0;
                case Grade.AM: return 3.7;
                case Grade.BP: return 3.3;
                case Grade.B: return 3.0;
                case Grade.BM: return 2.7;
                case Grade.CP: return 2.3;
                case Grade.C: return 2.0;
                case Grade.CM: return 1.7;
                case Grade.DP: return 1.3;
                case Grade.D: return 1.0;
                case Grade.DM: return 0.7;
                case Grade.F: return 0.0;

                default: throw new ArgumentOutOfRangeException("grade");
            }
        }
    }
}

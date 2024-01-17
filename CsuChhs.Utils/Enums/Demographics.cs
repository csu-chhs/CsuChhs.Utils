using System.ComponentModel.DataAnnotations;

namespace CsuChhs.Utils.Enums
{
    /// <summary>
    /// These demo options should be considered the college
    /// standard for now.  Update these as those change.  You can
    /// (and should) override these on an app by app basis
    /// if needed.
    /// </summary>
    public static class Demographics
    {
        public enum Pronoun
        {
            [Display(Name = "They/Them/Theirs")]
            TheyThemTheirs = 0,

            [Display(Name = "She/Her/Hers")]
            SheHerHers = 1,

            [Display(Name = "He/Him/His")]
            HeHimHis = 2,

            [Display(Name = "Not Listed")]
            NotListed = 3,

            [Display(Name = "Prefer Not To Say")]
            PreferNotToSay = 4,

            [Display(Name = "Ze/Zir/Zirs")]
            ZeZirZirs = 5
        }

        public enum GenderIdentity
        {
            [Display(Name = "Woman")]
            Woman = 0,

            [Display(Name = "Man")]
            Man = 1,

            [Display(Name = "Transgender")]
            Transgender = 2,

            [Display(Name = "Non-Binary/Gender Non-Conforming")]
            NonBinaryGenderNonConforming = 3,

            [Display(Name = "Prefer Not To Answer")]
            PreferNotToAnswer = 4
        }

        public enum RaceEthnicity
        {
            [Display(Name = "American Indian or Alaskan Native")]
            AmericanIndianAlaskanNative = 0,

            [Display(Name = "Asian")]
            Asian = 1,

            [Display(Name = "Black or African American")]
            BlackOrAfricanAmerican = 2,

            [Display(Name = "Hispanic or LatinX")]
            HispanicOrLatinX = 3,

            [Display(Name = "Native Hawaiian or Pacific Islander")]
            NativeHawaiianOrPacificIslander = 4,

            [Display(Name = "White, non-Hispanic")]
            WhiteNonHispanic = 5,

            [Display(Name = "Race and/or ethnicity unknown or prefer not to answer")]
            UnknownPreferNotToAnswer = 6

        }
    }
}

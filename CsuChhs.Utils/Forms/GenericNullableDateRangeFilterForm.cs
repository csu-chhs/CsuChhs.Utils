namespace CsuChhs.Utils.Forms
{
    public class GenericNullableDateRangeFilterForm
    {
        public GenericNullableDateRangeFilterForm()
        {

        }

        public GenericNullableDateRangeFilterForm(DateTime? startDate,
            DateTime? endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

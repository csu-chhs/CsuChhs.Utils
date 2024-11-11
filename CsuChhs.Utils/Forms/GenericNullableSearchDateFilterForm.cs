namespace CsuChhs.Utils.Forms
{
    public class GenericNullableSearchDateFilterForm
    {
        public GenericNullableSearchDateFilterForm()
        {
            Search = string.Empty;
        }

        public GenericNullableSearchDateFilterForm(DateTime? start,
            DateTime? end,
            string search)
        {
            Start = start;
            End = end;
            Search = search;
        }

        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Search { get; set; }
    }
}

namespace CsuChhs.Utils.Forms
{
    public class GenericSearchForm
    {
        private string _search;

        public GenericSearchForm()
        {
            Search = string.Empty;
        }

        public string Search
        {
            get { return _search; }
            set { _search = value.Trim(); }
        }
    }
}
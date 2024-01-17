namespace CsuChhs.Utils.Enums
{
    public static class ChangeActions
    {
        public enum StandardChangeAction
        {
            Created = 0,
            Updated = 1,
            Deleted = 2,
            Error = 3,
            Other = 4
        }

        public enum SuccessFailChangeAction
        {
            Success = 0,
            Fail = 1
        }
    }
}
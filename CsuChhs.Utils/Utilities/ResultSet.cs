using CsuChhs.Utils.Utilities.Interfaces;

namespace CsuChhs.Utils.Utilities;

public class ResultSet<T> : IResultSet<T>
{
    public ResultSet(List<T> items,
        int totalCountBeforeSkip)
    {
        Items = items;
        TotalCountBeforeSkip = totalCountBeforeSkip;
    }
    
    public List<T> Items { get; init; }
    public int TotalCountBeforeSkip { get; init; }
}
namespace CsuChhs.Utils.Utilities.Interfaces;

public interface IResultSet<T>
{
    List<T> Items { get; init; }
    int TotalCountBeforeSkip { get; init; }
}
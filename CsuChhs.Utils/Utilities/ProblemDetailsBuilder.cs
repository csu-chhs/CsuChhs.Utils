using CsuChhs.Utils.Utilities.Interfaces;

namespace CsuChhs.Utils.Utilities;

public class ProblemDetailsBuilder : IProblemDetailsBuilder
{
    private string? _type;
    private int? _status;
    private string? _title;
    private string? _detail;
    private string? _instance;

    public IProblemDetailsBuilder WithStatus(int status)
    {
        _status = status;
        return this;
    }

    public IProblemDetailsBuilder WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public IProblemDetailsBuilder WithDetail(string detail)
    {
        _detail = detail;
        return this;
    }

    public IProblemDetailsBuilder WithInstance(string instance)
    {
        _instance = instance;
        return this;
    }

    public IProblemDetailsBuilder WithType(string type)
    {
        _type = type;
        return this;
    }

    public ProblemDetails Build()
    {
        
        return new ProblemDetails
        {
            Type = _type,
            Status = _status,
            Title = _title,
            Detail = _detail,
            Instance = _instance
        };
    }
}
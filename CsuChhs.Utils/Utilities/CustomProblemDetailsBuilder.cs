using CsuChhs.Utils.Utilities.Interfaces;

namespace CsuChhs.Utils.Utilities;

public class CustomProblemDetailsBuilder : ICustomProblemDetailsBuilder
{
    private string? _type;
    private int? _status;
    private string? _title;
    private string? _detail;
    private string? _instance;

    public ICustomProblemDetailsBuilder WithStatus(int status)
    {
        _status = status;
        return this;
    }

    public ICustomProblemDetailsBuilder WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public ICustomProblemDetailsBuilder WithDetail(string detail)
    {
        _detail = detail;
        return this;
    }

    public ICustomProblemDetailsBuilder WithInstance(string instance)
    {
        _instance = instance;
        return this;
    }

    public ICustomProblemDetailsBuilder WithType(string type)
    {
        _type = type;
        return this;
    }

    public CustomProblemDetails Build()
    {
        
        return new CustomProblemDetails
        {
            Type = _type,
            Status = _status,
            Title = _title,
            Detail = _detail,
            Instance = _instance
        };
    }
}
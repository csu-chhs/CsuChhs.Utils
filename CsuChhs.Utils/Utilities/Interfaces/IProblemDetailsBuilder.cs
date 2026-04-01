namespace CsuChhs.Utils.Utilities.Interfaces;

public interface IProblemDetailsBuilder
{
    IProblemDetailsBuilder WithStatus(int status);
    IProblemDetailsBuilder WithTitle(string title);
    IProblemDetailsBuilder WithDetail(string detail);
    IProblemDetailsBuilder WithInstance(string instance);
    IProblemDetailsBuilder WithType(string type);
    ProblemDetails Build();
}
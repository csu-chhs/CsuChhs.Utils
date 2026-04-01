namespace CsuChhs.Utils.Utilities.Interfaces;

public interface ICustomProblemDetailsBuilder
{
    ICustomProblemDetailsBuilder WithStatus(int status);
    ICustomProblemDetailsBuilder WithTitle(string title);
    ICustomProblemDetailsBuilder WithDetail(string detail);
    ICustomProblemDetailsBuilder WithInstance(string instance);
    ICustomProblemDetailsBuilder WithType(string type);
    CustomProblemDetails Build();
}
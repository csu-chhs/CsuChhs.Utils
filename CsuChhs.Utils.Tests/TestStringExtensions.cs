using CsuChhs.Utils.Extensions;

namespace CsuChhs.Utils.Tests;

public class TestStringExtensions
{
    [Test]
    public void Test_Slugify()
    {
        Assert.That("Hello World".Slugify(), 
            Is.EqualTo("hello-world"));
        
        Assert.That("\"CHHS/CAES Applications\",,,".Slugify(),
            Is.EqualTo("chhscaes-applications"));
        
    }
}
using Xunit;
using MyLibrary;

namespace MyLibrary.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var obj = new Class1();
        var result = obj.Add(2, 3);

        Assert.Equal(5, result);
    }
}
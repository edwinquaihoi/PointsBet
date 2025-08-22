namespace PointsBet.Backend.OnlineCodeTest;

using Xunit;

public class StringFormatterTest
{

    [Fact]
    public void TestToCommaSeperatedString()
    {
        string result = StringFormatter.ToCommaSeparatedString(["A", "B", "C"]);

        Assert.Equal("A,B,C", result);
    }

    [Fact]
    public void TestDelimitWith()
    {
        string result1 = StringFormatter.DelimitWith(["A", "B", "C"], ",");
        Assert.Equal("A,B,C", result1);

        string result2 = StringFormatter.DelimitWith(["A", "B", "C"], "");
        Assert.Equal("ABC", result2);

        string result3 = StringFormatter.DelimitWith([], "");
        Assert.Equal("", result3);

        string result4 = StringFormatter.DelimitWith(["A", "B"], "!@#$");
        Assert.Equal("A!@#$B", result4);
        
        string result5 = StringFormatter.DelimitWith(["A"], "!@#$");
        Assert.Equal("A", result5);
    }
}
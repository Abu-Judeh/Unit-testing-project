namespace String_Calculator;

public class UnitTest1
{
    [Fact]
    public void Add_EmptyString()
    {
        var calc = new StringCalculator();
        var result = calc.add("");
        Assert.Equal(0,result);
    }

    [Fact]
    public void Add_SingleNumber()
    {
        var calc = new StringCalculator();
        var result = calc.add("1");
        Assert.Equal(1,result);
    }

    [Fact]
    public void Add_TwoNumbers()
    {
        var calc = new StringCalculator();
        var result = calc.add("1,2");
        Assert.Equal(3,result);
    }

    [Fact]
    public void Add_NewLine()
    {
        var calc = new StringCalculator();
        var result = calc.add("1\n2,3");
        Assert.Equal(6,result);
    }

    [Fact]
    public void Add_Delimiter()
    {
        var calc = new StringCalculator();
        var result = calc.add("//;\n1;2");
        Assert.Equal(3,result);
    }

    [Fact]
    public void Add_Negative()
    {
        var calc = new StringCalculator();
        var exception = Assert.Throws<Exception>(() => calc.add("1,4,-1"));
        Assert.Equal("negatives not allowed: -1", exception.Message);
    }
    
    [Fact]
    public void Add_IgnoreNumbersGreaterThan1000_ReturnsSum()
    {
        var calc = new StringCalculator();
        var result = calc.add("2,1001");
        Assert.Equal(2, result);
    }

}
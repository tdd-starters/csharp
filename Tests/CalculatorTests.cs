using Example;
using Xunit;

namespace Tests;

public class CalculatorTests
{

    [Theory]
    [InlineData("0", 0)]
    //[InlineData("1 + 2", 0)]
    // ... more tests here
    //[InlineData("0", 0)]
    public void ExpressionIsCorrectlyEvaluated(String expression, uint expected)
    {
        // Given a calculator for the expression
        var calculator = new Calculator(expression);
        
        // when the expression is evaluated
        var result = calculator.Evaluate();
        
        // then the result is as expected
        Assert.Equal(expected, result);
    }

    /*
    [Theory]
    [InlineData("foo")]
    public void InvalidExpressionThrows(String expression)
    {
        // Given a calculator for the expression
        var calculator = new Calculator(expression);
        
        // Expect an exception to be thrown when the expression is evaluated
        Assert.Throws<ArgumentException>(() => calculator.Evaluate());
    }
    */
    
}
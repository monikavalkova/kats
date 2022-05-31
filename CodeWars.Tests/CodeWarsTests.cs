using FluentAssertions;
using Kats.CodeWars;
using Xunit;

namespace CodeWars.Tests;

public class CodeWarsTests
{
    [Theory]
    [InlineData(1021, 2110)]
    [InlineData(123456789, 987654321)]
    [InlineData(15, 51)]
    public void should_reorder_digits(int input, int expected)
    {
        DescendingOrder.OrderDigitsDesc(input).Should().Be(expected);
    }
}
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

    [Theory]
    [InlineData("is2 Thi1s T4est 3a", "Thi1s is2 3a T4est")]
    [InlineData("4of Fo1r pe6ople g3ood th5e the2", "Fo1r the2 g3ood 4of th5e pe6ople")]
    [InlineData("", "")]
    public void should_order_words_by_number(string input, string expected)
    {
        StringSorter.Order(input).Should().Be(expected);
    }
}
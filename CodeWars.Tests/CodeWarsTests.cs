using System.Collections.Generic;
using CodeWars.Csharp;
using CodeWars.Csharp.MultiplesOf3And5;
using FluentAssertions;
using Kats.CodeWars;
using Kats.CodeWars.Csharp;
using Xunit;

namespace Kats.CodeWars.Tests;

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

    [Theory]
    [InlineData("1234", true)]
    [InlineData("12345", false)]
    [InlineData("123456", true)]
    [InlineData("123a", false)]
    [InlineData("1234567", false)]
    [InlineData("123d45", false)]
    public void should_validate_pin(string input, bool expected)
    {
        Validator.ValidatePIN(input).Should().Be(expected);
    }

    [Theory]
    [InlineData("1234", true)]
    [InlineData("12345", false)]
    [InlineData("123456", true)]
    [InlineData("123a", false)]
    [InlineData("1234567", false)]
    [InlineData("123d45", false)]
    [InlineData("1234 ", false)]
    public void should_validate_pin_with_regex(string input, bool expected)
    {
        Validator.ValidatePINWithRegex(input).Should().Be(expected);
    }

    [Fact]
    public void should_count_ppl_who_missed_their_stop()
    {
        var inOutPeoplePerStop = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
        var tiredPpl = 21;

        BusSleepers.GetSleepingPeopleCount(inOutPeoplePerStop).Should().Be(tiredPpl);
    }

    [Theory]
    [InlineData("man i need a taxi up to ubud", "taxi")]
    [InlineData("take me to semynak", "semynak")]
    public void should_return_the_word_with_largest_score(string input, string expected)
    {
        WordsComparator.GetLargestScoringWord(input).Should().Be(expected);   
        WordsComparator.GetLargestScoringWordFunc(input).Should().Be(expected);    
    }

    [Theory]
    [InlineData(10, 23)]
    public void should_sum_multiples_of_3_and_5(int input, int expected)
    {
        MultiplesOf3And5.SumDivisiblesBy3And5(10).Should().Be(expected);
    }

    [Theory]
    [InlineData("xox", false)]
    [InlineData("", true)]
    [InlineData("xoox", true)]
    [InlineData("xoxox", false)]
    public void should_compare_x_to_o(string input, bool expected)
    => Izzy.AreXsEqualToOx(input).Should().Be(expected);
    
    [Theory]
    [InlineData("time bus3521;#25", "time")]
    [InlineData("hey $29$*2", "hey")]
    [InlineData("4dog^%$24&!!", "dog")]
    public void should_find_longest_word(string input, string expected)
    => Izzy.FindLongestWord(input).Should().Be(expected);
}
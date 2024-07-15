using FluentAssertions;
using Solution;

namespace SolutionTest;

public class SnailSorterTests
{
    [Fact]
    public void ShouldReturnEmptyArray()
    {
        var input = new int[][] { };
        var expected = new int[] { };

        var actual = SnailSorter.GetSnail(input);
        actual.Should().Equal(expected);
    }
    
    [Fact]
    public void ShouldGetProperSnail1()
    {
        var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
        var expected = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

        var actual = SnailSorter.GetSnail(input);
        actual.Should().Equal(expected);
    }

    [Fact]
    public void ShouldGetProperSnail2()
    {
        var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 8, 9, 4 }, new int[] { 7, 6, 5 } };
        var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var actual = SnailSorter.GetSnail(input);
        actual.Should().Equal(expected);
    }
}
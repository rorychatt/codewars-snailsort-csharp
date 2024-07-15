using FluentAssertions;
using Solution;

namespace SolutionTest;

public class SnailSorterTests
{
    [Fact]
    public void ShouldReturnEmptyArrayNonLinq()
    {
        var input = new int[][] { };
        var expected = new int[] { };

        var actual = SnailSorter.GetSnailNonLinq(input);
        actual.Should().Equal(expected);
    }

    [Fact]
    public void ShouldGetProperSnail1NonLinq()
    {
        var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
        var expected = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

        var actual = SnailSorter.GetSnailNonLinq(input);
        actual.Should().Equal(expected);
    }

    [Fact]
    public void ShouldGetProperSnail2NonLinq()
    {
        var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 8, 9, 4 }, new int[] { 7, 6, 5 } };
        var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var actual = SnailSorter.GetSnailNonLinq(input);
        actual.Should().Equal(expected);
    }

        [Fact]
    public void ShouldReturnEmptyArrayLinq()
    {
        var input = new int[][] { };
        var expected = new int[] { };

        var actual = SnailSorter.GetSnailLinq(input);
        actual.Should().Equal(expected);
    }

    [Fact]
    public void ShouldGetProperSnail1Linq()
    {
        var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
        var expected = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

        var actual = SnailSorter.GetSnailLinq(input);
        actual.Should().Equal(expected);
    }

    [Fact]
    public void ShouldGetProperSnail2Linq()
    {
        var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 8, 9, 4 }, new int[] { 7, 6, 5 } };
        var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var actual = SnailSorter.GetSnailLinq(input);
        actual.Should().Equal(expected);
    }

}
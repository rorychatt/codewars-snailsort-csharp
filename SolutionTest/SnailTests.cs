namespace SolutionTest;

public class UnitTest1
{
    [Theory]
    [InlineData(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }, new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 })]
    [InlineData(new int[][] { new int[] { 1, 2, 3 }, new int[] { 8, 9, 4 }, new int[] { 7, 6, 5 } }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
    public void ShouldGetProperSnail(int[][] matrixInput, int[] expected)
    {
        
    }
}
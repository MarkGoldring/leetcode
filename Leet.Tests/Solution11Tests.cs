public class Solution11Tests
{
    [Theory]
    [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new[] { 1, 1 }, 1)]
    [InlineData(new[] { 4, 3, 2, 1, 4 }, 16)]
    [InlineData(new[] { 1, 2, 1 }, 2)]
    public void MaxArea_ReturnsExpectedArea(int[] height, int expected)
    {
        var actual = Solution11.MaxArea(height);

        Assert.Equal(expected, actual);
    }
}

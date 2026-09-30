public static class Solution0007Tests
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    public static void Reverse_ShouldReturnExpectedResult(int x, int expected)
    {
        var result = Solution0007.Reverse(x);
        Assert.Equal(expected, result);
    }
}
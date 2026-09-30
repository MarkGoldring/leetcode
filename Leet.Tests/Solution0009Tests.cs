public static class Solution0009Tests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(0, true)]
    public static void IsPalindrome_ShouldReturnExpectedResult(int x, bool expected)
    {
        var result = Solution0009.IsPalindrome(x);
        Assert.Equal(expected, result);
    }
}
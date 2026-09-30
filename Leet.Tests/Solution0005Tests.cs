public static class Solution0005Tests
{
    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    [InlineData("a", "a")]
    [InlineData("ac", "a")]
    public static void LongestPalindrome_ShouldReturnExpectedResult(string s, string expected)
    {
        var result = Solution0005.LongestPalindrome(s);
        Assert.Equal(expected, result);
    }
}
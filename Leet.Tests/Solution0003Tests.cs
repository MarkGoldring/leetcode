public static class Solution0003Tests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData(" ", 1)]
    public static void LengthOfLongestSubstring_ShouldReturnExpectedResult(string s, int expected)
    {
        var result = Solution0003.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }
}

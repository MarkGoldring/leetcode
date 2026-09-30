public static class Solution0008Tests
{
    [Theory]
    [InlineData("42", 42)]
    [InlineData("   -42", -42)]
    [InlineData("4193 with words", 4193)]
    [InlineData("words and 987", 0)]
    [InlineData("-91283472332", -2147483648)]
    public static void MyAtoi_ShouldReturnExpectedResult(string s, int expected)
    {
        var result = Solution0008.MyAtoi(s);
        Assert.Equal(expected, result);
    }
}
public static class Solution0006Tests
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    public static void Convert_ShouldReturnExpectedResult(string s, int numRows, string expected)
    {
        var result = Solution0006.Convert(s, numRows);
        Assert.Equal(expected, result);
    }
}
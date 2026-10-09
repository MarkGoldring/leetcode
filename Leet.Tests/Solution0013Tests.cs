public class Solution13Tests
{
    [Theory]
    [InlineData("MMMDCCXLIX", 3749)]
    [InlineData("III", 3)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt_ReturnsExpectedValue(string numerals, int value)
    {
        var actual = Solution0013.RomanToInt(numerals);
        Assert.Equal(value, actual);
    }
}

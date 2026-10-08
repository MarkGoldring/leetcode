public class Solution12Tests
{
    [Theory]
    [InlineData(3749, "MMMDCCXLIX")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    public void IntToRoman_ReturnsExpectedRomanNumerals(int num, string numerals)
    {
        var actual = Solution12.IntToRoman(num);
        Assert.Equal(numerals, actual);
    }
}

public class Solution17Tests
{
    [Fact]
    public void LetterCombinations_TwoDigits_ReturnsExpectedValue()
    { 
       List<string> expected = ["ad","ae","af","bd","be","bf","cd","ce","cf"]; 
       var actual = Solution0017.LetterCombinations("23"); 
       Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void LetterCombinations_OneDigit_ReturnsExpectedValue()
    { 
       List<string> expected = ["a","b","c"];
       var actual = Solution0017.LetterCombinations("2"); 
       Assert.Equal(expected, actual);
    }
}

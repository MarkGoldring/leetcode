using System.Collections.Immutable;
using System.ComponentModel;
using Microsoft.VisualBasic;

public static class Solution0017 {
   private static readonly Dictionary<char, List<string>> _digitLetters = new() 
   {
      ['1'] = [],
      ['2'] = ["a", "b", "c"],
      ['3'] = ["d", "e", "f"],
      ['4'] = ["g", "h", "i"],
      ['5'] = ["j", "k", "l"],
      ['6'] = ["m", "n", "o"],
      ['7'] = ["p", "q", "r", "s"],
      ['8'] = ["t", "u", "v"],
      ['9'] = ["w", "x", "y", "z"]
   };

   public static IList<string> LetterCombinations(string digits)
   {
      if(string.IsNullOrWhiteSpace(digits))
      {
         return [];
      }
      // initialize list
      var list = _digitLetters[digits[0]];
      for(var i = 1; i < digits.Length; i++)
      {
         list = Expand(list, digits[i]);
      }
      return list;
   }

   private static List<string> Expand(IList<string> list, char digit)
   {
      List<string> output = new List<string>();
      var letters = _digitLetters[digit];
      foreach(var item in list)
      {
         foreach(var letter in letters)
         {
            {
               output.Add($"{item}{letter}");       
            }
         }         
      }
      return output;
   }

}

public static class Solution0013 {
    public static int RomanToInt(string s) {

      int value = 0;
      var singles = new Dictionary<string, int> {
         {"I", 1},
         {"V", 5},
         {"X", 10},
         {"L", 50},
         {"C", 100},
         {"D", 500},
         {"M", 1000}
      };
      var pairs = new Dictionary<string, int> {
         {"IV", 4},
         {"IX", 9},
         {"XL", 40},
         {"XC", 90},
         {"CD", 400},
         {"CM", 900}
      };

      // iterate string, looking ahead for known sequences
      for(var i = 0; i < s.Length; i++) {
         // look ahead for known pair numeral
         if(i < s.Length - 1 && pairs.TryGetValue(s.Substring(i, 2), out var v)) {
            value += v;
            i++;
         } else if(singles.TryGetValue(s.Substring(i, 1), out var n)) {
            // look for regular numeral
            value += n;
         }
      }

      return value;
    }
}

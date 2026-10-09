public static class Solution0013 {
    public static int RomanToInt(string s) {

      // iterate and examine current char and next 
      int value = 0;
      for(var i = 0; i < s.Length; i++) {
         char cur = s[i];
         char next = i + 1 < s.Length ? s[i + 1] : '\0';
         var (val, skip) = (cur, next) switch {
            ('I', 'V') => (4, 1),
            ('I', 'X') => (9, 1),
            ('X', 'L') => (40, 1),
            ('X', 'C') => (90, 1),
            ('C', 'D') => (400, 1),
            ('C', 'M') => (900, 1),
            ('I', _) => (1, 0),
            ('V', _) => (5, 0),
            ('X', _) => (10, 0),
            ('L', _) => (50, 0),
            ('C', _) => (100, 0),
            ('D', _) => (500, 0),
            ('M', _) => (1000, 0),
            _ => (0, 0)
         };
         value += val;
         i += skip;
      }

      return value;
    }
}

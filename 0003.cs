public static class Solution0003 {
    public static int LengthOfLongestSubstring(string s) {
        var longestSubstring = 0;
        var hash = new HashSet<int>();
        for(var x = 0; x < s.Length; x++) {
            hash.Clear();
            int currentLength = 0;
            for (var y = x; y < s.Length; y++) {
                var ch = s[y];
                if(hash.Contains(ch)) {
                   break; 
                }
                hash.Add(ch);
                currentLength += 1;
                if(currentLength > longestSubstring)
                {
                    longestSubstring = currentLength;
                }
            }
        }
        return longestSubstring;
    }
}

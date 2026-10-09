using System.Text;

public static class Solution0014 {
    public static string LongestCommonPrefix(string[] strs) {
      
      // using Linq
      var sb = new StringBuilder();
      var minLength = strs.Min(x => x.Length);
      for(int i = 0; i < minLength; i++) {
         var ch = strs[0][i];
         if(strs.All(x => x[i] == ch)) {
            sb.Append(ch);
         } else {
            break;
         }
      }

      return sb.ToString();
    }
}

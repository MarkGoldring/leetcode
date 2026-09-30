using System.Text;

public static class Solution0006 {
    public static string Convert(string s, int numRows) {

        // quit early if single row
        if(numRows == 1) {
            return s;
        }

        // iterate string and zigzag into the rows
        int r = 0;
        var movingDown = true;
        var sb = new StringBuilder();
        var rows = new StringBuilder[numRows];
        foreach(var ch in s) {
            if(rows[r] is null) {
                rows[r] = new StringBuilder();
            }
            rows[r].Append(ch);
            // move to next matrix cell
            if(movingDown && r + 1 == numRows) {
                // hit bottom - change direction
                movingDown = false;
            } else if (!movingDown && r == 0) {
                movingDown = true;
            }
            r = r + (movingDown ? 1 : -1);
        }

        // concatenate rows and return result
        for(var i = 0; i < numRows; i++) {
            sb.Append(rows[i]);
        }
        return sb.ToString();   
    }
}

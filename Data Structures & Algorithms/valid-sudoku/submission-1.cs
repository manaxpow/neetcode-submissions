public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var set = new HashSet<string>();

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                int val = board[i][j];
                if (val == '.')
                    continue;
                if (!set.Add($"{val} in row {i}"))
                    return false;
                if (!set.Add($"{val} in col {j}"))
                    return false;
                int fromCol = j / 3 * 3 + 1;
                if (!set.Add($"{val} in square {i/3} and {j/3}"))
                    return false;
            }
        }
        return true;
    }
}

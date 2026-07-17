public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> cols = new();
        Dictionary<int, HashSet<char>> rows = new();
        Dictionary<string, HashSet<char>> squares = new();

        for(int r = 0; r < 9; r++)
        {
            for(int c = 0; c < 9; c++)
            {
                if(board[r][c] == '.') continue;

                string squareKey = (r / 3) + "," + (c / 3);

                if((rows.ContainsKey(r) && rows[r].Contains(board[r][c])) ||
                    (cols.ContainsKey(c) && cols[c].Contains(board[r][c])) ||
                    (squares.ContainsKey(squareKey) && squares[squareKey].Contains(board[r][c])))
                        return false;
                
                if(!rows.ContainsKey(r)) rows[r] = new();
                if(!cols.ContainsKey(c)) cols[c] = new();
                if(!squares.ContainsKey(squareKey)) squares[squareKey] = new();

                rows[r].Add(board[r][c]);
                cols[c].Add(board[r][c]);
                squares[squareKey].Add(board[r][c]);
            }
        }
        return true;
    }
}

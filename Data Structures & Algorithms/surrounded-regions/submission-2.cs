public class Solution {
    private readonly int[][] directions = new int[][]
    {
        new int[]{1, 0}, new int[]{0, 1},
        new int[]{-1, 0}, new int[]{0, -1},
    };
    int ROWS;
    int COLS;
    public void Solve(char[][] board) {
        ROWS = board.Length;
        COLS = board[0].Length;

        for(int r = 0; r < ROWS; r++)
        {
            for(int c = 0; c < COLS; c++)
            {
                if(board[r][c] == 'O' && (r == 0 || r == ROWS - 1 || c == 0 || c == COLS -1))
                DfsCapture(r, c, board);
            }
        }

          for(int r = 0; r < ROWS; r++)
        {
            for(int c = 0; c < COLS; c++)
            {
                if(board[r][c] == 'O')
                    board[r][c] = 'X';
            }
        }

          for(int r = 0; r < ROWS; r++)
        {
            for(int c = 0; c < COLS; c++)
            {
                if(board[r][c] == 'T')
                    board[r][c] = 'O';
            }
        }

    }

    private void DfsCapture(int r, int c, char[][] board)
    {
        if(r < 0 || c < 0 || 
        r == ROWS || c == COLS ||
         board[r][c] != 'O')
            return;
        
        board[r][c] = 'T';
        foreach(var dir in directions){
            DfsCapture(r + dir[0], c + dir[1], board);
        }
    }
}

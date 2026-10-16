public class Solution {
    private readonly int[][] directions = new int[][]
    {
        new int[]{1, 0}, new int[]{-1, 0},
        new int[]{0, 1}, new int[]{0, -1}
    };

    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        var q = new Queue<int[]>();

        int freshOranges = 0;

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(grid[r][c] == 2)
                    q.Enqueue([r, c]);
                else if(grid[r][c] == 1)
                    freshOranges++;
            }
        }

        if(freshOranges == 0)
            return 0;

        int minutes = 0;

        while(q.Count > 0)
        {
            int currrentLevelSize = q.Count;
            bool rottedSomething = false;

            for(int i = 0; i < currrentLevelSize; i++)
            {
                int[] node = q.Dequeue();

                int row = node[0];
                int col = node[1];

                foreach(var dir in directions)
                {
                    int newRow = row + dir[0];
                    int newCol = col + dir[1];

                    if (
                        newRow >= 0 &&
                        newCol >= 0 &&
                        newRow < rows &&
                        newCol < cols &&
                        grid[newRow][newCol] == 1
                    )
                    {
                        grid[newRow][newCol] = 2;

                        freshOranges--;

                        q.Enqueue([newRow, newCol]);

                        rottedSomething = true;
                    }
                }

            }
            if(rottedSomething)
            {
                minutes++;
            }
        }
        if(freshOranges > 0)
        {
            return -1;
        }
        return minutes;

    }
}
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        bool[,] rows = new bool[9,9];
        bool[,] cols = new bool[9,9];
        bool[,] boxes = new bool[9,9];

        for(int r = 0 ; r < board.Length; r++){
            for(int c = 0; c < board[r].Length; c++ ){

                char cell = board[r][c];
                if(cell == '.') continue;

                int digit = cell - '1';
                int boxIndex = (r/3) * 3 + (c/3);

                if(rows[r,digit] || cols[c,digit] ||boxes[boxIndex,digit] ){
                    return false;
                }

                rows[r,digit] = true;
                cols[c,digit] = true;
                boxes[boxIndex,digit] = true;
            }
        }

        return true;
    }
}

public class Solution {
    public bool IsValidSudoku(char[][] board) {

        for(int i = 0; i < 9; i++) {
            if(
                !IsValidRow(GetRowAtIndex(i, board)) ||
                !IsValidColumn(GetColumnAtIndex(i, board))
            ) {
                return false;
            }
        }

        for(int i = 0; i < 9; i += 3) {
            for(int j = 0; j < 9; j += 3) {
                if(!IsValidBox(GetBox(i, j, board))) return false;
            }
        }

        return true;
    }

    private bool IsValidRow(char[] row) {
        HashSet<char> seen = new HashSet<char>();

        foreach(char c in row) {
            if(c == '.') continue;

            if(!seen.Add(c))
                return false;
        }

        return true;
    }

    private bool IsValidColumn(char[] column) {
        return IsValidRow(column);
    }

    private bool IsValidBox(char[][] box) {
        return IsValidRow(MakeBoxRow(box));
    }

    private char[] GetRowAtIndex(int i, char[][] board) {
        return board[i];
    }

    private char[] GetColumnAtIndex(int i, char[][] board) {
        char[] column = new char[9];

        // Fixed: initialize j and increment j instead of i
        for(int j = 0; j < 9; j++) {
            char[] row = board[j];
            column[j] = row[i];
        }

        return column;
    }

    private char[][] GetBox(int i, int j, char[][] board) {
        // Fixed: jagged array initialization
        char[][] box = new char[3][];

        for(int k = 0; k < 3; k++) {
            char[] row = GetRowAtIndex(i + k, board);

            char[] slicedThree = row[j..(j + 3)];

            box[k] = slicedThree;
        }

        return box;
    }

    private char[] MakeBoxRow(char[][] board) {
        // Fixed: missing new
        char[] row = new char[9];

        // Fixed: missing int declaration
        int count = 0;

        for(int i = 0; i < 3; i++) {
            for(int j = 0; j < 3; j++) {
                row[count] = board[i][j];
                count++;
            }
        }

        return row;
    }
}
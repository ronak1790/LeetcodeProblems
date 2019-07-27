using System;
namespace LeetcodeProblems {
    public class AvailableCapturesForRook {
        public void MainMethod() {
            char[,] input =  {
                { '.','.','.','.','.','.','.','.'},
                { '.','.','.','.','.','.','.','.'},
                { '.','.','.','.','.','.','.','.'},
                { '.','.','.','R','.','.','.','.'},
                { '.','.','.','.','.','.','.','.'},
                { '.','.','.','.','.','.','.','.'},
                { '.','.','.','.','.','.','.','.'},
                { '.','.','.','.','.','.','.','.'}
            };



            int output = AvailableCapturesForRookMethod(input);
            Console.WriteLine(output);

        }

        public int AvailableCapturesForRookMethod(char[,] board) {
            int count = 0;
            int iLoc = -1;
            int jLoc = -1;

            // find location of Rook
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (board[i, j] == 'R') {
                        iLoc = i;
                        jLoc = j;
                        break;
                    }
                }
            }

            // Up-- constant j
            if (iLoc > 0) {
                for (int k = iLoc - 1; k > -1; k--) {
                    if (board[k, jLoc] == 'p') {
                        count++;
                        break;
                    } else if (board[k, jLoc] == 'B') {
                        break;
                    }
                }
            }

            //right -- Constant i 
            if (jLoc < 7) {
                for (int k = jLoc + 1; k < 8; k++) {
                    if (board[iLoc, k] == 'p') {
                        count++;
                        break;
                    } else if (board[iLoc, k] == 'B') {
                        break;
                    }
                }
            }

            //bottom -- Constant j
            if (jLoc < 7) {
                for (int k = iLoc + 1; k < 8; k++) {
                    if (board[k, jLoc] == 'p') {
                        count++;
                        break;
                    } else if (board[k, jLoc] == 'B') {
                        break;
                    }
                }
            }

            // left -- Constant i
            if (iLoc > 0) {
                for (int k = jLoc - 1; k > -1; k--) {
                    if (board[iLoc, k] == 'p') {
                        count++;
                        break;
                    } else if (board[iLoc, k] == 'B') {
                        break;
                    }
                }
            }

            return count;
        }

        public int AvailableCapturesForRookMethod11(char[][] board) {
            int count = 0;
            int iLoc = -1;
            int jLoc = -1;

            // find location of Rook
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    if (board[i][j] == 'R') {
                        iLoc = i;
                        jLoc = j;
                        break;
                    }
                }
            }

            // Up-- constant j
            if (iLoc > 0) {
                for (int k = iLoc - 1; k > -1; k--) {
                    if (board[k][jLoc] == 'p') {
                        count++;
                        break;
                    } else if (board[k][jLoc] == 'B') {
                        break;
                    }
                }
            }

            //right -- Constant i 
            if (jLoc < 7) {
                for (int k = jLoc + 1; jLoc < 8; k++) {
                    if (board[iLoc][k] == 'p') {
                        count++;
                        break;
                    } else if (board[iLoc][k] == 'B') {
                        break;
                    }
                }
            }

            //bottom -- Constant j
            if (jLoc < 7) {
                for (int k = iLoc + 1; k < 8; k++) {
                    if (board[k][jLoc] == 'p') {
                        count++;
                        break;
                    } else if (board[k][jLoc] == 'B') {
                        break;
                    }
                }
            }

            // left -- Constant i
            if (iLoc > 0) {
                for (int k = jLoc - 1; k > -1; k--) {
                    if (board[iLoc][k] == 'p') {
                        count++;
                        break;
                    } else if (board[iLoc][k] == 'B') {
                        break;
                    }
                }
            }

            return count;
        }

    }
}

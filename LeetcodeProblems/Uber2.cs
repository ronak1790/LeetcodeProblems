using System;
namespace LeetcodeProblems {
    // Move numbers in diamond shaper as per rotation specified.


    public class Uber2 {
        public void MainMethod() {


            int[,] input = {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15},
                {16,17,18,19,20},
                {21,22,23,24,25}
            };
            int n = 5;
            int rotation = 2;

            int[,] output = Uber2Method(input, n, rotation);

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write(output[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        public int[,] Uber2Method(int[,] input, int n, int rotation) {

            int m = n / 2; // middle

            for (int i = 0; i < rotation; i++) {
                int top = input[0, m];
                int right = input[m, n - 1];
                int bottom = input[n - 1, m];
                int left = input[m, 0];

                input[0, m] = left; // take value from left and keep it in top
                input[m, n - 1] = top; // take value from top and keep it in right
                input[n - 1, m] = right; // take value from right;
                input[m, 0] = bottom; // take value from bottom and keep it in left
            }
            return input;
        }
    }
}

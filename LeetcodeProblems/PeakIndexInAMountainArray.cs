using System;
namespace LeetcodeProblems {
    public class PeakIndexInAMountainArray {
        public void MainMethod() {

            int[] input = { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 };

            int output = PeekIndexMethod(input);
            Console.WriteLine(output);
        }

        public int PeekIndexMethod(int[] A) {

            int highestIndex = 0;
            for (int i = 1; i < A.Length; i++) {
                if (A[i] > A[highestIndex]) {
                    highestIndex = i;
                }
            }

            return highestIndex;
        }
    }
}

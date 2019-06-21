using System;
namespace LeetcodeProblems {
    public class SquaresOfASortedArray {
        public void MainMethod() {
            int[] input = { -4, -1, 0, 3, 10 };
            var output = SquaresOfSortedArraySolve(input);
            foreach (var item in output) {
                Console.WriteLine(item);
            }
        }

        public static int[] SquaresOfSortedArraySolve(int[] A) {
            int[] retArray = new int[A.Length];

            int count = 0;
            foreach (var a in A) {
                var square = a * a;
                retArray[count] = square;
                count++;
            }

            Array.Sort(retArray);

            return retArray;
        }
    }
}

using System;
namespace LeetcodeProblems {

    //Given an array A of non-negative integers, half of the integers in A are odd, and half of the integers are even.
    //Sort the array so that whenever A[i] is odd, i is odd; and whenever A[i] is even, i is even.
    //You may return any answer array that satisfies this condition.
    //Example 1:
    //Input: [4,2,5,7]
    //Output: [4,5,2,7]
    //Explanation: [4,7,2,5], [2,5,4,7], [2,7,4,5] would also have been accepted.

    public class SortArrayByParity {
        public void MainMethod() {
            int[] input = { 648, 831, 560, 986, 192, 424, 997, 829, 897, 843 };
            var output = SortArryByParitySolve(input);
            foreach (var item in output) {
                Console.WriteLine(item);
            }
        }

        public int[] SortArryByParitySolve(int[] arr) {

            int[] retArr = new int[arr.Length];

            int i = 0;
            foreach (var item in arr) {
                if (item % 2 == 0) {
                    retArr[i] = item;
                    i = i + 2;
                }
            }
            i = 1;
            foreach (var item in arr) {
                if (item % 2 == 1) {
                    retArr[i] = item;
                    i = i + 2;
                }
            }
            return retArr;


        }

    }

}

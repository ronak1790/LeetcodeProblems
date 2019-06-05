using System;
namespace LeetcodeProblems {

    //Summary
    //Returns minimum difference between any pair 

    public class ProgramMinDiffBetweenTwoElements {

        public void ProgramMinDiffBetweenTwoElementsMain() {

            int[] arr = new int[5] { 2, 9, 30, 15, 100 };
            Array.Sort(arr);

            int diff = int.MaxValue;
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++) {
                if (arr[i + 1] - arr[i] < diff) {
                    diff = arr[i + 1] - arr[i];
                }
            }

            Console.WriteLine("Minimum difference between two elements in array is " + diff);
        }




        public ProgramMinDiffBetweenTwoElements() {
        }
    }
}

using System;
namespace LeetcodeProblems {
    public class ArrayPartition {
        public void MainMethod() {

            int[] nums = { 1, 2, 4, 3 };
            int output = ArrayPairSum(nums);
            Console.WriteLine(output);

        }

        public int ArrayPairSum(int[] nums) {
            int sum = 0;

            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i += 2) {
                sum += Math.Min(nums[i], nums[i + 1]);

            }

            return sum;
        }
    }
}

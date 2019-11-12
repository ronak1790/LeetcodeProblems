using System;
namespace LeetcodeProblems {
    public class DistributeCandies {
        public void MainMethod() {

            int[] candies = { 0, 0, 14, 0, 10, 0, 0, 0 };
            int sisterCandies = DistributeCandiesMethod(candies);
            Console.WriteLine(sisterCandies);
        }

        public int DistributeCandiesMethod(int[] candies) {



            Array.Sort(candies);
            int count = 1;
            for (int i = 1; i < candies.Length && count < candies.Length / 2; i++)
                if (candies[i] > candies[i - 1])
                    count++;

            return count;
        }
    }
}

using System;
namespace LeetcodeProblems {
    public class HammingDistance {
        public void MainMethod() {

            int output = HammindDistanceMethod(1, 246);
            Console.WriteLine(output);
        }

        public static int HammindDistanceMethod(int x, int y) {

            int hammingDistance = 0;
            int xor = x ^ y;
            string bitWiseRep = Convert.ToString(xor, 2);
            foreach (char ch in bitWiseRep)
                if (ch == '1') hammingDistance++;
            return hammingDistance;



        }
    }
}

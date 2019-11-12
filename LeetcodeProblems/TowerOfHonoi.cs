using System;
namespace LeetcodeProblems {
    public class TowerOfHonoi {
        public void MainMethod() {

            TOH(3, 1, 2, 3);



        }

        // n is number of Disk,
        // A, B C is name of Tower
        public static void TOH(int n, int A, int B, int C) {

            if (n > 0) {
                TOH(n - 1, A, C, B);
                Console.WriteLine(A + "-" + C);
                TOH(n - 1, B, A, C);

            }

        }


    }
}

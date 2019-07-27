using System;
namespace LeetcodeProblems {
    public class FibonacciNumber {
        public void MainMethod() {

            int number = 14;

            int fibonacciNumber = FindFibonacciNumber(number);
            Console.WriteLine(fibonacciNumber);

        }


        public static int FindFibonacciNumber(int n) {

            int firstNumber = 0;
            int secondNumber = 1;
            int returnVal = 0;
            int zero = 0;
            if (n > 1) {

                for (int i = 2; i <= n; i++) {
                    int temp = 0;
                    temp = firstNumber + secondNumber;
                    firstNumber = secondNumber;
                    secondNumber = temp;
                }
                returnVal = secondNumber;

            } else if (n == 0) {
                returnVal = zero;

            } else if (n == 1) {
                returnVal = zero;
            }

            return returnVal;


        }
    }
}

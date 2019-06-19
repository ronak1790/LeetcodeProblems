using System;
namespace LeetcodeProblems {


    //Given a 32-bit signed integer, reverse digits of an integer.
    //Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
    //For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.


    public class ReverseInteger {
        public void ReverseIntegerMain() {

            //int number = 345;
            int number = int.MaxValue; // 2,147,483,647
            //int number = int.MinValue; // -2,147,483,648

            int reversedNumber = ReverseIntegerNumber(number);
            Console.WriteLine(reversedNumber);

        }


        public static int ReverseIntegerNumber(int number) {
            int reverse = 0;

            while (number != 0) {

                int pop = number % 10;
                number = number / 10;

                if (reverse > int.MaxValue / 10 || (reverse == int.MaxValue / 10 && pop > 7)) return 0;
                if (reverse < int.MinValue / 10 || (reverse == int.MinValue / 10 && pop < -8)) return 0;

                reverse = reverse * 10 + pop;


            }
            return reverse;

        }
    }
}

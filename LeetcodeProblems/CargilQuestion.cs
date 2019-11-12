using System;
namespace LeetcodeProblems {
    public class CargilQuestion {

        public static void CargilQuestionMain() {
            int[] array = { -5, 4, -2, 3, 1, -1, -6, -1, 0, 5 };
            bool continueCalculation = true;

            int x = 1;

            while (continueCalculation) {
                int sum = x;
                for (int i = 0; i < array.Length; i++) {
                    sum = sum + array[i];
                    if (sum < 1) {
                        x++;
                        continueCalculation = true;
                        break;

                    } else {
                        continueCalculation = false;
                    }
                }

                continueCalculation = false;


            }

            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}

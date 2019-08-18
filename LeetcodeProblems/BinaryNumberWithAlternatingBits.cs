using System;
namespace LeetcodeProblems {
    public class BinaryNumberWithAlternatingBits {
        public void MainMethod() {

            int n = 5;
            Console.WriteLine(HasAlternatingBits(n));


        }

        public bool HasAlternatingBits(int n) {
            bool retVal = true;
            string str = Convert.ToString(n, 2).ToString();
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length - 1; i++) {
                char a = charArray[i];
                char b = charArray[i + 1];
                if (a == b) {
                    retVal = false;
                    break;
                }
            }


            return retVal;

        }
    }
}

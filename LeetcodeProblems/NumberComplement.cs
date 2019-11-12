using System;
using System.Text;
namespace LeetcodeProblems {
    public class NumberComplement {
        public void MainMethod() {
            int num = 5;
            int output = FindComplement(num);
            Console.WriteLine(output);
        }

        public int FindComplement(int num) {
            StringBuilder opposite = new StringBuilder();
            char[] bits = Convert.ToString(num, 2).ToCharArray();

            foreach (var bit in bits) {
                if (bit == '0') {
                    opposite.Append('1');
                } else if (bit == '1') {
                    opposite.Append('0');
                }
            }

            return Convert.ToInt32(opposite.ToString(), 2);
        }
    }
}

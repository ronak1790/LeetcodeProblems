using System;
namespace LeetcodeProblems {
    public class LengthOfLastWord {
        public void MainMethod() {

            string input = "a ";
            int ans = LengthOfLastWordMethod(input);
            Console.WriteLine(ans);

        }

        public int LengthOfLastWordMethod(string s) {

            string[] array = s.Split(' ');
            if (array.Length > 0) { }
            string str = array[array.Length - 1];
            return str.Length;



        }
    }
}

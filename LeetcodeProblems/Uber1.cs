using System;
namespace LeetcodeProblems {


    // Draw frame of specified size
    public class Uber1 {
        public void MainMethod() {

            int n = 6;
            string[] output = Uber1Method(n);
            foreach (var item in output) {
                Console.WriteLine(item);
            }
        }

        public string[] Uber1Method(int n) {

            string[] output = new string[n];

            for (int i = 0; i < n; i++) {

                string s = string.Empty;

                for (int j = 0; j < n; j++) {

                    if (i == 0 || i == n - 1) {
                        s = s + "*";
                    } else if ((i != 0 && i != n - 1) && (j == 0 || j == n - 1)) {
                        s = s + "*";
                    } else {
                        s = s + " ";
                    }
                }

                output[i] = s;

            }
            return output;
        }
    }
}

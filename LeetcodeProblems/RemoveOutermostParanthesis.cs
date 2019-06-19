using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeProblems {
    public class RemoveOutermostParanthesis {
        public void MainMethod() {

            string input = "(())(())(()(()))";
            //string input = "(())";
            string output = RemoveParanthesis(input);
            Console.Write(output);

        }

        public static string RemoveParanthesis(string s) {

            StringBuilder retVal = new StringBuilder();
            char[] charArray = s.ToCharArray();
            int openerCount = 0;

            foreach (var c in charArray) {

                if (c == '(' && openerCount == 0) {
                    openerCount++;
                } else if (c == '(' && openerCount > 0) {
                    openerCount++;
                    retVal.Append(c);
                } else if (c == ')' && openerCount > 0) {
                    openerCount--;
                    if (openerCount != 0) {
                        retVal.Append(c);
                    }
                }
            }

            return retVal.ToString();

        }

    }
}

using System;
using System.Linq;
using System.Diagnostics;
using System.Text;
namespace LeetcodeProblems {
    public class GoatLatin {
        public void MainMethod() {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string input = "I speak Goat Latin";
            string output = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa";
            string result = ToGoatLatin(input);
            if (string.Equals(output, result)) {
                Console.WriteLine("Yeah test pass");
            } else Console.WriteLine(result);

            stopwatch.Stop();
            Console.WriteLine("Total time" + stopwatch.ElapsedMilliseconds);
            Console.WriteLine(output + "output");
            Console.WriteLine(result + "result");

        }

        public string ToGoatLatin(string S) {
            //string retString = string.Empty;
            StringBuilder retString = new StringBuilder();
            string[] words = S.Split(' ');
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string aString = "a";
            bool firstTime = true;

            foreach (var word in words) {
                StringBuilder currentWord = new StringBuilder(word);
                char[] letters = currentWord.ToString().ToCharArray();
                char firstChar = char.ToLower(letters[0]);

                bool firstCharIsVowel = vowels.Contains(firstChar);
                if (!firstCharIsVowel) {
                    currentWord.Append(currentWord[0] + "ma");
                    currentWord = currentWord.Remove(0, 1);

                } else {
                    currentWord.Append("ma");
                }

                currentWord.Append(aString);
                aString += "a";

                if (firstTime) {
                    retString.Append(currentWord);
                    firstTime = false;
                } else {
                    retString.Append(" " + currentWord);
                }

            }

            return retString.ToString();

        }
    }
}

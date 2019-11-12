using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Given a string, sort it in decreasing order based on the frequency of characters.
//Input:
//"tree" --> "eert"


namespace LeetcodeProblems {
    public class SortCharacterByFrequency {
        public void SortCharacterByFrequencyMain() {

            FrequencySort("Aabb");

        }

        public static string FrequencySort(string s) {

            string retString = string.Empty;
            Dictionary<char, int> charDic = new Dictionary<char, int>();

            char[] charArray = s.ToCharArray();
            String.Concat(s.OrderBy(c => c));

            foreach (var ch in charArray) {

                if (charDic.ContainsKey(ch)) {
                    charDic[ch] = charDic[ch] + 1;

                } else {
                    charDic.Add(ch, 1);
                }
            }

            int count = -1;
            foreach (var item in charDic.OrderByDescending(t => t.Value)) {
                count = item.Value;

                for (int i = 0; i < count; i++) {
                    retString += item.Key;
                }

                count = -1;

            }

            Console.WriteLine(retString);
            return retString;
        }
    }
}

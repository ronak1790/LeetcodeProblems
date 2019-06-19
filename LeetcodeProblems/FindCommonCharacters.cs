using System;
using System.Collections.Generic;
namespace LeetcodeProblems {
    public class FindCommonCharacters {
        public void MainMethod() {


            string[] input = new string[3] { "bella", "label", "roller" };
            //string[] input = new string[8] { "acabcddd", "bcbdbcbd", "baddbadb", "cbdddcac", "aacbcccd", "ccccddda", "cababaab", "addcaccd" };
            //string[] input = new string[8] { "bbddabab", "cbcddbdd", "bbcadcab", "dabcacad", "cddcacbc", "ccbdbcba", "cbddaccc", "accdcdbb" };
            List<string> output = FineCommonCharacters(input);

            foreach (var item in output) {
                Console.WriteLine(item);
            }

        }


        public static List<string> FineCommonCharacters(string[] arr) {
            List<string> ret = new List<string>();
            Dictionary<char, int> mainDic = new Dictionary<char, int>();
            Dictionary<char, int> subDic = null;
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int arrayLen = arr.Length;

            foreach (var word in arr) {
                char[] charArr = word.ToCharArray();
                subDic = new Dictionary<char, int>();

                foreach (var character in charArr) {
                    int count = 1;
                    if (dic.ContainsKey(character)) {
                        dic.TryGetValue(character, out count);
                        count++;
                        dic[character] = count;
                    } else {
                        dic.Add(character, count);
                    }

                    if (!subDic.ContainsKey(character)) {
                        subDic.Add(character, count);
                    }

                }

                foreach (var subDicItem in subDic) {
                    int count = 1;
                    if (mainDic.ContainsKey(subDicItem.Key)) {
                        mainDic.TryGetValue(subDicItem.Key, out count);
                        count++;
                        mainDic[subDicItem.Key] = count;
                    } else {
                        mainDic.Add(subDicItem.Key, count);
                    }
                }


            }

            foreach (var item in dic) {

                char character = item.Key;
                if (mainDic.ContainsKey(character)) {
                    int mainDicCharCount = 0;
                    mainDic.TryGetValue(character, out mainDicCharCount);

                    if (mainDicCharCount == arrayLen) {
                        int divCount = mainDicCharCount / arrayLen;
                        if (divCount > 0) {
                            for (int i = 0; i < divCount; i++) {
                                ret.Add(item.Key.ToString());
                            }
                        }
                    }

                }
            }

            return ret;
        }
    }
}

using System;
using System.Collections.Generic;
namespace LeetcodeProblems {
    public class UniqueEmailAddresses {
        public void MainMethod() {

            string[] emails = { "test.email+alex@leetcode.com",
                "test.e.mail+bob.cathy@leetcode.com",
                "testemail+david@lee.tcode.com" };

            int output = NumUniqueEmails(emails);
            Console.Write(output);
        }

        public int NumUniqueEmails(string[] emails) {

            char at = '@';
            char plus = '+';

            //string[] uniqueEmails = new string[emails.Length];
            List<string> uniqueEmails = new List<string>();


            foreach (var email in emails) {

                var splitAt = email.Split(at);
                var beforeAt = splitAt[0];
                var splitForPlus = beforeAt.Split(plus);
                var splitAfterPlus = splitForPlus[0];

                var final = splitAfterPlus.Replace(".", "");
                var fullEmail = final + at + splitAt[1];


                if (!uniqueEmails.Contains(fullEmail)) {
                    uniqueEmails.Add(fullEmail);
                }

            }


            return uniqueEmails.Count;
        }
    }
}

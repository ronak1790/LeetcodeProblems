﻿using System;
namespace LeetcodeProblems {

    //Given an array of integers, return indices of the two numbers 
    //such that they add up to a specific target.
    //You may assume that each input would have exactly one solution,
    //and you may not use the same element twice.

    public class ProgramTwoSum {

        public void TwoSumMain() {

            int[] sampleArray = new int[4] { 2, 5, 5, 11 };
            int target = 10;
            int[] foundIndex = TwoSum(sampleArray, target);
            Console.WriteLine(foundIndex[0] + " " + foundIndex[1]);

        }

        public static int[] TwoSum(int[] nums, int target) {
            int[] returnArray = new int[2];
            bool foundSum = false;

            for (int i = 0; i < nums.Length; i++) {
                if (!foundSum) {
                    for (int j = i + 1; j <= nums.Length - 1; j++) {
                        if (nums[i] + nums[j] == target) {
                            returnArray[0] = i;
                            returnArray[1] = j;
                            foundSum = true;
                            break;
                        }
                    }
                } else {
                    break;
                }
            }
            return returnArray;
        }

    }
}

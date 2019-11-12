using System;
namespace LeetcodeProblems {
    public class BinearySearchAlgorithm {
        public void BinearySearchAlgorithmMain() {

            int[] arr = { 3, 6, 8, 12, 14, 17, 25, 29, 31, 36, 42, 47, 53, 55, 62 };
            //int[] arr = { 3, 6, 8, 12, 14, 17, 25 };
            int key = 43;

            //Iterative Way
            int i = BinarySearchIterativeMethod(arr, key);
            if (i == -1) {
                Console.WriteLine("Key not found for Iterative way ");
            } else {
                Console.WriteLine("Key found for Iterative way at Index: " + i);
            }


            // Recursive Way
            int length = arr.Length;
            int low = 1;
            int high = length;

            int x = BinarySearchRecursiveMethod(arr, low, high, key);
            if (x == -1) {
                Console.WriteLine("Key not found for Recursive way");
            } else {
                Console.WriteLine("Key found for Recursive way at Index: " + x);
            }
        }



        public static int BinarySearchIterativeMethod(int[] arr, int key) {

            int length = arr.Length;
            int low = 1;
            int high = length;
            int mid = -1;

            while (low < high) {
                mid = (low + high) / 2;
                if (arr[mid] == key) {
                    return mid;
                }

                if (arr[mid] < key) {
                    low = mid + 1;
                } else {
                    high = mid - 1;
                }
            }

            return -1;

        }

        public static int BinarySearchRecursiveMethod(int[] arr, int low, int high, int key) {


            if (low == high) {
                if (arr[low] == key) {
                    return low;
                } else {
                    return -1;
                }
            } else {
                int mid = (low + high) / 2;
                if (arr[mid] == key) {
                    //Console.WriteLine("Key found for Recursive way at Index: " + mid);
                    return mid;
                }
                if (arr[mid] < key) {
                    //low = mid + 1;
                    return BinarySearchRecursiveMethod(arr, mid + 1, high, key);

                } else {
                    high = mid - 1;
                    return BinarySearchRecursiveMethod(arr, low, mid - 1, key);

                }
            }


        }
    }
}

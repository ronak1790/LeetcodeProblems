using System;
using System.Collections;
using System.Collections.Generic;
namespace LeetcodeProblems {
    public class SearchInBinarySearchTree {
        public void MainMethod() {

            TreeNode root = new TreeNode(50);
            root.left = new TreeNode(17);
            root.left.left = new TreeNode(12);
            root.left.right = new TreeNode(23);
            root.left.left.left = new TreeNode(9);
            root.left.left.right = new TreeNode(14);

            root.right = new TreeNode(72);
            root.right.left = new TreeNode(54);
            root.right.right = new TreeNode(76);
            root.right.left.right = new TreeNode(67);

            int val = 17;

            TreeNode returnNode = SearchBST(root, val);
            Console.WriteLine(returnNode.val);
            Console.WriteLine(returnNode.left.val);
            Console.WriteLine(returnNode.right.val);


        }

        public TreeNode SearchBST(TreeNode root, int val) {


            if (root == null || root.val == val) {
                return root;
            } else if (root.val < val) {
                return SearchBST(root.right, val);
            } else {
                return SearchBST(root.left, val);
            }

        }
    }

    public class TreeNode {

        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) {
            val = x;

        }
    }
}

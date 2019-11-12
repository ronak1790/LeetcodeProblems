//Given the root node of a binary search tree(BST) and a value.
//You need to find the node in the BST that the node's value equals the given value.
//Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.

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



            // Find given Node By Value
            int val = 17;
            TreeNode returnNode = FindNodeByValueInBST(root, val);
            Console.WriteLine("Root Value: " + returnNode.val);
            Console.WriteLine("Left Node Value: " + returnNode.left.val);
            Console.WriteLine("Right Node Value: " + returnNode.right.val);

            // Find min node in Binary Search Tree
            TreeNode minNode = FindMin(root);
            Console.WriteLine("Min Node: " + minNode.val);

            // Find max node in Binary Search Tree
            TreeNode maxNode = FindMax(root);
            Console.WriteLine("Max Node: " + maxNode.val);

            // Find No of Node in Binary Search Tree
            int noOfNode = FindNumberOfNode(root);
            Console.WriteLine("No of Nodes: " + noOfNode);

            // Find height of Tree
            int height = FindHeightOfTree(root);
            Console.WriteLine("Height of Tree: " + height);
        }

        public TreeNode FindNodeByValueInBST(TreeNode root, int val) {

            if (root == null || root.val == val) {
                return root;
            } else if (root.val < val) {
                return FindNodeByValueInBST(root.right, val);
            } else {
                return FindNodeByValueInBST(root.left, val);
            }
        }


        // Find Min Node in BST
        public TreeNode FindMin(TreeNode root) {
            while (root.left != null) {
                root = root.left;
            }
            return root;
        }

        // Find Max Node in BST
        public TreeNode FindMax(TreeNode root) {
            while (root.right != null) {
                root = root.right;
            }
            return root;
        }

        // Find num of Nodes in BST
        int count = 0;
        public int FindNumberOfNode(TreeNode root) {
            //if (root != null) {
            //    count++;
            //} else {
            //    return count;
            //}
            //if (root.left != null) {
            //    FindNumberOfNode(root.left);
            //}
            //if (root.right != null) {
            //    FindNumberOfNode(root.right);
            //}
            //return count;

            if (root == null) {
                return 0;
            }
            return FindNumberOfNode(root.left) + FindNumberOfNode(root.right) + 1;
        }


        public int FindHeightOfTree(TreeNode root) {
            if (root == null) {
                return 0;
            }

            //int lDept = FindHeightOfTree(root.left);
            //int rDept = FindHeightOfTree(root.right);

            //if (lDept > rDept) {
            //    return lDept + 1;
            //} else {
            //    return rDept + 1;
            //}

            int height = (Math.Max(FindHeightOfTree(root.left), FindHeightOfTree(root.right))) + 1;
            return height;

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

    public class BinarySearchTreeOpertaions {



    }



}

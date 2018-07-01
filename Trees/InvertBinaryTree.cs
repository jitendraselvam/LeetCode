﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 226. Invert Binary Tree
/// </summary>

namespace BinaryTree
{

    /**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int x) { val = x; }
* }
*/

    class Class1
    {
        public class Solution
        {
            public TreeNode InvertTree(TreeNode root)
            {

                if (root == null)
                    return root;

                TreeNode temp = root.left;
                root.left = root.right;
                root.right = temp;
                if (root.left != null)
                    InvertTree(root.left);
                if (root.right != null)
                    InvertTree(root.right);
                return root;
            }
        }
    }
}

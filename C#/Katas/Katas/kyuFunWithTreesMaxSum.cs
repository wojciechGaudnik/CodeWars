using System;

namespace Katas
{
    public class kyuFunWithTreesMaxSum
    {
        public static void Main(string[] args)
        {
            var root1 = new TreeNode();
            var node2 = new TreeNode();
            var node3 = new TreeNode();
            var node4 = new TreeNode();
            var node5 = new TreeNode();
            root1.value = 1;
            node2.value = 2;
            node3.value = 3;
            node4.value = 4;
            node5.value = 5;
            root1.right = node2;
            node2.right = node3;
            node2.left = node4;
            root1.left = node5;
            Console.WriteLine(MaxSum(root1));

        }

        public static int MaxSum(TreeNode root)
        {
            if (root == null) return 0;
            var right = MaxSum(root.right);
            var left = MaxSum(root.left);
            return root.value + (right > left ? right:left);
        }
    }

    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int value;


    }
}
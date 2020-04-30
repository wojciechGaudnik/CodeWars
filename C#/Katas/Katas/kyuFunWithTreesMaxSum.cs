namespace Katas
{
    public class kyuFunWithTreesMaxSum
    {
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
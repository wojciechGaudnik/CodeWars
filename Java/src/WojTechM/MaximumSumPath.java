package WojTechM;

/**
 * Given a binary tree consisting of nodes with positive integer values,
 * write a method - maxSumPath that returns the maximum sum of values obtained by traversing nodes along
 * a path between root node, and any leaf node of the tree.
 *
 *      1
 *     / \
 *    2   3         => 11 = 1 + 3 + 7
 *   / \ / \
 *  4  5 6  7
 *
 *
 *       10
 *     /   \
 *    1     30      => 61 = 10 + 1 + 50
 *   / \   / \
 *  1  50 1  1
 *
 * @author Wojciech Makieła
 */

class MaximumSumPath {

	public static void main(String[] args) {
//		var nodel = new TreeNode(2, 4, 5);
//		var noder = new TreeNode(3, 6, 7);
//		var nodec = new TreeNode(1, nodel, noder);

		var nodel = new TreeNode(1, 1, 50);
		var noder = new TreeNode(30, 1, 1);
		var nodec = new TreeNode(10, nodel, noder);

		System.out.println(maxSumPath(nodec));


	}

	static int maxSumPath(TreeNode root) {
		if (root != null) {
			return root.value + (Math.max(maxSumPath(root.left), maxSumPath(root.right)));
		}
		return 0;
	}
}
   

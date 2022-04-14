package WojTechM;

/**
 * Given a binary tree consisting of nodes with positive integer values,
 * write a method - maxSumPath that returns the maximum sum of values obtained by traversing nodes along
 * a path between root node, and any leaf node of the tree.
 * <p>
 * 1
 * / \
 * 2   3         => 11 = 1 + 3 + 7
 * / \ / \
 * 4  5 6  7
 * <p>
 * <p>
 * 10
 * /   \
 * 1     30      => 61 = 10 + 1 + 50
 * / \   / \
 * 1  50 1  1
 *
 * @author Wojciech Makieła
 */

class MaximumSumPath {

	static int maxSumPath(TreeNode root) {
		if (root != null) {
			return root.value + (Math.max(maxSumPath(root.left), maxSumPath(root.right)));
		}
		return 0;
	}
}
   

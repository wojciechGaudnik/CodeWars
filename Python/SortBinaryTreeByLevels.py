from _collections import deque

class Node:
	def __init__(self, L, R, n):
		self.left = L
		self.right = R
		self.value = n



	
	
level1node1 = Node(None, None, 2)
level2node1 = Node(None, None, 8)
level2node2 = Node(None, None, 9)
level3node1 = Node(None, None, 1)
level3node2 = Node(None, None, 3)
level3node3 = Node(None, None, 4)
level3node4 = Node(None, None, 5)
level2node1.left = level3node1
level2node1.right = level3node2
level2node2.left = level3node3
level2node2.right = level3node4
level1node1.left = level2node1
level1node1.right = level2node2


def tree_by_levels(node):
	if not node:
		return []
	res, queue = [], deque({node, })
	while queue:
		n = queue.popleft()
		res.append(n.value)
		if n.left is not None:
			queue.append(n.left)
		if n.right is not None:
			queue.append(n.right)
	return res


print(tree_by_levels(level1node1))


package linked_lists_push_build_one_two_three.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

class NodeTest {
	@Test
	public void testPush() {
		// tests for inserting a node before another node.
		assertEquals("Should be able to create a new linked list with push().", 1, Node.push(null, 1).data);
		assertEquals("Should be able to create a new linked list with push().", null, Node.push(null, 1).next);
		assertEquals("Should be able to prepend a node to an existing node.", 2, Node.push(new Node(1), 2).data);
		assertEquals("Should be able to prepend a node to an existing node.", 1, Node.push(new Node(1), 2).next.data);
	}

	@Test
	public void testBuild123() {
		// tests for building a linked list.
		assertEquals("Value at index 0 should be 1.", 1, Node.buildOneTwoThree().data);
		assertEquals("Value at index 1 should be 2.", 2, Node.buildOneTwoThree().next.data);
		assertEquals("Value at index 2 should be 3.", 3, Node.buildOneTwoThree().next.next.data);
		assertEquals("Value at index 3 should be null.", null, Node.buildOneTwoThree().next.next.next);
	}
}
package linked_lists_push_build_one_two_three.kyu7;

public class Node {
	public static void main(String[] args) {

	}

	int data;
	Node next = null;

	Node(final int data) {
		this.data = data;
	}

	public static Node push(final Node head, final int data) {
		if (head == null) {
			return new Node(data);
		}
		var first = new Node(data);
		first.next = head;
		return first;
	}

	public static Node buildOneTwoThree() {
		var node1 = new Node(1);
		var node2 = new Node(2);
		var node3 = new Node(3);
		node1.next = node2;
		node2.next = node3;
		return node1;
	}
}

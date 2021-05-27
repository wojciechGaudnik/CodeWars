package linked_lists_append.kyu7;

public class Node {
	int data;
	Node next = null;

	Node(final int data) {
		this.data = data;
	}

	public Node(int data, Node next) {
		this.data = data;
		this.next = next;
	}

	public static Node append(Node listA, Node listB) {
		if (listA == null && listB == null) {
			return null;
		}
		if (listA == null || listB == null) {
			return (listA != null) ? listA : listB;
		}
		Node temp = listA;
		while (true) {
			if (temp.next == null) {
				temp.next = listB;
				return listA;
			}
			temp = temp.next;
		}
	}
}

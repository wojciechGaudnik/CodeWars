package FunWithListsLength;

import lombok.experimental.Helper;

class Solution {

	public static void main(String[] args) {
		Node node = new Node(1);
		node.next = new Node(2);
		node.next.next = new Node(2);
		System.out.println(length(node));
	}
	static int length(Node head) {

		return (head == null)? 0:length(head.next) + 1;
	}
}


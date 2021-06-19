package fun_with_lists_filter.kyu6;

import java.util.function.Predicate;

public class Solution {
	static <T> Node<T> filter(Node<T> head, Predicate<T> p) {
		if (head == null) {
			return null;
		} else if (p.test(head.data)) {
			return new Node<>(head.data, filter(head.next, p));
		} else {
			return filter(head.next, p);
		}
	}

}

class Node<T> {
	public T data;
	public Node<T> next;

	Node(T data, Node next) {
		this.data = data;
		this.next = next;
	}

	Node(T data) {
		this(data, null);
	}
}
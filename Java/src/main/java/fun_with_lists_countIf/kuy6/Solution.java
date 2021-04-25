package fun_with_lists_countIf.kuy6;

import java.util.function.Predicate;

public class Solution {

	static <T> int countIf(Node<T> head, Predicate<T> p) {
		var answer = 0;
		while (head != null) {
			if (p.test(head.data)) {
				answer++;
			}
			head = head.next;
		}
		return answer;
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
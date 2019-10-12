package FunWithListsMap;

import java.util.function.Function;

class Solution {

	public static void main(String[] args) {
		Function<Integer, Integer> ff = x -> x * 2;

		System.out.println(ff.apply(10));

	}

	static <T, R> Node<R> map(Node<T> head, Function<T, R> f) {
		return head == null? null: new Node<>(f.apply(head.data), map(head.next, f));
	}
}

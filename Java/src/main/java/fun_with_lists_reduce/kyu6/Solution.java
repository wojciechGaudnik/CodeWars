package fun_with_lists_reduce.kyu6;

import java.util.function.BiFunction;

public class Solution {
	static <T> T reduce(Node<T> head, BiFunction<T, T, T> f, T init) {
		T answer = init;
		while (head != null) {
			answer = f.apply(answer, head.data);
			head = head.next;
		}
		return answer;
	}
}


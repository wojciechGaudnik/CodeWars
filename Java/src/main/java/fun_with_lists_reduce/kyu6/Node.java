package fun_with_lists_reduce.kyu6;

public class Node<T> {
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

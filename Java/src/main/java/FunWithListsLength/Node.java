package FunWithListsLength;

class Node<T> {
	public T data;
	public Node next;

	Node(T data, Node next) {
		this.data = data;
		this.next = next;
	}

	Node(T data) {
		this(data, null);
	}
}

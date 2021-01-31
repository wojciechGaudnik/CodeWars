package convert_a_linked_list_to_a_string.kyu7;

public class Kata {

	public static String stringify(Node list) {
		var answer = "";
		while (list != null) {
			answer += list.getData() + " -> ";
			list = list.getNext();
		}
		return answer + "null";
	}
}

class Node {
	private int data;
	private Node next;

	public Node(int data, Node next) {
		this.data = data;
		this.next = next;
	}

	public Node(int data) {
		this.data = data;
		this.next = null;
	}

	public int getData() {
		return data;
	}

	public Node getNext() {
		return next;
	}
}
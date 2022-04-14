package linked_lists_get_nth_node.kyu7;

public class Node {

	public int data;
	public Node next = null;

	public static int getNth(Node n, int index) throws Exception {
		while (index != 0) {
			index--;
			n = n.next;
		}
		return n.data;
	}
}

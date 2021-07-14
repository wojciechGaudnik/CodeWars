package strategy_other;

import java.util.List;

public class Client {
	public static void main(String[] args) {
		var list = List.of("a", "b", "c");
		var context = new Context(new BubbleSortStrategyImpl(), new BinarySearchStrategyImpl());
		context.sort(list);
		context.search("s");
	}
}

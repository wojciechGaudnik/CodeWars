package strategy_plus_lambda;

import java.util.List;
import java.util.function.Consumer;
import java.util.function.Function;

public class Client {
	public static void main(String[] args) {
		var list = List.of("a", "b", "c");
		Consumer<List<String>> bubbleSort = l -> System.out.println("Bubble sort lambda");
		Function<List<String>, String> binarySearch = l -> {
			System.out.println("Binary Search");
			return null;
		};

		var context = new Context(bubbleSort, binarySearch);
		var searchedElement = context.search(list);
		System.out.println("____________________________________________________________________________________________________");
		Consumer<List<String>> quickSort = list1 -> System.out.println("List sorted using Quick sort implementation");
		Function<List<String>, String> linearSearch = l -> {
			System.out.println("list is linearly searched");
			return null;
		};
		context.setSortStrategy(quickSort);
		context.setSearchStrategy(linearSearch);
		context.sort(list);
		context.search(list);
	}
}

package follow_that_spy.kyu6;

import java.util.ArrayDeque;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.stream.Collectors;

public class Routes {

	public String findRoutes(String[][] routes) {
		var listA = Arrays.stream(routes).collect(Collectors.toList());
		var listB = new ArrayList<String[]>();
		var queue = new ArrayDeque<String>();
		queue.push(listA.get(0)[1]);
		queue.push(listA.get(0)[0]);
		listA.remove(0);
		while (listA.size() > 0) {
			while (!listA.isEmpty()) {
				if (listA.get(0)[0].equals(queue.getLast())) {
					queue.addLast(listA.get(0)[1]);
					listA.remove(0);
				} else if (listA.get(0)[1].equals(queue.getFirst())) {
					queue.addFirst(listA.get(0)[0]);
					listA.remove(0);
				} else {
					listB.add(Arrays.copyOf(listA.get(0), 2));
					listA.remove(0);
				}
			}
			listA.addAll(listB);
			listB.clear();
		}
		return String.join(", ", queue);
	}


}

package difference_between_two_collections.kyu7;

import java.util.Collection;
import java.util.Comparator;
import java.util.LinkedList;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class Kata {

	public static List<Character> diff(Collection<Character> a, Collection<Character> b) {
		var answer = new LinkedList<Character>();
		for (var one : a) {
			if (!b.contains(one)) {
				answer.add(one);
			}
		}
		for (var one : b) {
			if (!a.contains(one)) {
				answer.add(one);
			}
		}
		return answer.stream().distinct().sorted(Comparator.naturalOrder()).collect(Collectors.toList());
	}


	public static List<Character> diff1(Collection<Character> a, Collection<Character> b) {
		return Stream.concat(a.stream(), b.stream()).distinct().sorted(Comparator.naturalOrder()).collect(Collectors.toList());

	}
}

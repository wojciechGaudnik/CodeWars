package StringCombat;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class StringCombat {

	public static void main(String[] args) {
		System.out.println(combat("boy", "girl"));
		System.out.println(Character.toString(64));
		System.out.println((int)'A');
		System.out.println((int)'a');
	}

	public static String combat(String s1, String s2) {
//		List<Character> s1arr = s1.chars().mapToObj(e -> (char)e).collect(Collectors.toList());
//		List<Character> s2arr = s2.chars().mapToObj(e -> (char)e).collect(Collectors.toList());
		List<Character> s1arr = s1.chars().mapToObj(e -> {
			if (Character.isLowerCase(e)) {
				return (char) (e - 96);
			} else {
				return (char) (e - 38);
			}
		}).collect(Collectors.toList());
		List<Character> s2arr = s2.chars().mapToObj(e -> {
			if (Character.isLowerCase(e)) {
				return (char) (e - 96);
			} else {
				return (char) (e - 38);
			}
		}).collect(Collectors.toList());


		while (s1arr.size() != 0 && s2arr.size() != 0) {
			if (s1arr.get(0) > s2arr.get(0)) {
				s2arr.remove(0);
				char red = (char) Math.round(s1arr.remove(0) * (double)(1 / 3));
				s1arr.add(0, red);
			} else {
				s1arr.remove(0);
				char red = (char) Math.round(s2arr.remove(0) * (double)(1 / 3));
				s2arr.add(0, red);
			}

		}
		System.out.println(s1arr);
		System.out.println(s2arr);

		return "";
	}
}

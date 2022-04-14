package FlamesGameVersion1;

import java.util.*;
import java.util.stream.Collectors;

public class Flames {

	public static String showRelationship(String male, String female) {
		System.out.println(male + " " + female);
		List<String> flames = new ArrayList<>() {{
			add("Friendship");
			add("Love");
			add("Affection");
			add("Marriage");
			add("Enemies");
			add("Siblings");
		}};
		Set<Character> commonSet = male.toUpperCase().chars().mapToObj(e -> (char) e).collect(Collectors.toSet());
		Set<Character> femaleSet = female.toUpperCase().chars().mapToObj(e -> (char) e).collect(Collectors.toSet());
		commonSet.retainAll(femaleSet);
		String common = (commonSet.size() > 0) ? (male + female).replaceAll(commonSet.toString().replaceAll(" ", ""), "") : male + female;
		System.out.println(common.length());
		return flames.get((common.length() - 1) % 6);
	}
}

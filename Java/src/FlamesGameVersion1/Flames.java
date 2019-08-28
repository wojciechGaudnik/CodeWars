package FlamesGameVersion1;

import java.util.*;
import java.util.stream.Collectors;

public class Flames {

	public static void main(String[] args) {
		System.out.println(showRelationship("JOE", "ANN"));
//		System.out.println(Flames.showRelationship("NEIL", "MAE"));
//		System.out.println(Flames.showRelationship("KEVIN", "KATH"));
		System.out.println(Flames.showRelationship("XRWFKIBL", "KYRZUEJ") + "        <---Enemies");
//		System.out.println(Flames.showRelationship("XWFIBL", "YZUEJ") + "        <---Enemies");
	}

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
		String common = (commonSet.size() > 0)?(male + female).replaceAll(commonSet.toString().replaceAll(" ", ""), ""): male + female;
		System.out.println(common.length());
		return flames.get((common.length() -1) % 6);
	}

	//	    System.out.println(maleSet.size());
//		System.out.println(femaleSet.size());
//		System.out.println(malePlusFemaleSet.size());
//		System.out.println(malePlusFemaleSet.size() - 1 -(((maleSet.size() + femaleSet.size()) - malePlusFemaleSet.size())));
	//		Set<Character> combined = new HashSet<>();

}

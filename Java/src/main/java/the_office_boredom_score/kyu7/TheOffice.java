package the_office_boredom_score.kyu7;

import java.util.HashMap;

public class TheOffice {

	public static String boredom(Person[] staff) {
		var map = new HashMap<String, Integer>();
		map.put("accounts", 1);
		map.put("finance", 2);
		map.put("canteen", 10);
		map.put("regulation", 3);
		map.put("trading", 6);
		map.put("change", 6);
		map.put("IS", 8);
		map.put("retail", 5);
		map.put("pissing about", 25);
		map.put("cleaning", 4);
		var answer = 0;
		for (var one : staff) {
			answer += map.get(one.department);
		}
		if (answer <= 80) {
			return "kill me now";
		} else if (answer < 100) {
			return "i can handle this";
		}
		return "party time!!";
	}
}


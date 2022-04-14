package the_office_i_outed.kyu7;

import java.util.Arrays;

public class TheOffice {
	public static String outed(Person[] meet, String boss) {
		var totalScore = Arrays.stream(meet).mapToInt(w -> (w.name.equals(boss) ? w.happiness * 2 : w.happiness)).sum();
		return ((totalScore * 1.0) / meet.length) <= 5 ? "Get Out Now!" : "Nice Work Champ!";
	}
}

class Person {
	final String name;    // team memnber's name
	final int happiness;  // happiness rating out of 10

	Person(String name, int happiness) {
		this.name = name;
		this.happiness = happiness;
	}
}
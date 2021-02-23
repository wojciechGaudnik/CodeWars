package the_office_i_outed.kyu7;

import java.util.Arrays;

public class TheOffice {
	public static void main(String[] args) {
		Person[] meet = new Person[] {
				new Person("tim", 0),
				new Person("jim", 2),
				new Person("randy", 0),
				new Person("sandy", 7),
				new Person("andy", 0),
				new Person("katie", 5),
				new Person("laura", 1),
				new Person("saajid", 2),
				new Person("alex", 3),
				new Person("john", 2),
				new Person("mr", 0)
		};
		System.out.println(outed(meet, "laura"));
	}
	public static String outed(Person[] meet, String boss) {
		var totalScore = Arrays.stream(meet).mapToInt(w -> (w.name.equals(boss)? w.happiness * 2: w.happiness)).sum();
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
package suzuki_needs_help_lining_up_his_students.kyu7;

import java.util.Arrays;
import java.util.Comparator;

public class Kata {
	public static String[] lineupStudents(String students) {
		return Arrays.stream(students.split(" "))
				.sorted(Comparator.comparing(String::length)
						.thenComparing(String::compareTo).reversed())
				.toArray(String[]::new);
	}
}

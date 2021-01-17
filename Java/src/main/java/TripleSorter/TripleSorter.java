package TripleSorter;

import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class TripleSorter {

	public static String sort(List<Student> students) {
		Comparator<Student> studentComparator = Comparator.comparing(Student::getGpa).reversed()
		                                    .thenComparing(student -> student.getFullName().split(" ")[1].charAt(0))
		                                    .thenComparing(Student::getAge);
		return students.stream().sorted(studentComparator).map(s -> s.getFullName()).collect(Collectors.joining(","));
	}
}
